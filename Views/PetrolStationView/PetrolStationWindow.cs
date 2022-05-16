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

namespace PetrolStationDB.Views.PetrolStationView
{
    public partial class PetrolStationWindow : Form
    {
        User mUser = null;
        MainWindow mainWindow = null;
        PetrolStationController controller = null;
        List<PetrolStationType> types = null;
        public PetrolStationWindow(User _user, MainWindow _form)
        {
            mainWindow = _form;
            mUser = _user;
            controller = new PetrolStationController();
            InitializeComponent();
        }

        private void UpdateForm(string search = "")
        {
            types = controller.GetAllTypes(search);
            if (typesCmbBox.Items.Count > 0) { typesCmbBox.Items.Clear(); }
            if(types != null)
            {
                foreach (var type in types)
                {
                    typesCmbBox.Items.Add(type.TypeName);
                }
                typesCmbBox.SelectedIndex = 0;
            }

            numStationBox.Text = (controller.GetMaxNumberStation() + 1).ToString();
        }
        private void PetrolStationWindow_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void ReloadTxtBoxes()
        {
            cityBox.Text = string.Empty; ;
            streetBox.Text = string.Empty;
            houseBox.Text = string.Empty;
            housingBox.Text = string.Empty;
            commentBox.Text = string.Empty;

            numStationBox.Text = (controller.GetMaxNumberStation() + 1).ToString();
        }

        private void addPetrolStation_Click(object sender, EventArgs e)
        {
            if(cityBox.Text != "")
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(cityBox.Text + ";");
                if (streetBox.Text != "")
                {
                    sb.Append(streetBox.Text + ";");
                    if (houseBox.Text != "")
                    {
                        sb.Append(houseBox.Text + ";");
                        if (housingBox.Text != "")
                        {
                            sb.Append(housingBox.Text + ";");
                        }
                    }
                }
                if (commentBox.Text != "")
                {
                    sb.Append(commentBox.Text);
                }

                Guid guid = Guid.Empty;
                foreach (var type in types)
                {
                    if (type.TypeName == typesCmbBox.SelectedItem.ToString())
                    {
                        guid = type.Id;
                    }
                }

                if (controller.AddNewPetrolStation(numStationBox.Text, guid, sb.ToString(), mUser.Login))
                {
                    MessageBox.Show("Данные о новой АЗС успешно добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadTxtBoxes();
                    mainWindow.MainUpdateForm();
                }
                else
                {
                    MessageBox.Show("Данные о новой АЗС не были добавлены!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить строку города", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            if(cityBox.Text != "")
            {
                streetBox.Enabled = true;
            }
            else
            {
                streetBox.Enabled = false;
            }
        }

        private void streetBox_TextChanged(object sender, EventArgs e)
        {
            if(streetBox.Text != "")
            {
                houseBox.Enabled = true;
            }
            else
            {
                houseBox.Enabled = false;
            }
        }

        private void houseBox_TextChanged(object sender, EventArgs e)
        {
            if(houseBox.Text != "")
            {
                housingBox.Enabled = true;
            }
            else
            {
                housingBox.Enabled = false;
            }
        }
    }
}
