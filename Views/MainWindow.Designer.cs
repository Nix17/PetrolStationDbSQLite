namespace PetrolStationDB.Views
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.materialLiabilityBtn = new System.Windows.Forms.Button();
            this.equipmentsBtn = new System.Windows.Forms.Button();
            this.structuresBtn = new System.Windows.Forms.Button();
            this.EmployeesBtn = new System.Windows.Forms.Button();
            this.addPsBtn = new System.Windows.Forms.Button();
            this.typePsBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backupDbBtn = new System.Windows.Forms.Button();
            this.exportToWordBtn = new System.Windows.Forms.Button();
            this.commonMaxPriceEqPsBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataPsGV = new System.Windows.Forms.DataGridView();
            this.guidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numStatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePetrolStationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listEquipmentCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.createdByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainClearBtn = new System.Windows.Forms.Button();
            this.mainLocationPStatSearchBox = new System.Windows.Forms.TextBox();
            this.mainNumPStatSearchBox = new System.Windows.Forms.TextBox();
            this.mainCommonSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPsGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.splitContainer1.Panel1.Controls.Add(this.materialLiabilityBtn);
            this.splitContainer1.Panel1.Controls.Add(this.equipmentsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.structuresBtn);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeesBtn);
            this.splitContainer1.Panel1.Controls.Add(this.addPsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.typePsBtn);
            this.splitContainer1.Panel1.Controls.Add(this.profileBtn);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 739);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 0;
            // 
            // materialLiabilityBtn
            // 
            this.materialLiabilityBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLiabilityBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLiabilityBtn.Location = new System.Drawing.Point(5, 400);
            this.materialLiabilityBtn.Name = "materialLiabilityBtn";
            this.materialLiabilityBtn.Size = new System.Drawing.Size(242, 65);
            this.materialLiabilityBtn.TabIndex = 6;
            this.materialLiabilityBtn.Text = "Материальная\r\nответвтвенность";
            this.materialLiabilityBtn.UseVisualStyleBackColor = true;
            this.materialLiabilityBtn.Click += new System.EventHandler(this.materialLiabilityBtn_Click);
            // 
            // equipmentsBtn
            // 
            this.equipmentsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.equipmentsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equipmentsBtn.Location = new System.Drawing.Point(5, 335);
            this.equipmentsBtn.Name = "equipmentsBtn";
            this.equipmentsBtn.Size = new System.Drawing.Size(242, 65);
            this.equipmentsBtn.TabIndex = 5;
            this.equipmentsBtn.Text = "Оборудование";
            this.equipmentsBtn.UseVisualStyleBackColor = true;
            this.equipmentsBtn.Click += new System.EventHandler(this.equipmentsBtn_Click);
            // 
            // structuresBtn
            // 
            this.structuresBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.structuresBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.structuresBtn.Location = new System.Drawing.Point(5, 270);
            this.structuresBtn.Name = "structuresBtn";
            this.structuresBtn.Size = new System.Drawing.Size(242, 65);
            this.structuresBtn.TabIndex = 4;
            this.structuresBtn.Text = "Сооружения";
            this.structuresBtn.UseVisualStyleBackColor = true;
            this.structuresBtn.Click += new System.EventHandler(this.structuresBtn_Click);
            // 
            // EmployeesBtn
            // 
            this.EmployeesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmployeesBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeesBtn.Location = new System.Drawing.Point(5, 205);
            this.EmployeesBtn.Name = "EmployeesBtn";
            this.EmployeesBtn.Size = new System.Drawing.Size(242, 65);
            this.EmployeesBtn.TabIndex = 3;
            this.EmployeesBtn.Text = "Сотрудники";
            this.EmployeesBtn.UseVisualStyleBackColor = true;
            this.EmployeesBtn.Click += new System.EventHandler(this.EmployeesBtn_Click);
            // 
            // addPsBtn
            // 
            this.addPsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPsBtn.Location = new System.Drawing.Point(5, 140);
            this.addPsBtn.Name = "addPsBtn";
            this.addPsBtn.Size = new System.Drawing.Size(242, 65);
            this.addPsBtn.TabIndex = 2;
            this.addPsBtn.Text = "Добавить АЗС";
            this.addPsBtn.UseVisualStyleBackColor = true;
            this.addPsBtn.Click += new System.EventHandler(this.addPsBtn_Click);
            // 
            // typePsBtn
            // 
            this.typePsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.typePsBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typePsBtn.Location = new System.Drawing.Point(5, 75);
            this.typePsBtn.Name = "typePsBtn";
            this.typePsBtn.Size = new System.Drawing.Size(242, 65);
            this.typePsBtn.TabIndex = 1;
            this.typePsBtn.Text = "Тип АЗС";
            this.typePsBtn.UseVisualStyleBackColor = true;
            this.typePsBtn.Click += new System.EventHandler(this.typePsBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileBtn.Location = new System.Drawing.Point(5, 10);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(242, 65);
            this.profileBtn.TabIndex = 0;
            this.profileBtn.Text = "ПРОФИЛЬ";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.OldLace;
            this.groupBox3.Controls.Add(this.backupDbBtn);
            this.groupBox3.Controls.Add(this.exportToWordBtn);
            this.groupBox3.Controls.Add(this.commonMaxPriceEqPsBtn);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 620);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1126, 119);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Опции";
            // 
            // backupDbBtn
            // 
            this.backupDbBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.backupDbBtn.Location = new System.Drawing.Point(602, 33);
            this.backupDbBtn.Name = "backupDbBtn";
            this.backupDbBtn.Size = new System.Drawing.Size(512, 74);
            this.backupDbBtn.TabIndex = 2;
            this.backupDbBtn.Text = "Резервное копирование Базы данных";
            this.backupDbBtn.UseVisualStyleBackColor = true;
            this.backupDbBtn.Click += new System.EventHandler(this.backupDbBtn_Click);
            // 
            // exportToWordBtn
            // 
            this.exportToWordBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.exportToWordBtn.Location = new System.Drawing.Point(416, 33);
            this.exportToWordBtn.Name = "exportToWordBtn";
            this.exportToWordBtn.Size = new System.Drawing.Size(180, 74);
            this.exportToWordBtn.TabIndex = 1;
            this.exportToWordBtn.Text = "Экспорт в MSWord";
            this.exportToWordBtn.UseVisualStyleBackColor = true;
            this.exportToWordBtn.Click += new System.EventHandler(this.exportToWordBtn_Click);
            // 
            // commonMaxPriceEqPsBtn
            // 
            this.commonMaxPriceEqPsBtn.ForeColor = System.Drawing.Color.Olive;
            this.commonMaxPriceEqPsBtn.Location = new System.Drawing.Point(6, 33);
            this.commonMaxPriceEqPsBtn.Name = "commonMaxPriceEqPsBtn";
            this.commonMaxPriceEqPsBtn.Size = new System.Drawing.Size(404, 74);
            this.commonMaxPriceEqPsBtn.TabIndex = 0;
            this.commonMaxPriceEqPsBtn.Text = "АЗС с максимальной общей стоимостью обородования";
            this.commonMaxPriceEqPsBtn.UseVisualStyleBackColor = true;
            this.commonMaxPriceEqPsBtn.Click += new System.EventHandler(this.commonMaxPriceEqPsBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.dataPsGV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 503);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблица АЗС";
            // 
            // dataPsGV
            // 
            this.dataPsGV.AllowUserToAddRows = false;
            this.dataPsGV.AllowUserToDeleteRows = false;
            this.dataPsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guidCol,
            this.numStatCol,
            this.locationCol,
            this.typePetrolStationCol,
            this.listEquipmentCol,
            this.createdByCol,
            this.createdDateCol,
            this.updatedByCol,
            this.updatedDateCol,
            this.deleteBtnCol});
            this.dataPsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPsGV.Location = new System.Drawing.Point(3, 30);
            this.dataPsGV.Name = "dataPsGV";
            this.dataPsGV.RowHeadersWidth = 51;
            this.dataPsGV.RowTemplate.Height = 29;
            this.dataPsGV.Size = new System.Drawing.Size(1120, 470);
            this.dataPsGV.TabIndex = 0;
            this.dataPsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPsGV_CellContentClick);
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
            // numStatCol
            // 
            this.numStatCol.HeaderText = "Номер АЗС";
            this.numStatCol.MinimumWidth = 6;
            this.numStatCol.Name = "numStatCol";
            this.numStatCol.ReadOnly = true;
            this.numStatCol.Width = 125;
            // 
            // locationCol
            // 
            this.locationCol.HeaderText = "Локация";
            this.locationCol.MinimumWidth = 6;
            this.locationCol.Name = "locationCol";
            this.locationCol.ReadOnly = true;
            this.locationCol.Width = 200;
            // 
            // typePetrolStationCol
            // 
            this.typePetrolStationCol.HeaderText = "Тип АЗС";
            this.typePetrolStationCol.MinimumWidth = 6;
            this.typePetrolStationCol.Name = "typePetrolStationCol";
            this.typePetrolStationCol.ReadOnly = true;
            this.typePetrolStationCol.Width = 200;
            // 
            // listEquipmentCol
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listEquipmentCol.DefaultCellStyle = dataGridViewCellStyle7;
            this.listEquipmentCol.HeaderText = "Список оборудования";
            this.listEquipmentCol.MinimumWidth = 6;
            this.listEquipmentCol.Name = "listEquipmentCol";
            this.listEquipmentCol.Width = 200;
            // 
            // createdByCol
            // 
            this.createdByCol.HeaderText = "Кем создано";
            this.createdByCol.MinimumWidth = 6;
            this.createdByCol.Name = "createdByCol";
            this.createdByCol.ReadOnly = true;
            this.createdByCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.createdByCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.createdByCol.Width = 125;
            // 
            // createdDateCol
            // 
            this.createdDateCol.HeaderText = "Создан";
            this.createdDateCol.MinimumWidth = 6;
            this.createdDateCol.Name = "createdDateCol";
            this.createdDateCol.ReadOnly = true;
            this.createdDateCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.createdDateCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.createdDateCol.Width = 170;
            // 
            // updatedByCol
            // 
            this.updatedByCol.HeaderText = "Кем обновлён";
            this.updatedByCol.MinimumWidth = 6;
            this.updatedByCol.Name = "updatedByCol";
            this.updatedByCol.ReadOnly = true;
            this.updatedByCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.updatedByCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.updatedByCol.Width = 125;
            // 
            // updatedDateCol
            // 
            this.updatedDateCol.HeaderText = "Обновлён";
            this.updatedDateCol.MinimumWidth = 6;
            this.updatedDateCol.Name = "updatedDateCol";
            this.updatedDateCol.ReadOnly = true;
            this.updatedDateCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.updatedDateCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.updatedDateCol.Width = 170;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle8;
            this.deleteBtnCol.HeaderText = "Удалить";
            this.deleteBtnCol.MinimumWidth = 6;
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.ReadOnly = true;
            this.deleteBtnCol.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.mainClearBtn);
            this.groupBox1.Controls.Add(this.mainLocationPStatSearchBox);
            this.groupBox1.Controls.Add(this.mainNumPStatSearchBox);
            this.groupBox1.Controls.Add(this.mainCommonSearchBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по АЗС";
            // 
            // mainClearBtn
            // 
            this.mainClearBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainClearBtn.ForeColor = System.Drawing.Color.Red;
            this.mainClearBtn.Location = new System.Drawing.Point(887, 69);
            this.mainClearBtn.Name = "mainClearBtn";
            this.mainClearBtn.Size = new System.Drawing.Size(236, 36);
            this.mainClearBtn.TabIndex = 2;
            this.mainClearBtn.Text = "Очистить";
            this.mainClearBtn.UseVisualStyleBackColor = true;
            this.mainClearBtn.Click += new System.EventHandler(this.mainClearBtn_Click);
            // 
            // mainLocationPStatSearchBox
            // 
            this.mainLocationPStatSearchBox.Location = new System.Drawing.Point(445, 70);
            this.mainLocationPStatSearchBox.Name = "mainLocationPStatSearchBox";
            this.mainLocationPStatSearchBox.PlaceholderText = "Поиск по локации...";
            this.mainLocationPStatSearchBox.Size = new System.Drawing.Size(436, 34);
            this.mainLocationPStatSearchBox.TabIndex = 1;
            this.mainLocationPStatSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainLocationPStatSearchBox.TextChanged += new System.EventHandler(this.mainLocationPStatSearchBox_TextChanged);
            // 
            // mainNumPStatSearchBox
            // 
            this.mainNumPStatSearchBox.Location = new System.Drawing.Point(3, 70);
            this.mainNumPStatSearchBox.Name = "mainNumPStatSearchBox";
            this.mainNumPStatSearchBox.PlaceholderText = "Поиск по номеру АЗС...";
            this.mainNumPStatSearchBox.Size = new System.Drawing.Size(436, 34);
            this.mainNumPStatSearchBox.TabIndex = 1;
            this.mainNumPStatSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainNumPStatSearchBox.TextChanged += new System.EventHandler(this.mainNumPStatSearchBox_TextChanged);
            // 
            // mainCommonSearchBox
            // 
            this.mainCommonSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainCommonSearchBox.Location = new System.Drawing.Point(3, 30);
            this.mainCommonSearchBox.Name = "mainCommonSearchBox";
            this.mainCommonSearchBox.PlaceholderText = "Общий поиск...";
            this.mainCommonSearchBox.Size = new System.Drawing.Size(1120, 34);
            this.mainCommonSearchBox.TabIndex = 0;
            this.mainCommonSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainCommonSearchBox.TextChanged += new System.EventHandler(this.mainCommonSearchBox_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 739);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPsGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button profileBtn;
        private Button typePsBtn;
        private Button materialLiabilityBtn;
        private Button equipmentsBtn;
        private Button structuresBtn;
        private Button EmployeesBtn;
        private Button addPsBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox mainCommonSearchBox;
        private DataGridView dataPsGV;
        private Button mainClearBtn;
        private TextBox mainLocationPStatSearchBox;
        private TextBox mainNumPStatSearchBox;
        private DataGridViewTextBoxColumn guidCol;
        private DataGridViewTextBoxColumn numStatCol;
        private DataGridViewTextBoxColumn locationCol;
        private DataGridViewTextBoxColumn typePetrolStationCol;
        private DataGridViewButtonColumn listEquipmentCol;
        private DataGridViewTextBoxColumn createdByCol;
        private DataGridViewTextBoxColumn createdDateCol;
        private DataGridViewTextBoxColumn updatedByCol;
        private DataGridViewTextBoxColumn updatedDateCol;
        private DataGridViewButtonColumn deleteBtnCol;
        private Button backupDbBtn;
        private Button exportToWordBtn;
        private Button commonMaxPriceEqPsBtn;
    }
}