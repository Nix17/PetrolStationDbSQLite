using PetrolStationDB.Database;
using PetrolStationDB.Database.Models;
using PetrolStationDB.Controllers;
using PetrolStationDB.Views;

namespace PetrolStationDB
{
    public partial class authForm : Form
    {
        AuthorizationController authCtrl;
        public authForm()
        {
            authCtrl = new AuthorizationController();
            InitializeComponent();
        }
        Point lastPoint;

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Sienna;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.SeaGreen;
        }

        #region Перемещение окна
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != "")
            {
                if(passBox.Text != "")
                {
                    User myUser = authCtrl.AuthToApp(loginBox.Text, passBox.Text);
                    if (myUser != null)
                    {
                        myUser.Password = passBox.Text;
                        this.Hide();
                        MainWindow mainWindow = new MainWindow(myUser, this);
                        mainWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка!! Неверные данные!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Пароль не может быть пустым!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Логин не может быть пустым!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void authForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}