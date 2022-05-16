using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetrolStationDB.Services;
using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Controllers;
using PetrolStationDB.Views.Profile;
using PetrolStationDB.Views.PetrolStationTypeView;
using PetrolStationDB.Views.PetrolStationView;
using PetrolStationDB.Views.EmployeesView;
using PetrolStationDB.Views.EquipmentView;
using PetrolStationDB.Views.MaterialLiabilityView;
using PetrolStationDB.Views.StructureView;
using PetrolStationDB.Views.ExportToWordView;

namespace PetrolStationDB.Views
{
    public partial class MainWindow : Form
    {
        User mUser = null;
        authForm aForm = null;
        PetrolStationController controller = null;
        List<PetrolStation> psItems = null;
        public MainWindow(User _user, authForm _from)
        {
            mUser = _user;
            aForm = _from;
            controller = new PetrolStationController();
            InitializeComponent();
            switch (_user.Role)
            {
                case "user":
                    typePsBtn.Visible = false;
                    addPsBtn.Visible = false;
                    dataPsGV.Columns[9].Visible = false;
                    backupDbBtn.Visible = false;
                    break;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Вы уверены, что хотите выйти?";
            if (MessageBox.Show(message, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                if (aForm != null)
                {
                    aForm.Show();
                }
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileWindow profWindow = new ProfileWindow(mUser);
                profWindow.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void typePsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PetrolStationTypeWindow psTypeWindow = new PetrolStationTypeWindow(mUser, this);
                psTypeWindow.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addPsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PetrolStationWindow psWindow = new PetrolStationWindow(mUser, this);
                psWindow.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeesWindow employeesWindow = new EmployeesWindow(mUser, this);
                employeesWindow.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void structuresBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StructureWindow structureWindow = new StructureWindow(mUser, this);
                structureWindow.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void equipmentsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                EquipmentWindow equipmentWindow = new EquipmentWindow(mUser, this);
                equipmentWindow.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialLiabilityBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialLiabilityWindow materialLiabilityWindow = new MaterialLiabilityWindow(mUser, this);
                materialLiabilityWindow.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainClearFilters()
        {
            mainCommonSearchBox.Text = String.Empty;
            mainLocationPStatSearchBox.Text = String.Empty;
            mainNumPStatSearchBox.Text = String.Empty;
        }

        public void MainUpdateForm(string search = "", string field = "")
        {
            psItems = controller.GetAllPetrolStations(search, field);
            if(psItems != null)
            {
                dataPsGV.Rows.Clear();
                for(int i = 0; i < psItems.Count; i++)
                {
                    dataPsGV.Rows.Add();
                    dataPsGV[0, i].Value = psItems[i].Id;
                    dataPsGV[1, i].Value = psItems[i].NumberStation;
                    dataPsGV[2, i].Value = psItems[i].Location;

                    string psType = controller.GetTypeNameForSinglePetrolStation(psItems[i].PetrolStationTypeId);

                    dataPsGV[3, i].Value = psType;

                    dataPsGV[4, i].Value = "Показать список";
                    dataPsGV[5, i].Value = psItems[i].CreatedBy;
                    dataPsGV[6, i].Value = psItems[i].CreatedDate.ToString();
                    dataPsGV[7, i].Value = psItems[i].UpdatedBy;
                    dataPsGV[8, i].Value = psItems[i].UpdatedDate.ToString();
                    dataPsGV[9, i].Value = "Удалить";
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            MainClearFilters();
            MainUpdateForm();
        }

        private void mainCommonSearchBox_TextChanged(object sender, EventArgs e)
        {
            mainNumPStatSearchBox.Text = String.Empty;
            mainLocationPStatSearchBox.Text = String.Empty;
            MainUpdateForm(mainCommonSearchBox.Text, "common");
        }

        private void mainNumPStatSearchBox_TextChanged(object sender, EventArgs e)
        {
            mainCommonSearchBox.Text = String.Empty;
            mainLocationPStatSearchBox.Text = String.Empty;
            MainUpdateForm(mainNumPStatSearchBox.Text, "numPStation");
        }

        private void mainLocationPStatSearchBox_TextChanged(object sender, EventArgs e)
        {
            mainCommonSearchBox.Text = String.Empty;
            mainNumPStatSearchBox.Text = String.Empty;
            MainUpdateForm(mainLocationPStatSearchBox.Text, "location");
        }

        private void mainClearBtn_Click(object sender, EventArgs e)
        {
            MainClearFilters();
        }

        private bool DeletePetrolStation(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid _guid = (Guid)dataPsGV[0, e.RowIndex].Value;
            if (controller.DeletePetrolStationById(_guid))
            {
                MainClearFilters();
                MainUpdateForm();
                result = true;
            }

            return result;
        }

        private void dataPsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                Guid _guid = (Guid)dataPsGV[0, e.RowIndex].Value;
                string _psName = dataPsGV[1, e.RowIndex].Value + "; " + dataPsGV[2, e.RowIndex].Value;
                ListEquipmentFromPS listForm = new ListEquipmentFromPS(_guid, _psName);
                listForm.Show();
            }else if(e.ColumnIndex == 9)
            {
                string message = "Вы действительно хотите удалить АЗС?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeletePetrolStation(e))
                    {
                        MessageBox.Show("АЗС была успешно удалена.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void commonMaxPriceEqPsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PetrolStation res = controller.GetPetrolStationCommonMaxPriceEquipments();
                if (res != null)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("АЗС с масимальной общей стоимостью оборудования:\n");
                    stringBuilder.Append("Номер -- " + res.NumberStation + "\n");
                    stringBuilder.Append("Локация -- " + res.Location);
                    MessageBox.Show(stringBuilder.ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportToWordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWordWindow exportForm = new ExportToWordWindow();
                exportForm.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backupDbBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (BackupDatabase backupMySqlDatabase = new BackupDatabase())
                {
                    // SQLite

                    if (backupMySqlDatabase.BackupSQLiteDbToDesktop("sqlite_petrol_station"))
                    {
                        MessageBox.Show("Бэкап БД успешно сделан. Файл на рабочем столе.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не получилось создать бэкап!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // MySQL
                    /*if (backupMySqlDatabase.BackupMySqlDbToDesktop("server=localhost;user=root;pwd=;database=petrol_station;"))
                    {
                        MessageBox.Show("Бэкап БД успешно сделан. Файл на рабочем столе.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не получилось создать бэкап!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
