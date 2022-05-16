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
using System.Net;

namespace PetrolStationDB.Views.EmployeesView
{
    public partial class EmployeesWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        EmployeeController controller = null;
        PetrolStationController psCtrl = null;
        List<Employee> employees = null;
        List<PetrolStation> psItems = null;
        string strDefaultUrl = "https://secure.gravatar.com/avatar/833c2d4165b70f183a27744cfc123396?s=100&d=mm&r=g";
        public EmployeesWindow(User _user, MainWindow _form)
        {
            mUser = _user;
            mainWindow = _form;
            controller = new EmployeeController();
            psCtrl = new PetrolStationController();
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void ClearFilters()
        {
            commonSearchBox.Text = String.Empty;
            lastNameSearchBox.Text = String.Empty;
            firstNameSearchBox.Text = String.Empty;
            middleNameSearchBox.Text = String.Empty;
        }

        private Image GetImageFromUrl(string url)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (Stream stream = httpWebReponse.GetResponseStream())
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        private void UpdateForm(string search = "", string field = "")
        {
            switch (mUser.Role)
            {
                case "user":
                    dataEmployeesGV.Columns[11].Visible = false;
                    dataEmployeesGV.Columns[12].Visible = false;
                    break;
            }
            dataEmployeesGV.Rows.Clear();

            this.employees = controller.GetEmployees(search, field);
            if(this.employees != null)
            {
                PetrolStation ps = null;
                for(int i = 0; i < this.employees.Count; i++)
                {
                    dataEmployeesGV.Rows.Add();
                    dataEmployeesGV[0, i].Value = i + 1;
                    dataEmployeesGV[1, i].Value = employees[i].PersonnelNumber;
                    dataEmployeesGV[2, i].Value = employees[i].LastName;
                    dataEmployeesGV[3, i].Value = employees[i].FirstName;
                    dataEmployeesGV[4, i].Value = employees[i].MiddleName;

                    dataEmployeesGV[5, i].Value = GetImageFromUrl(employees[i].PhotoUrl);

                    ps = psCtrl.GetSinglePStation(employees[i].PetrolStationId);

                    //dataEmployeesGV[6, i].Value = employees[i].PetrolStationId;
                    dataEmployeesGV[6, i].Value = "Номер АЗС: " + ps.NumberStation + "\n, " + ps.Location;
                    dataEmployeesGV[7, i].Value = employees[i].CreatedBy;
                    dataEmployeesGV[8, i].Value = employees[i].CreatedDate.ToString();
                    dataEmployeesGV[9, i].Value = employees[i].UpdatedBy;
                    dataEmployeesGV[10, i].Value = employees[i].UpdatedDate.ToString();
                    dataEmployeesGV[11, i].Value = "Сохранить";
                    dataEmployeesGV[12, i].Value = "Удалить";
                    dataEmployeesGV[13, i].Value = employees[i].Id;
                }
            }
        }

        private void commonSearchBox_TextChanged(object sender, EventArgs e)
        {
            lastNameSearchBox.Text = string.Empty;
            firstNameSearchBox.Text = string.Empty;
            middleNameSearchBox.Text= string.Empty;
            UpdateForm(commonSearchBox.Text, "common");
        }

        private void lastNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            firstNameSearchBox.Text = string.Empty;
            middleNameSearchBox.Text = string.Empty;
            UpdateForm(lastNameSearchBox.Text, "lastname");
        }

        private void firstNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            lastNameSearchBox.Text = string.Empty;
            middleNameSearchBox.Text = string.Empty;
            UpdateForm(firstNameSearchBox.Text, "firstname");
        }

        private void middleNameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            lastNameSearchBox.Text = string.Empty;
            firstNameSearchBox.Text = string.Empty;
            UpdateForm(middleNameSearchBox.Text, "middlename");
        }

        private void EmployeesWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
            UpdateFormTwo();
            switch (mUser.Role)
            {
                case "user":
                    tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
                    break;
            }
        }

        private bool SaveDataGVChanges(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid guid = (Guid)dataEmployeesGV[13, e.RowIndex].Value;
            string lName = (string)dataEmployeesGV[2, e.RowIndex].Value;
            string fName = (string)dataEmployeesGV[3, e.RowIndex].Value;
            string mName = (string)dataEmployeesGV[4, e.RowIndex].Value;

            if(controller.SaveChangesSingleEmployee(guid, mUser.Login, lName, fName, mName))
            {
                ClearFilters();
                UpdateForm();
                result = true;
            }

            return result;
        }

        private bool DeleteDataGVChanges(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid _guid = (Guid)dataEmployeesGV[13, e.RowIndex].Value;
            if (controller.DeleteSingleEmployee(_guid))
            {
                ClearFilters();
                UpdateForm();
                result = true;
            }

            return result;
        }

        private void dataEmployeesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 11)
            {
                if (SaveDataGVChanges(e))
                {
                    MessageBox.Show("Данные успешно изменены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при записи данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (e.ColumnIndex == 12)
            {
                string message = "Вы действительно хотите удалить сотрудника?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteDataGVChanges(e))
                    {
                        MessageBox.Show("Сотрудник был успешно удалён.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void urlDefaultRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (urlDefaultRadioBtn.Checked)
            {
                inputPhotoUrlBox.Enabled = false;
            }
            else
            {
                inputPhotoUrlBox.Enabled = true;
            }
        }

        private void UpdateFormTwo()
        {
            numEmployeeBox.Text = (controller.GetMaxNumEmployees() + 1).ToString();
            inputLNameBox.Text = String.Empty;
            inputFNameBox.Text = String.Empty;
            inputMNameBox.Text = String.Empty;
            inputPhotoUrlBox.Text = String.Empty;
            psItems = psCtrl.GetAllPetrolStations();
            
            if(psItems.Count > 0)
            {
                PetrolStationCmbBox.Items.Clear();
                var listSorted = psItems.OrderBy(p => p.NumberStation);
                foreach(var item in listSorted)
                {
                    PetrolStationCmbBox.Items.Add(item.NumberStation + "; " + item.Location);
                }
                PetrolStationCmbBox.SelectedIndex = 0;
            }
        }

        private void addNewEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(inputLNameBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Фамилия\"!!");
                }

                if(inputFNameBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Имя\"!!");
                }

                if(inputMNameBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Отчество\"!!");
                }

                Employee emp = new Employee();
                emp.PersonnelNumber = Convert.ToInt32(numEmployeeBox.Text);
                emp.LastName = inputLNameBox.Text;
                emp.FirstName = inputFNameBox.Text;
                emp.MiddleName = inputMNameBox.Text;

                if (urlDefaultRadioBtn.Checked)
                {
                    emp.PhotoUrl = strDefaultUrl;
                }
                else
                {
                    emp.PhotoUrl = inputPhotoUrlBox.Text;
                }

                string[] numStat = PetrolStationCmbBox.SelectedItem.ToString().Split(';');
                foreach (var item in psItems)
                {
                    if (item.NumberStation == Convert.ToUInt32(numStat[0]))
                    {
                        emp.PetrolStationId = item.Id;
                    }
                }

                if(controller.AddSingleEmployee(mUser.Login, emp))
                {
                    MessageBox.Show("Новый сотрудник добавлен!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateForm();
                    UpdateFormTwo();
                }
                else
                {
                    MessageBox.Show("Новый сотрудник не был добавлен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
