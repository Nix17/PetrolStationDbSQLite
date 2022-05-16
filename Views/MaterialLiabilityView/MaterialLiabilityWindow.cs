using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Controllers;

namespace PetrolStationDB.Views.MaterialLiabilityView
{
    public partial class MaterialLiabilityWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        MaterialLiabilityController controller = null;
        EmployeeController empCtrl = null;
        EquipmentController equipCtrl = null;
        StructureController structureCtrl = null;

        List<MaterialLiability> mainItems = null;
        List<Employee> empItems = null;
        List<Equipment> equipItems = null;
        public MaterialLiabilityWindow(User _user, MainWindow _form)
        {
            mUser = _user;
            mainWindow = _form;
            controller = new MaterialLiabilityController();
            empCtrl = new EmployeeController();
            equipCtrl = new EquipmentController();
            structureCtrl = new StructureController();
            InitializeComponent();
        }

        private void UpdateForm()
        {
            mainItems = controller.GetMaterialLiabilities();
            if(mainItems != null)
            {
                dataMatLiabGV.Rows.Clear();
                for(int i = 0; i < mainItems.Count; i++)
                {
                    dataMatLiabGV.Rows.Add();
                    dataMatLiabGV[0, i].Value = mainItems[i].Id;
                    dataMatLiabGV[1, i].Value = i + 1;

                    Employee emp;
                    if((emp = empCtrl.GetSingleEmployeeById(mainItems[i].EmployeeId)) != null)
                    {
                        dataMatLiabGV[2, i].Value = emp.PersonnelNumber + " -- " + emp.LastName + " " + emp.FirstName[0] + "." + emp.MiddleName[0] + ".";
                    }
                    else
                    {
                        dataMatLiabGV[2, i].Value = "Не найдено";
                    }

                    Equipment equip;
                    if((equip = equipCtrl.GetSingleEquipmentById(mainItems[i].EquipmentId)) != null)
                    {
                        dataMatLiabGV[3, i].Value = equip.InventoryNumber + " -- " + equip.Name;

                        Structure structure;
                        if((structure = structureCtrl.GetSingleStructure(equip.StructureId)) != null)
                        {
                            dataMatLiabGV[4, i].Value = structure.Name;
                        }
                        else
                        {
                            dataMatLiabGV[4, i].Value = "Не найдено";
                        }
                    }
                    else
                    {
                        dataMatLiabGV[3, i].Value = "Не найдено";
                        dataMatLiabGV[4, i].Value = "Не найдено";
                    }

                    dataMatLiabGV[5, i].Value = mainItems[i].CreatedBy;
                    dataMatLiabGV[6, i].Value = mainItems[i].CreatedDate.ToString();
                    dataMatLiabGV[7, i].Value = mainItems[i].UpdatedBy;
                    dataMatLiabGV[8, i].Value = mainItems[i].UpdatedDate.ToString();
                    dataMatLiabGV[9, i].Value = "Удалить";
                }
            }
        }

        private void UpdateEmployeeCmbBox()
        {
            empItems = empCtrl.GetEmployees();
            if(empItems != null)
            {
                chooseEmployeeCmbBox.Items.Clear();
                foreach(var item in empItems)
                {
                    chooseEmployeeCmbBox.Items.Add(item.PersonnelNumber + "; " + item.LastName + " " + item.FirstName[0] + "." + item.MiddleName[0] + ".");
                }
                chooseEmployeeCmbBox.SelectedIndex = 0;
            }
        }

        private void UpdateEquipmentCmbBox()
        {
            equipItems = equipCtrl.GetEquipmentsByFilters();
            if(equipItems != null)
            {
                chooseEquipmentCmbBox.Items.Clear();
                foreach(var item in equipItems)
                {
                    Structure structure = structureCtrl.GetSingleStructure(item.StructureId);
                    if(structure != null)
                    {
                        chooseEquipmentCmbBox.Items.Add(item.Name + "; " + structure.Name);
                    }
                }
                chooseEquipmentCmbBox.SelectedIndex = 0;
            }
        }

        private void MaterialLiabilityWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
            UpdateEmployeeCmbBox();
            UpdateEquipmentCmbBox();
            switch (mUser.Role)
            {
                case "user":
                    groupBox2.Visible = false;
                    dataMatLiabGV.Columns[9].Visible = false;
                    break;
            }
        }

        private void addNewMatLiabBtn_Click(object sender, EventArgs e)
        {
            MaterialLiability _matLiab = new MaterialLiability();

            string[] arrEmp = chooseEmployeeCmbBox.SelectedItem.ToString().Split(';');
            foreach (var item in empItems)
            {
                if (item.PersonnelNumber.ToString() == arrEmp[0])
                {
                    _matLiab.EmployeeId = item.Id;
                    break;
                }
            }

            string[] arrEquip = chooseEquipmentCmbBox.SelectedItem.ToString().Split(';');
            foreach(var item in equipItems)
            {
                if(item.Name == arrEquip[0])
                {
                    _matLiab.EquipmentId = item.Id;
                    break;
                }
            }

            if(controller.AddNewMaterialLiability(mUser.Login, _matLiab))
            {
                MessageBox.Show("Новые данные успешно добавлены!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Не удалось добавить данные!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DeleteMaterialLiability(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid _guid = (Guid)dataMatLiabGV[0, e.RowIndex].Value;
            if (controller.DeleteMaterialLiability(_guid))
            {
                UpdateForm();
                UpdateEmployeeCmbBox();
                UpdateEquipmentCmbBox();
                result = true;
            }

            return result;
        }

        private void dataMatLiabGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
                string message = "Вы действительно хотите удалить строку?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteMaterialLiability(e))
                    {
                        MessageBox.Show("Строка была успешно удалена.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
