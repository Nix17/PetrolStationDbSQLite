namespace PetrolStationDB.Views.PetrolStationView
{
    partial class PetrolStationWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.housingBox = new System.Windows.Forms.TextBox();
            this.houseBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.typesCmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numStationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addPetrolStation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.typesCmbBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numStationBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.commentBox);
            this.groupBox2.Controls.Add(this.housingBox);
            this.groupBox2.Controls.Add(this.houseBox);
            this.groupBox2.Controls.Add(this.streetBox);
            this.groupBox2.Controls.Add(this.cityBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 181);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Месторасположение";
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(15, 132);
            this.commentBox.Name = "commentBox";
            this.commentBox.PlaceholderText = "Примечание...";
            this.commentBox.Size = new System.Drawing.Size(617, 34);
            this.commentBox.TabIndex = 2;
            // 
            // housingBox
            // 
            this.housingBox.Enabled = false;
            this.housingBox.Location = new System.Drawing.Point(330, 83);
            this.housingBox.Name = "housingBox";
            this.housingBox.PlaceholderText = "Корпус...";
            this.housingBox.Size = new System.Drawing.Size(302, 34);
            this.housingBox.TabIndex = 2;
            // 
            // houseBox
            // 
            this.houseBox.Enabled = false;
            this.houseBox.Location = new System.Drawing.Point(15, 83);
            this.houseBox.Name = "houseBox";
            this.houseBox.PlaceholderText = "Дом...";
            this.houseBox.Size = new System.Drawing.Size(302, 34);
            this.houseBox.TabIndex = 2;
            this.houseBox.TextChanged += new System.EventHandler(this.houseBox_TextChanged);
            // 
            // streetBox
            // 
            this.streetBox.Enabled = false;
            this.streetBox.Location = new System.Drawing.Point(330, 34);
            this.streetBox.Name = "streetBox";
            this.streetBox.PlaceholderText = "Улица...";
            this.streetBox.Size = new System.Drawing.Size(302, 34);
            this.streetBox.TabIndex = 1;
            this.streetBox.TextChanged += new System.EventHandler(this.streetBox_TextChanged);
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(15, 34);
            this.cityBox.Name = "cityBox";
            this.cityBox.PlaceholderText = "Город*...";
            this.cityBox.Size = new System.Drawing.Size(302, 34);
            this.cityBox.TabIndex = 0;
            this.cityBox.TextChanged += new System.EventHandler(this.cityBox_TextChanged);
            // 
            // typesCmbBox
            // 
            this.typesCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesCmbBox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typesCmbBox.Location = new System.Drawing.Point(437, 38);
            this.typesCmbBox.Name = "typesCmbBox";
            this.typesCmbBox.Size = new System.Drawing.Size(226, 29);
            this.typesCmbBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип АЗС*";
            // 
            // numStationBox
            // 
            this.numStationBox.Enabled = false;
            this.numStationBox.Location = new System.Drawing.Point(138, 37);
            this.numStationBox.Name = "numStationBox";
            this.numStationBox.ReadOnly = true;
            this.numStationBox.Size = new System.Drawing.Size(163, 34);
            this.numStationBox.TabIndex = 2;
            this.numStationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер АЗС";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox3.Controls.Add(this.addPetrolStation);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 80);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Опции";
            // 
            // addPetrolStation
            // 
            this.addPetrolStation.Location = new System.Drawing.Point(330, 22);
            this.addPetrolStation.Name = "addPetrolStation";
            this.addPetrolStation.Size = new System.Drawing.Size(333, 46);
            this.addPetrolStation.TabIndex = 1;
            this.addPetrolStation.Text = "Добавить АЗС";
            this.addPetrolStation.UseVisualStyleBackColor = true;
            this.addPetrolStation.Click += new System.EventHandler(this.addPetrolStation_Click);
            // 
            // PetrolStationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 372);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PetrolStationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить АЗС";
            this.Load += new System.EventHandler(this.PetrolStationWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox commentBox;
        private TextBox housingBox;
        private TextBox houseBox;
        private TextBox streetBox;
        private TextBox cityBox;
        private ComboBox typesCmbBox;
        private Label label2;
        private TextBox numStationBox;
        private Label label1;
        private GroupBox groupBox3;
        private Button addPetrolStation;
    }
}