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

namespace PetrolStationDB.Views.StructureView
{
    public partial class StructureWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        StructureController controller = null;
        PetrolStationController psController = null;
        List<PetrolStation> psItems = null;
        List<Structure> structuresList = null;
        public StructureWindow(User _user, MainWindow _form)
        {
            mainWindow = _form;
            mUser = _user;
            controller = new StructureController();
            psController = new PetrolStationController();
            InitializeComponent();
        }

        private void StructureWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
            UpdateFormTwo();
            switch (mUser.Role)
            {
                case "user":
                    dataStructureGV.Columns[10].Visible = false;
                    dataStructureGV.Columns[11].Visible = false;
                    groupBox3.Visible = false;
                    break;
            }
        }

        private void UpdateForm(string search = "", string field = "")
        {
            structuresList = controller.GetAllStructuresWithFilter(search, field);
            if(structuresList != null)
            {
                dataStructureGV.Rows.Clear();
                PetrolStation pStat = null;
                for(int i = 0; i < structuresList.Count; i++)
                {
                    dataStructureGV.Rows.Add();
                    dataStructureGV[0, i].Value = structuresList[i].Id;
                    dataStructureGV[1, i].Value = i + 1;
                    dataStructureGV[2, i].Value = structuresList[i].Name;
                    dataStructureGV[3, i].Value = Math.Round(structuresList[i].Square, 1);

                    pStat = psController.GetSinglePStation(structuresList[i].PetrolStationId);
                    dataStructureGV[4, i].Value = pStat.NumberStation + ", " + pStat.Location;

                    dataStructureGV[5, i].Value = controller.GetCountEquipmentsForStructure(structuresList[i].Id);
                    dataStructureGV[6, i].Value = structuresList[i].CreatedBy;
                    dataStructureGV[7, i].Value = structuresList[i].CreatedDate;
                    dataStructureGV[8, i].Value = structuresList[i].UpdatedBy;
                    dataStructureGV[9, i].Value = structuresList[i].UpdatedDate;
                    dataStructureGV[10, i].Value = "Сохранить";
                    dataStructureGV[11, i].Value = "Удалить";
                }
            }
        }

        private void UpdateFormTwo()
        {
            psItems = psController.GetAllPetrolStations();
            if (psItems != null)
            {
                petrolStatCmbBox.Items.Clear();
                var listItems = psItems.OrderBy(ps => ps.NumberStation);
                foreach (var item in listItems)
                {
                    petrolStatCmbBox.Items.Add(item.NumberStation + "; " + item.Location);
                }
                petrolStatCmbBox.SelectedIndex = 0;
            }
        }

        private void ClearFilters()
        {
            commonSearchBox.Text = string.Empty;
            nameSearchBox.Text = string.Empty;
            squareSearchBox.Text = string.Empty;
        }

        private void clearFiltersBtn_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }

        private void ValidateInputSymbols(KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)ConsoleKey.Backspace || e.KeyChar == ','))
            {
                e.KeyChar = '\0';
            }
        }

        private void squareSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputSymbols(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputSymbols(e);
        }

        private void commonSearchBox_TextChanged(object sender, EventArgs e)
        {
            nameSearchBox.Text = string.Empty;
            squareSearchBox.Text = string.Empty;
            UpdateForm(commonSearchBox.Text, "common");
        }

        private void nameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            squareSearchBox.Text= string.Empty;
            UpdateForm(nameSearchBox.Text, "name");
        }

        private void squareSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = string.Empty;
            nameSearchBox.Text = string.Empty;
            UpdateForm(squareSearchBox.Text, "square");
        }

        private bool SaveSingleStructure(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid guid = (Guid)dataStructureGV[0, e.RowIndex].Value;
            string name = dataStructureGV[2, e.RowIndex].Value.ToString();
            decimal square = Convert.ToDecimal(dataStructureGV[3, e.RowIndex].Value);

            if(controller.SaveSingleStructure(mUser.Login, guid, name, square))
            {
                ClearFilters();
                UpdateForm();
                result = true;
            }

            return result;
        }

        private bool DeleteStructure(DataGridViewCellEventArgs e)
        {
            bool delete = false;

            Guid guid = (Guid)dataStructureGV[0, e.RowIndex].Value;

            if (controller.DeleteSingleStructure(guid))
            {
                ClearFilters();
                UpdateForm();
                delete = true;
            }

            return delete;
        }

        private void dataStructureGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 10)
            {
                if (SaveSingleStructure(e))
                {
                    MessageBox.Show("Данные успешно изменены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при записи данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(e.ColumnIndex == 11)
            {
                string message = "Вы действительно хотите удалить сооружение?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteStructure(e))
                    {
                        MessageBox.Show("Сооружение было успешно удалено.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void addStructureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Название\"!!");
                }

                if(textBox2.Text == String.Empty)
                {
                    throw new Exception("Необходимо заполнить поле \"Площадь\"!!");
                }

                Guid _guid = Guid.Empty;
                string[] strArr = petrolStatCmbBox.SelectedItem.ToString().Split(';');
                foreach(var item in psItems)
                {
                    if(item.NumberStation == Convert.ToInt32(strArr[0])) { _guid = item.Id; break; }
                }

                if(controller.AddNewStructure(mUser.Login, textBox1.Text, Convert.ToDecimal(textBox2.Text), _guid))
                {
                    ClearFilters();
                    UpdateForm();
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                    MessageBox.Show("Новое сооружение успешно добавлено!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Не получилось добавить данные!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
