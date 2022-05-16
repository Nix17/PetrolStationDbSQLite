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

namespace PetrolStationDB.Views.Profile
{
    public partial class ProfileWindow : Form
    {
        User mUser = null;
        ProfileController profileCtrl;

        public ProfileWindow(User _user)
        {
            mUser = _user;
            profileCtrl = new ProfileController();

            
            
            InitializeComponent();
        }

        private void anotherUsersBtn_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<User> users = profileCtrl.ViewAllUsers();

            int idx = 0;
            foreach (var user in users)
            {
                idx++;
                stringBuilder.Append((idx).ToString() + ". Логин: " + user.Login + ", статус: " + user.Role + ", создан: " + user.CreatedDate.ToString() + "\n");
            }
            MessageBox.Show(stringBuilder.ToString(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void ReloadData(User _user)
        {
            if (_user != null)
            {
                loginBox.Text = mUser.Login.ToString();
                passBox.Text = mUser.Password.ToString();
                roleBox.Text = mUser.Role.ToString();
                createdByBox.Text = mUser.CreatedBy.ToString();
                createdDateBox.Text = mUser.CreatedDate.ToString();
                updatedByBox.Text = mUser.UpdatedBy.ToString();
                updatedDateBox.Text = mUser.UpdatedDate.ToString();

                saveBtn.Enabled = false;
            }
        }

        private void ProfileWindow_Load(object sender, EventArgs e)
        {
            ReloadData(mUser);
            switch (mUser.Role)
            {
                case "admin":
                    anotherUsersBtn.Visible = false;
                    break;

                case "user":
                    anotherUsersBtn.Visible = false;
                    break;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool result = profileCtrl.ChangePassword(ref mUser, passBox.Text);
            if (result)
            {
                ReloadData(mUser);
                MessageBox.Show("Пароль успешно изменён!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка! Пароль не был изменён!", "Ошибка!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            saveBtn.Enabled = true;
        }
    }
}
