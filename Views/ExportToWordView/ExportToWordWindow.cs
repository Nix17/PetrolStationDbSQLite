using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Controllers;
using PetrolStationDB.Services;

namespace PetrolStationDB.Views.ExportToWordView
{
    public partial class ExportToWordWindow : Form
    {
        List<Employee> employeesList = null;
        EmployeeController employeeController = null;
        MaterialLiabilityController materialLiabilityController = null;
        EquipmentController equipmentController = null;
        PetrolStationController petrolStationController = null;
        StructureController structureController = null;
        public ExportToWordWindow()
        {
            employeeController = new EmployeeController();
            materialLiabilityController = new MaterialLiabilityController();
            equipmentController = new EquipmentController();
            petrolStationController = new PetrolStationController();
            structureController = new StructureController();
            InitializeComponent();
        }

        private void LoadAllEmployees()
        {
            employeesList = employeeController.GetEmployees();
            if(employeesList != null)
            {
                foreach(Employee employee in employeesList)
                {
                    string FullName = employee.LastName + " " + employee.FirstName + " " + employee.MiddleName;
                    employeesCmbBox.Items.Add(employee.PersonnelNumber + "; " + FullName);
                }
                employeesCmbBox.SelectedIndex = 0;
            }
        }

        private void ExportToWordWindow_Load(object sender, EventArgs e)
        {
            exportAllPsRadioBtn.Checked = true;
            exportEquipsByEmpRadioBtn.Checked = false;
            employeesCmbBox.Enabled = false;
            LoadAllEmployees();
        }

        private void exportAllPsRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            employeesCmbBox.Enabled = false;
        }

        private void exportEquipsByEmpRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            employeesCmbBox.Enabled = true;
        }

        private void ExportEquipsByEmployee()
        {
            Employee emp = null;
            List<Equipment> equipObjList = new List<Equipment>();

            string[] strArr = employeesCmbBox.SelectedItem.ToString().Split(';');
            int personnelNumEmp = Convert.ToInt32(strArr[0]);
            foreach (var item in employeesList)
            {
                if (item.PersonnelNumber == personnelNumEmp)
                {
                    emp = item;
                    break;
                }
            }

            List<Guid> equipsIds = materialLiabilityController.GetEquipmentsIdByEmployeeId(emp.Id);
            if (equipsIds != null && equipsIds.Count > 0)
            {
                foreach (var equip in equipsIds)
                {
                    equipObjList.Add(equipmentController.GetSingleEquipmentById(equip));
                }

                Dictionary<Employee, List<Equipment>> sendList = new Dictionary<Employee, List<Equipment>>();
                sendList.Add(emp, equipObjList);

                using (WordService ws = new WordService())
                {
                    string nameEmp = emp.LastName + "_" + emp.FirstName[0] + "." + emp.MiddleName[0] + ".";
                    if (ws.CreateDocEquipmentByEmployee(sendList, nameEmp))
                    {
                        string mess = "Документ создан и сохранён на рабочем столе!\nСделана выписка закреплённого оборудования за сотрудником " + nameEmp.Replace('_', ' ');
                        MessageBox.Show(mess, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при создании документа", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("За данным сотрудником не закреплено ни одно оборудование.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportAllPsWithEmp()
        {
            Dictionary<PetrolStation, List<Equipment>> psEquipObjList = new Dictionary<PetrolStation, List<Equipment>>();

            List<PetrolStation> petrolStationsList = petrolStationController.GetAllPetrolStations();
            if(petrolStationsList != null && petrolStationsList.Count > 0)
            {
                foreach (PetrolStation petrolStation in petrolStationsList)
                {
                    List<Equipment> equipmentList = new List<Equipment>();

                    List<Guid> structuresGuidsList = structureController.GetStructureIdByPetrolStationId(petrolStation.Id);

                    if(structuresGuidsList != null && structuresGuidsList.Count > 0)
                    {
                        foreach(var structuresGuid in structuresGuidsList)
                        {
                            List<Equipment> items = equipmentController.GetEquipmentsByStructureId(structuresGuid);
                            if(items != null && items.Count > 0)
                            {
                                equipmentList.AddRange(items);
                            }
                        }
                    }
                    else
                    {
                        equipmentList.Add(new Equipment
                        {
                            Id = Guid.Empty,
                            Name = "Нет оборудования.",
                            InventoryNumber = 0,
                            Price = 0,
                            DateOfRelease = DateTime.Today
                        });
                    }
                    
                    
                    if (equipmentList.Count == 0)
                    {
                        equipmentList.Add(new Equipment
                        {
                            Id = Guid.Empty,
                            Name = "Нет оборудования.",
                            InventoryNumber = 0,
                            Price = 0,
                            DateOfRelease = DateTime.Today
                        });
                    }

                    psEquipObjList.Add(petrolStation, equipmentList);
                }

                using (WordService ws = new WordService())
                {
                    if (ws.CreateDocListPetrolStationWithEquipment(psEquipObjList))
                    {
                        string mess = "Документ создан и сохранён на рабочем столе!\nСделана выписка закреплённого оборудования за каждой АЗС.";
                        MessageBox.Show(mess, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при создании документа", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет ни одной АЗС в БД!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (exportEquipsByEmpRadioBtn.Checked)
            {
                ExportEquipsByEmployee();
            }
            else if (exportAllPsRadioBtn.Checked)
            {
                ExportAllPsWithEmp();
            }
        }
    }
}
