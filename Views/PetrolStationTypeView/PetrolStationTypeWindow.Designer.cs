namespace PetrolStationDB.Views.PetrolStationTypeView
{
    partial class PetrolStationTypeWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typeDataGV = new System.Windows.Forms.DataGridView();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearFiltersBtn = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.changeByBox = new System.Windows.Forms.TextBox();
            this.typeNameSearchBox = new System.Windows.Forms.TextBox();
            this.commonSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addTypeBox = new System.Windows.Forms.TextBox();
            this.addNewTypeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.typeDataGV);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1317, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список";
            // 
            // typeDataGV
            // 
            this.typeDataGV.AllowUserToAddRows = false;
            this.typeDataGV.AllowUserToDeleteRows = false;
            this.typeDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCol,
            this.typeCol,
            this.createdByCol,
            this.createdDateCol,
            this.updatedByCol,
            this.updatedDateCol,
            this.guidCol,
            this.changeBtnCol,
            this.deleteBtnCol});
            this.typeDataGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeDataGV.Location = new System.Drawing.Point(3, 30);
            this.typeDataGV.Name = "typeDataGV";
            this.typeDataGV.RowHeadersWidth = 51;
            this.typeDataGV.RowTemplate.Height = 29;
            this.typeDataGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.typeDataGV.Size = new System.Drawing.Size(1311, 267);
            this.typeDataGV.TabIndex = 0;
            this.typeDataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.typeDataGV_CellContentClick);
            // 
            // numCol
            // 
            this.numCol.HeaderText = "#";
            this.numCol.MinimumWidth = 6;
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            this.numCol.Width = 80;
            // 
            // typeCol
            // 
            this.typeCol.HeaderText = "Тип";
            this.typeCol.MinimumWidth = 6;
            this.typeCol.Name = "typeCol";
            this.typeCol.Width = 200;
            // 
            // createdByCol
            // 
            this.createdByCol.HeaderText = "Кем создан";
            this.createdByCol.MinimumWidth = 6;
            this.createdByCol.Name = "createdByCol";
            this.createdByCol.ReadOnly = true;
            this.createdByCol.Width = 150;
            // 
            // createdDateCol
            // 
            this.createdDateCol.HeaderText = "Создан";
            this.createdDateCol.MinimumWidth = 6;
            this.createdDateCol.Name = "createdDateCol";
            this.createdDateCol.ReadOnly = true;
            this.createdDateCol.Width = 200;
            // 
            // updatedByCol
            // 
            this.updatedByCol.HeaderText = "Кем обновлён";
            this.updatedByCol.MinimumWidth = 6;
            this.updatedByCol.Name = "updatedByCol";
            this.updatedByCol.ReadOnly = true;
            this.updatedByCol.Width = 150;
            // 
            // updatedDateCol
            // 
            this.updatedDateCol.HeaderText = "Обновлён";
            this.updatedDateCol.MinimumWidth = 6;
            this.updatedDateCol.Name = "updatedDateCol";
            this.updatedDateCol.ReadOnly = true;
            this.updatedDateCol.Width = 200;
            // 
            // guidCol
            // 
            this.guidCol.HeaderText = "Guid";
            this.guidCol.MinimumWidth = 6;
            this.guidCol.Name = "guidCol";
            this.guidCol.ReadOnly = true;
            this.guidCol.Visible = false;
            this.guidCol.Width = 125;
            // 
            // changeBtnCol
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.changeBtnCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.changeBtnCol.HeaderText = "Изменить";
            this.changeBtnCol.MinimumWidth = 6;
            this.changeBtnCol.Name = "changeBtnCol";
            this.changeBtnCol.Width = 125;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.deleteBtnCol.HeaderText = "Удалить";
            this.deleteBtnCol.MinimumWidth = 6;
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.addNewTypeBtn);
            this.groupBox2.Controls.Add(this.addTypeBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1317, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавить";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox3.Controls.Add(this.clearFiltersBtn);
            this.groupBox3.Controls.Add(this.dateBox);
            this.groupBox3.Controls.Add(this.changeByBox);
            this.groupBox3.Controls.Add(this.typeNameSearchBox);
            this.groupBox3.Controls.Add(this.commonSearchBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1317, 140);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск";
            // 
            // clearFiltersBtn
            // 
            this.clearFiltersBtn.BackColor = System.Drawing.Color.LightCoral;
            this.clearFiltersBtn.Location = new System.Drawing.Point(1071, 85);
            this.clearFiltersBtn.Name = "clearFiltersBtn";
            this.clearFiltersBtn.Size = new System.Drawing.Size(243, 34);
            this.clearFiltersBtn.TabIndex = 0;
            this.clearFiltersBtn.Text = "Очистить фильтры";
            this.clearFiltersBtn.UseVisualStyleBackColor = false;
            this.clearFiltersBtn.Click += new System.EventHandler(this.clearFiltersBtn_Click);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(715, 85);
            this.dateBox.Name = "dateBox";
            this.dateBox.PlaceholderText = "Поиск по дате...";
            this.dateBox.Size = new System.Drawing.Size(350, 34);
            this.dateBox.TabIndex = 4;
            this.dateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateBox.TextChanged += new System.EventHandler(this.dateBox_TextChanged);
            // 
            // changeByBox
            // 
            this.changeByBox.Location = new System.Drawing.Point(359, 85);
            this.changeByBox.Name = "changeByBox";
            this.changeByBox.PlaceholderText = "Поиск по пользователю...";
            this.changeByBox.Size = new System.Drawing.Size(350, 34);
            this.changeByBox.TabIndex = 3;
            this.changeByBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.changeByBox.TextChanged += new System.EventHandler(this.changeByBox_TextChanged);
            // 
            // typeNameSearchBox
            // 
            this.typeNameSearchBox.Location = new System.Drawing.Point(3, 85);
            this.typeNameSearchBox.Name = "typeNameSearchBox";
            this.typeNameSearchBox.PlaceholderText = "Поиск по названию типа...";
            this.typeNameSearchBox.Size = new System.Drawing.Size(350, 34);
            this.typeNameSearchBox.TabIndex = 2;
            this.typeNameSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typeNameSearchBox.TextChanged += new System.EventHandler(this.typeNameSearchBox_TextChanged);
            // 
            // commonSearchBox
            // 
            this.commonSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonSearchBox.Location = new System.Drawing.Point(3, 30);
            this.commonSearchBox.Name = "commonSearchBox";
            this.commonSearchBox.PlaceholderText = "Общий поиск...";
            this.commonSearchBox.Size = new System.Drawing.Size(1311, 34);
            this.commonSearchBox.TabIndex = 1;
            this.commonSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.commonSearchBox.TextChanged += new System.EventHandler(this.commonSearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название типа:";
            // 
            // addTypeBox
            // 
            this.addTypeBox.Location = new System.Drawing.Point(257, 57);
            this.addTypeBox.Name = "addTypeBox";
            this.addTypeBox.Size = new System.Drawing.Size(390, 34);
            this.addTypeBox.TabIndex = 1;
            // 
            // addNewTypeBtn
            // 
            this.addNewTypeBtn.Location = new System.Drawing.Point(668, 55);
            this.addNewTypeBtn.Name = "addNewTypeBtn";
            this.addNewTypeBtn.Size = new System.Drawing.Size(341, 36);
            this.addNewTypeBtn.TabIndex = 2;
            this.addNewTypeBtn.Text = "Добавить";
            this.addNewTypeBtn.UseVisualStyleBackColor = true;
            this.addNewTypeBtn.Click += new System.EventHandler(this.addNewTypeBtn_Click);
            // 
            // PetrolStationTypeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 578);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PetrolStationTypeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список типов АЗС";
            this.Load += new System.EventHandler(this.PetrolStationTypeWindow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView typeDataGV;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox commonSearchBox;
        private TextBox changeByBox;
        private TextBox typeNameSearchBox;
        private TextBox dateBox;
        private Button clearFiltersBtn;
        private DataGridViewTextBoxColumn numCol;
        private DataGridViewTextBoxColumn typeCol;
        private DataGridViewTextBoxColumn createdByCol;
        private DataGridViewTextBoxColumn createdDateCol;
        private DataGridViewTextBoxColumn updatedByCol;
        private DataGridViewTextBoxColumn updatedDateCol;
        private DataGridViewTextBoxColumn guidCol;
        private DataGridViewButtonColumn changeBtnCol;
        private DataGridViewButtonColumn deleteBtnCol;
        private Button addNewTypeBtn;
        private TextBox addTypeBox;
        private Label label1;
    }
}