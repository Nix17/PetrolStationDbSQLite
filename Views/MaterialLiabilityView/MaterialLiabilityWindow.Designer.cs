namespace PetrolStationDB.Views.MaterialLiabilityView
{
    partial class MaterialLiabilityWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataMatLiabGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addNewMatLiabBtn = new System.Windows.Forms.Button();
            this.chooseEquipmentCmbBox = new System.Windows.Forms.ComboBox();
            this.chooseEmployeeCmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMatLiabGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.dataMatLiabGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список";
            // 
            // dataMatLiabGV
            // 
            this.dataMatLiabGV.AllowUserToAddRows = false;
            this.dataMatLiabGV.AllowUserToDeleteRows = false;
            this.dataMatLiabGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMatLiabGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guidCol,
            this.numCol,
            this.employeeCol,
            this.equipmentCol,
            this.structureCol,
            this.createdByCol,
            this.createdDateCol,
            this.updatedByCol,
            this.updatedDateCol,
            this.deleteBtnCol});
            this.dataMatLiabGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMatLiabGV.Location = new System.Drawing.Point(3, 30);
            this.dataMatLiabGV.Name = "dataMatLiabGV";
            this.dataMatLiabGV.RowHeadersWidth = 51;
            this.dataMatLiabGV.RowTemplate.Height = 29;
            this.dataMatLiabGV.Size = new System.Drawing.Size(1090, 344);
            this.dataMatLiabGV.TabIndex = 0;
            this.dataMatLiabGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMatLiabGV_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.addNewMatLiabBtn);
            this.groupBox2.Controls.Add(this.chooseEquipmentCmbBox);
            this.groupBox2.Controls.Add(this.chooseEmployeeCmbBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1096, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить";
            // 
            // addNewMatLiabBtn
            // 
            this.addNewMatLiabBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.addNewMatLiabBtn.Location = new System.Drawing.Point(807, 136);
            this.addNewMatLiabBtn.Name = "addNewMatLiabBtn";
            this.addNewMatLiabBtn.Size = new System.Drawing.Size(283, 35);
            this.addNewMatLiabBtn.TabIndex = 4;
            this.addNewMatLiabBtn.Text = "Добавить";
            this.addNewMatLiabBtn.UseVisualStyleBackColor = true;
            this.addNewMatLiabBtn.Click += new System.EventHandler(this.addNewMatLiabBtn_Click);
            // 
            // chooseEquipmentCmbBox
            // 
            this.chooseEquipmentCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseEquipmentCmbBox.FormattingEnabled = true;
            this.chooseEquipmentCmbBox.Location = new System.Drawing.Point(550, 82);
            this.chooseEquipmentCmbBox.Name = "chooseEquipmentCmbBox";
            this.chooseEquipmentCmbBox.Size = new System.Drawing.Size(540, 35);
            this.chooseEquipmentCmbBox.TabIndex = 3;
            // 
            // chooseEmployeeCmbBox
            // 
            this.chooseEmployeeCmbBox.FormattingEnabled = true;
            this.chooseEmployeeCmbBox.Location = new System.Drawing.Point(12, 82);
            this.chooseEmployeeCmbBox.Name = "chooseEmployeeCmbBox";
            this.chooseEmployeeCmbBox.Size = new System.Drawing.Size(511, 35);
            this.chooseEmployeeCmbBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(550, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выбрать оборудование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбрать сотрудника";
            // 
            // guidCol
            // 
            this.guidCol.HeaderText = "GUID";
            this.guidCol.MinimumWidth = 6;
            this.guidCol.Name = "guidCol";
            this.guidCol.ReadOnly = true;
            this.guidCol.Visible = false;
            this.guidCol.Width = 125;
            // 
            // numCol
            // 
            this.numCol.HeaderText = "#";
            this.numCol.MinimumWidth = 6;
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            this.numCol.Width = 70;
            // 
            // employeeCol
            // 
            this.employeeCol.HeaderText = "Сотрудник";
            this.employeeCol.MinimumWidth = 6;
            this.employeeCol.Name = "employeeCol";
            this.employeeCol.ReadOnly = true;
            this.employeeCol.Width = 200;
            // 
            // equipmentCol
            // 
            this.equipmentCol.HeaderText = "Оборудование";
            this.equipmentCol.MinimumWidth = 6;
            this.equipmentCol.Name = "equipmentCol";
            this.equipmentCol.ReadOnly = true;
            this.equipmentCol.Width = 250;
            // 
            // structureCol
            // 
            this.structureCol.HeaderText = "Структура";
            this.structureCol.MinimumWidth = 6;
            this.structureCol.Name = "structureCol";
            this.structureCol.ReadOnly = true;
            this.structureCol.Width = 250;
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
            this.createdDateCol.HeaderText = "Создано";
            this.createdDateCol.MinimumWidth = 6;
            this.createdDateCol.Name = "createdDateCol";
            this.createdDateCol.ReadOnly = true;
            this.createdDateCol.Width = 125;
            // 
            // updatedByCol
            // 
            this.updatedByCol.HeaderText = "Кем обновлено";
            this.updatedByCol.MinimumWidth = 6;
            this.updatedByCol.Name = "updatedByCol";
            this.updatedByCol.ReadOnly = true;
            this.updatedByCol.Width = 125;
            // 
            // updatedDateCol
            // 
            this.updatedDateCol.HeaderText = "Обновлено";
            this.updatedDateCol.MinimumWidth = 6;
            this.updatedDateCol.Name = "updatedDateCol";
            this.updatedDateCol.ReadOnly = true;
            this.updatedDateCol.Width = 125;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.deleteBtnCol.HeaderText = "Удалить";
            this.deleteBtnCol.MinimumWidth = 6;
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.ReadOnly = true;
            this.deleteBtnCol.Width = 125;
            // 
            // MaterialLiabilityWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MaterialLiabilityWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материальная ответственность";
            this.Load += new System.EventHandler(this.MaterialLiabilityWindow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMatLiabGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataMatLiabGV;
        private GroupBox groupBox2;
        private Button addNewMatLiabBtn;
        private ComboBox chooseEquipmentCmbBox;
        private ComboBox chooseEmployeeCmbBox;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn guidCol;
        private DataGridViewTextBoxColumn numCol;
        private DataGridViewTextBoxColumn employeeCol;
        private DataGridViewTextBoxColumn equipmentCol;
        private DataGridViewTextBoxColumn structureCol;
        private DataGridViewTextBoxColumn createdByCol;
        private DataGridViewTextBoxColumn createdDateCol;
        private DataGridViewTextBoxColumn updatedByCol;
        private DataGridViewTextBoxColumn updatedDateCol;
        private DataGridViewButtonColumn deleteBtnCol;
    }
}