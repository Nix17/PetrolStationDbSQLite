namespace PetrolStationDB.Views.Profile
{
    partial class ProfileWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createdByBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createdDateBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updatedByBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updatedDateBox = new System.Windows.Forms.TextBox();
            this.anotherUsersBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // loginBox
            // 
            this.loginBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBox.Location = new System.Drawing.Point(178, 13);
            this.loginBox.Name = "loginBox";
            this.loginBox.ReadOnly = true;
            this.loginBox.Size = new System.Drawing.Size(397, 34);
            this.loginBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль";
            // 
            // passBox
            // 
            this.passBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(178, 64);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(397, 34);
            this.passBox.TabIndex = 2;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Статус";
            // 
            // roleBox
            // 
            this.roleBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roleBox.Location = new System.Drawing.Point(179, 122);
            this.roleBox.Name = "roleBox";
            this.roleBox.ReadOnly = true;
            this.roleBox.Size = new System.Drawing.Size(396, 34);
            this.roleBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Кем создан";
            // 
            // createdByBox
            // 
            this.createdByBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createdByBox.Location = new System.Drawing.Point(179, 176);
            this.createdByBox.Name = "createdByBox";
            this.createdByBox.ReadOnly = true;
            this.createdByBox.Size = new System.Drawing.Size(396, 34);
            this.createdByBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Когда создан";
            // 
            // createdDateBox
            // 
            this.createdDateBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createdDateBox.Location = new System.Drawing.Point(179, 232);
            this.createdDateBox.Name = "createdDateBox";
            this.createdDateBox.ReadOnly = true;
            this.createdDateBox.Size = new System.Drawing.Size(396, 34);
            this.createdDateBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Кем обновлён";
            // 
            // updatedByBox
            // 
            this.updatedByBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatedByBox.Location = new System.Drawing.Point(179, 288);
            this.updatedByBox.Name = "updatedByBox";
            this.updatedByBox.ReadOnly = true;
            this.updatedByBox.Size = new System.Drawing.Size(396, 34);
            this.updatedByBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Когда обновлён";
            // 
            // updatedDateBox
            // 
            this.updatedDateBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatedDateBox.Location = new System.Drawing.Point(179, 345);
            this.updatedDateBox.Name = "updatedDateBox";
            this.updatedDateBox.ReadOnly = true;
            this.updatedDateBox.Size = new System.Drawing.Size(396, 34);
            this.updatedDateBox.TabIndex = 4;
            // 
            // anotherUsersBtn
            // 
            this.anotherUsersBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anotherUsersBtn.Location = new System.Drawing.Point(14, 409);
            this.anotherUsersBtn.Name = "anotherUsersBtn";
            this.anotherUsersBtn.Size = new System.Drawing.Size(269, 61);
            this.anotherUsersBtn.TabIndex = 1;
            this.anotherUsersBtn.Text = "Другие пользователи";
            this.anotherUsersBtn.UseVisualStyleBackColor = true;
            this.anotherUsersBtn.Click += new System.EventHandler(this.anotherUsersBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(302, 409);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(273, 61);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ProfileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 499);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.anotherUsersBtn);
            this.Controls.Add(this.updatedDateBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updatedByBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createdDateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.createdByBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfileWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox loginBox;
        private Label label2;
        private TextBox passBox;
        private Label label3;
        private TextBox roleBox;
        private Label label4;
        private TextBox createdByBox;
        private Label label5;
        private TextBox createdDateBox;
        private Label label6;
        private TextBox updatedByBox;
        private Label label7;
        private TextBox updatedDateBox;
        private Button anotherUsersBtn;
        private Button saveBtn;
    }
}