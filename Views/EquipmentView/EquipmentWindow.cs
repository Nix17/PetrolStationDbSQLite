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

namespace PetrolStationDB.Views.EquipmentView
{
    public partial class EquipmentWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        EquipmentController controller = null;
        StructureController structureController = null;
        List<Equipment> equipmentItems = null;
        List<Structure> structureItems = null;
        public EquipmentWindow(User _user, MainWindow _form)
        {
            mUser = _user;
            mainWindow = _form;
            controller = new EquipmentController();
            structureController = new StructureController();
            InitializeComponent();
        }

        private void ClearFilters()
        {
            commonSearchBox.Text = String.Empty;
            nameSearchBox.Text = String.Empty;
            priceSearchBox.Text = String.Empty;
        }

        private void UpdateForm(string search = "", string field = "")
        {
            equipmentItems = controller.GetEquipmentsByFilters(search, field);
            Structure structureItem = null;
            if(equipmentItems != null)
            {
                dataEquipmentGV.Rows.Clear();
                for(int i = 0; i < equipmentItems.Count; i++)
                {
                    dataEquipmentGV.Rows.Add();
                    dataEquipmentGV[0, i].Value = equipmentItems[i].Id;
                    dataEquipmentGV[1, i].Value = equipmentItems[i].InventoryNumber;
                    dataEquipmentGV[2, i].Value = equipmentItems[i].Name;
                    dataEquipmentGV[3, i].Value = Math.Round(equipmentItems[i].Price, 1);
                    dataEquipmentGV[4, i].Value = equipmentItems[i].DateOfRelease.ToString();
                    dataEquipmentGV[5, i].Value = equipmentItems[i].DateOfLastInventory.ToString();
                    
                    if((structureItem = structureController.GetSingleStructure(equipmentItems[i].StructureId)) != null)
                    {
                        dataEquipmentGV[6, i].Value = structureItem.Name;
                    }
                    else
                    {
                        dataEquipmentGV[6, i].Value = "Не найдено!";
                    }

                    dataEquipmentGV[7, i].Value = equipmentItems[i].CreatedBy;
                    dataEquipmentGV[8, i].Value= equipmentItems[i].CreatedDate.ToString();
                    dataEquipmentGV[9, i].Value = equipmentItems[i].UpdatedBy;
                    dataEquipmentGV[10, i].Value = equipmentItems[i].UpdatedDate.ToString();
                    dataEquipmentGV[11, i].Value = "Сохранить";
                    dataEquipmentGV[12, i].Value = "Удалить";
                }
            }
        }

        private void UpdateFormTwo()
        {
            inputNameBox.Text = String.Empty;
            inputPriceBox.Text = String.Empty;

            invNumBox.Text = (controller.GetMaxInventoryNum() + 1).ToString();
            structureItems = structureController.GetAllStructuresWithFilter();

            if(structureItems.Count > 0)
            {
                structuresCmbBox.Items.Clear();
                foreach(var item in structureItems)
                {
                    structuresCmbBox.Items.Add(item.Name);
                }
                structuresCmbBox.SelectedIndex = 0;
            }
        }

        private void EquipmentWindow_Load(object sender, EventArgs e)
        {
            ClearFilters();
            UpdateForm();
            UpdateFormTwo();
            switch (mUser.Role)
            {
                case "user":
                    tabControl1.TabPages.Remove(tabControl1.TabPages[1]);
                    dataEquipmentGV.Columns[11].Visible = false;
                    dataEquipmentGV.Columns[12].Visible = false;
                    break;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
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

        private void priceSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputSymbols(e);
        }

        private void commonSearchBox_TextChanged(object sender, EventArgs e)
        {
            nameSearchBox.Text=String.Empty;
            priceSearchBox.Text = String.Empty;
            UpdateForm(commonSearchBox.Text, "common");
        }

        private void nameSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text=String.Empty;
            priceSearchBox.Text = String.Empty;
            UpdateForm(nameSearchBox.Text, "name");
        }

        private void priceSearchBox_TextChanged(object sender, EventArgs e)
        {
            commonSearchBox.Text = String.Empty;
            nameSearchBox.Text = String.Empty;
            
            UpdateForm(priceSearchBox.Text, "price");
        }

        private bool SaveSingleEquipment(DataGridViewCellEventArgs e)
        {
            bool result = false;

            Guid _guid = (Guid)dataEquipmentGV[0, e.RowIndex].Value;
            string _name = (string)dataEquipmentGV[2, e.RowIndex].Value;
            decimal _price = Convert.ToDecimal(dataEquipmentGV[3, e.RowIndex].Value);

            if(controller.SaveChangesSingleEquipment(mUser.Login, _guid, _name, _price))
            {
                ClearFilters();
                UpdateForm();
                result = true;
            }

            return result;
        }

        private bool DeleteEquipment(DataGridViewCellEventArgs e)
        {
            bool result = false;
            Guid guid = (Guid)dataEquipmentGV[0, e.RowIndex].Value;
            if (controller.DeleteSingleEquipment(guid))
            {
                ClearFilters();
                UpdateForm();
                result = true;
            }
            return result;
        }

        private void dataEquipmentGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 11)
            {
                if (SaveSingleEquipment(e))
                {
                    MessageBox.Show("Данные успешно изменены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при записи данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(e.ColumnIndex == 12)
            {
                string message = "Вы действительно хотите удалить оборудование?";
                if (MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DeleteEquipment(e))
                    {
                        MessageBox.Show("Оборудование было успешно удалено.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении данных!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void inputPriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateInputSymbols(e);
        }

        private void addNewEquipmentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(inputNameBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо ввести название!");
                }

                if(inputPriceBox.Text == String.Empty)
                {
                    throw new Exception("Необходимо ввести цену!!");
                }

                Equipment equip = new Equipment();
                foreach (var item in structureItems)
                {
                    if (structuresCmbBox.SelectedItem == item.Name) { equip.StructureId = item.Id; break; }
                }


                equip.Name = inputNameBox.Text;
                equip.Price = Convert.ToDecimal(inputPriceBox.Text);
                equip.InventoryNumber = Convert.ToInt32(invNumBox.Text);
                equip.DateOfRelease = releaseTimePicker.Value;
                equip.DateOfLastInventory = releaseTimePicker.Value;

                if(controller.AddNewEquipment(mUser.Login, equip))
                {
                    ClearFilters();
                    UpdateForm();
                    UpdateFormTwo();
                    MessageBox.Show("Новое оборудование успешно добавлено!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
