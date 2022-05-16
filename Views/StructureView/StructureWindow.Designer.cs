namespace PetrolStationDB.Views.StructureView
{
    partial class StructureWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearFiltersBtn = new System.Windows.Forms.Button();
            this.squareSearchBox = new System.Windows.Forms.TextBox();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.commonSearchBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataStructureGV = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petrolStatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countEquipmentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addStructureBtn = new System.Windows.Forms.Button();
            this.petrolStatCmbBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStructureGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.clearFiltersBtn);
            this.groupBox1.Controls.Add(this.squareSearchBox);
            this.groupBox1.Controls.Add(this.nameSearchBox);
            this.groupBox1.Controls.Add(this.commonSearchBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // clearFiltersBtn
            // 
            this.clearFiltersBtn.ForeColor = System.Drawing.Color.Tomato;
            this.clearFiltersBtn.Location = new System.Drawing.Point(871, 67);
            this.clearFiltersBtn.Name = "clearFiltersBtn";
            this.clearFiltersBtn.Size = new System.Drawing.Size(208, 37);
            this.clearFiltersBtn.TabIndex = 1;
            this.clearFiltersBtn.Text = "Очистить";
            this.clearFiltersBtn.UseVisualStyleBackColor = true;
            this.clearFiltersBtn.Click += new System.EventHandler(this.clearFiltersBtn_Click);
            // 
            // squareSearchBox
            // 
            this.squareSearchBox.Location = new System.Drawing.Point(437, 70);
            this.squareSearchBox.Name = "squareSearchBox";
            this.squareSearchBox.PlaceholderText = "Поиск по площади(цифры)...";
            this.squareSearchBox.Size = new System.Drawing.Size(428, 34);
            this.squareSearchBox.TabIndex = 4;
            this.squareSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.squareSearchBox.TextChanged += new System.EventHandler(this.squareSearchBox_TextChanged);
            this.squareSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.squareSearchBox_KeyPress);
            // 
            // nameSearchBox
            // 
            this.nameSearchBox.Location = new System.Drawing.Point(3, 70);
            this.nameSearchBox.Name = "nameSearchBox";
            this.nameSearchBox.PlaceholderText = "Поиск по названию...";
            this.nameSearchBox.Size = new System.Drawing.Size(428, 34);
            this.nameSearchBox.TabIndex = 3;
            this.nameSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameSearchBox.TextChanged += new System.EventHandler(this.nameSearchBox_TextChanged);
            // 
            // commonSearchBox
            // 
            this.commonSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonSearchBox.Location = new System.Drawing.Point(3, 30);
            this.commonSearchBox.Name = "commonSearchBox";
            this.commonSearchBox.PlaceholderText = "Общий поиск...";
            this.commonSearchBox.Size = new System.Drawing.Size(1076, 34);
            this.commonSearchBox.TabIndex = 2;
            this.commonSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.commonSearchBox.TextChanged += new System.EventHandler(this.commonSearchBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.dataStructureGV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список";
            // 
            // dataStructureGV
            // 
            this.dataStructureGV.AllowUserToAddRows = false;
            this.dataStructureGV.AllowUserToDeleteRows = false;
            this.dataStructureGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStructureGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.numCol,
            this.nameCol,
            this.squareCol,
            this.petrolStatCol,
            this.countEquipmentCol,
            this.createdByCol,
            this.createdDateCol,
            this.updatedByCol,
            this.updatedDateCol,
            this.changeBtnCol,
            this.deleteBtnCol});
            this.dataStructureGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStructureGV.Location = new System.Drawing.Point(3, 30);
            this.dataStructureGV.Name = "dataStructureGV";
            this.dataStructureGV.RowHeadersWidth = 51;
            this.dataStructureGV.RowTemplate.Height = 29;
            this.dataStructureGV.Size = new System.Drawing.Size(1076, 306);
            this.dataStructureGV.TabIndex = 0;
            this.dataStructureGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStructureGV_CellContentClick);
            // 
            // idCol
            // 
            this.idCol.HeaderText = "GUID";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 125;
            // 
            // numCol
            // 
            this.numCol.HeaderText = "#";
            this.numCol.MinimumWidth = 6;
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            this.numCol.Width = 125;
            // 
            // nameCol
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.nameCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.nameCol.HeaderText = "Название";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.Width = 250;
            // 
            // squareCol
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.squareCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.squareCol.HeaderText = "Площадь (м2)";
            this.squareCol.MinimumWidth = 6;
            this.squareCol.Name = "squareCol";
            this.squareCol.Width = 125;
            // 
            // petrolStatCol
            // 
            this.petrolStatCol.HeaderText = "АЗС";
            this.petrolStatCol.MinimumWidth = 6;
            this.petrolStatCol.Name = "petrolStatCol";
            this.petrolStatCol.ReadOnly = true;
            this.petrolStatCol.Width = 300;
            // 
            // countEquipmentCol
            // 
            this.countEquipmentCol.HeaderText = "Кол-во оборудования";
            this.countEquipmentCol.MinimumWidth = 6;
            this.countEquipmentCol.Name = "countEquipmentCol";
            this.countEquipmentCol.ReadOnly = true;
            this.countEquipmentCol.Width = 170;
            // 
            // createdByCol
            // 
            this.createdByCol.HeaderText = "Кем создан";
            this.createdByCol.MinimumWidth = 6;
            this.createdByCol.Name = "createdByCol";
            this.createdByCol.ReadOnly = true;
            this.createdByCol.Width = 125;
            // 
            // createdDateCol
            // 
            this.createdDateCol.HeaderText = "Создан";
            this.createdDateCol.MinimumWidth = 6;
            this.createdDateCol.Name = "createdDateCol";
            this.createdDateCol.ReadOnly = true;
            this.createdDateCol.Width = 125;
            // 
            // updatedByCol
            // 
            this.updatedByCol.HeaderText = "Кем обновлён";
            this.updatedByCol.MinimumWidth = 6;
            this.updatedByCol.Name = "updatedByCol";
            this.updatedByCol.ReadOnly = true;
            this.updatedByCol.Width = 125;
            // 
            // updatedDateCol
            // 
            this.updatedDateCol.HeaderText = "Обновлён";
            this.updatedDateCol.MinimumWidth = 6;
            this.updatedDateCol.Name = "updatedDateCol";
            this.updatedDateCol.ReadOnly = true;
            this.updatedDateCol.Width = 125;
            // 
            // changeBtnCol
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOrange;
            this.changeBtnCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.changeBtnCol.HeaderText = "Изменить";
            this.changeBtnCol.MinimumWidth = 6;
            this.changeBtnCol.Name = "changeBtnCol";
            this.changeBtnCol.Width = 125;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.deleteBtnCol.HeaderText = "Удалить";
            this.deleteBtnCol.MinimumWidth = 6;
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.addStructureBtn);
            this.groupBox3.Controls.Add(this.petrolStatCmbBox);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 458);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1082, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить сооружение";
            // 
            // addStructureBtn
            // 
            this.addStructureBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addStructureBtn.ForeColor = System.Drawing.Color.Green;
            this.addStructureBtn.Location = new System.Drawing.Point(649, 87);
            this.addStructureBtn.Name = "addStructureBtn";
            this.addStructureBtn.Size = new System.Drawing.Size(427, 34);
            this.addStructureBtn.TabIndex = 8;
            this.addStructureBtn.Text = "Добавить";
            this.addStructureBtn.UseVisualStyleBackColor = true;
            this.addStructureBtn.Click += new System.EventHandler(this.addStructureBtn_Click);
            // 
            // petrolStatCmbBox
            // 
            this.petrolStatCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petrolStatCmbBox.FormattingEnabled = true;
            this.petrolStatCmbBox.Location = new System.Drawing.Point(649, 39);
            this.petrolStatCmbBox.Name = "petrolStatCmbBox";
            this.petrolStatCmbBox.Size = new System.Drawing.Size(427, 35);
            this.petrolStatCmbBox.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(420, 34);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 34);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "АЗС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Площадь*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название*";
            // 
            // StructureWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 597);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StructureWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сооружения";
            this.Load += new System.EventHandler(this.StructureWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStructureGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox commonSearchBox;
        private Button clearFiltersBtn;
        private TextBox squareSearchBox;
        private TextBox nameSearchBox;
        private GroupBox groupBox2;
        private DataGridView dataStructureGV;
        private GroupBox groupBox3;
        private Button addStructureBtn;
        private ComboBox petrolStatCmbBox;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn numCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn squareCol;
        private DataGridViewTextBoxColumn petrolStatCol;
        private DataGridViewTextBoxColumn countEquipmentCol;
        private DataGridViewTextBoxColumn createdByCol;
        private DataGridViewTextBoxColumn createdDateCol;
        private DataGridViewTextBoxColumn updatedByCol;
        private DataGridViewTextBoxColumn updatedDateCol;
        private DataGridViewButtonColumn changeBtnCol;
        private DataGridViewButtonColumn deleteBtnCol;
    }
}