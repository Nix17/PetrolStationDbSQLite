namespace PetrolStationDB.Views.EquipmentView
{
    partial class EquipmentWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataEquipmentGV = new System.Windows.Forms.DataGridView();
            this.guidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dareReleaseCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInventoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.structureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.priceSearchBox = new System.Windows.Forms.TextBox();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.commonSearchBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.releaseTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.inputPriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invNumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inventoryTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.structuresCmbBox = new System.Windows.Forms.ComboBox();
            this.addNewEquipmentBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipmentGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1290, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1282, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox2.Controls.Add(this.dataEquipmentGV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1276, 384);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список";
            // 
            // dataEquipmentGV
            // 
            this.dataEquipmentGV.AllowUserToAddRows = false;
            this.dataEquipmentGV.AllowUserToDeleteRows = false;
            this.dataEquipmentGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEquipmentGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guidCol,
            this.invNumCol,
            this.nameCol,
            this.priceCol,
            this.dareReleaseCol,
            this.dateInventoryCol,
            this.structureCol,
            this.createdByCol,
            this.createdDateCol,
            this.updatedByCol,
            this.updatedDateCol,
            this.changeBtn,
            this.deleteBtn});
            this.dataEquipmentGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEquipmentGV.Location = new System.Drawing.Point(3, 30);
            this.dataEquipmentGV.Name = "dataEquipmentGV";
            this.dataEquipmentGV.RowHeadersWidth = 51;
            this.dataEquipmentGV.RowTemplate.Height = 29;
            this.dataEquipmentGV.Size = new System.Drawing.Size(1270, 351);
            this.dataEquipmentGV.TabIndex = 1;
            this.dataEquipmentGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEquipmentGV_CellContentClick);
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
            // invNumCol
            // 
            this.invNumCol.HeaderText = "Инвентарный номер";
            this.invNumCol.MinimumWidth = 6;
            this.invNumCol.Name = "invNumCol";
            this.invNumCol.ReadOnly = true;
            this.invNumCol.Width = 125;
            // 
            // nameCol
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            this.nameCol.DefaultCellStyle = dataGridViewCellStyle13;
            this.nameCol.HeaderText = "Название";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.Width = 250;
            // 
            // priceCol
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
            this.priceCol.DefaultCellStyle = dataGridViewCellStyle14;
            this.priceCol.HeaderText = "Цена";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
            this.priceCol.Width = 125;
            // 
            // dareReleaseCol
            // 
            this.dareReleaseCol.HeaderText = "Дата выпуска";
            this.dareReleaseCol.MinimumWidth = 6;
            this.dareReleaseCol.Name = "dareReleaseCol";
            this.dareReleaseCol.ReadOnly = true;
            this.dareReleaseCol.Width = 200;
            // 
            // dateInventoryCol
            // 
            this.dateInventoryCol.HeaderText = "Дата последней инвентаризации";
            this.dateInventoryCol.MinimumWidth = 6;
            this.dateInventoryCol.Name = "dateInventoryCol";
            this.dateInventoryCol.ReadOnly = true;
            this.dateInventoryCol.Width = 200;
            // 
            // structureCol
            // 
            this.structureCol.HeaderText = "Сооружение";
            this.structureCol.MinimumWidth = 6;
            this.structureCol.Name = "structureCol";
            this.structureCol.ReadOnly = true;
            this.structureCol.Width = 250;
            // 
            // createdByCol
            // 
            this.createdByCol.HeaderText = "Кем создано";
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
            this.updatedByCol.HeaderText = "Кем обновлено";
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
            // changeBtn
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.changeBtn.DefaultCellStyle = dataGridViewCellStyle15;
            this.changeBtn.HeaderText = "Изменить";
            this.changeBtn.MinimumWidth = 6;
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.ReadOnly = true;
            this.changeBtn.Width = 125;
            // 
            // deleteBtn
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.DefaultCellStyle = dataGridViewCellStyle16;
            this.deleteBtn.HeaderText = "Удалить";
            this.deleteBtn.MinimumWidth = 6;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ReadOnly = true;
            this.deleteBtn.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.priceSearchBox);
            this.groupBox1.Controls.Add(this.nameSearchBox);
            this.groupBox1.Controls.Add(this.commonSearchBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1276, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // clearBtn
            // 
            this.clearBtn.ForeColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(1142, 70);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(128, 34);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // priceSearchBox
            // 
            this.priceSearchBox.Location = new System.Drawing.Point(605, 71);
            this.priceSearchBox.Name = "priceSearchBox";
            this.priceSearchBox.PlaceholderText = "Поиск по цене...";
            this.priceSearchBox.Size = new System.Drawing.Size(531, 34);
            this.priceSearchBox.TabIndex = 0;
            this.priceSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceSearchBox.TextChanged += new System.EventHandler(this.priceSearchBox_TextChanged);
            this.priceSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceSearchBox_KeyPress);
            // 
            // nameSearchBox
            // 
            this.nameSearchBox.Location = new System.Drawing.Point(3, 70);
            this.nameSearchBox.Name = "nameSearchBox";
            this.nameSearchBox.PlaceholderText = "Поиск по названию...";
            this.nameSearchBox.Size = new System.Drawing.Size(596, 34);
            this.nameSearchBox.TabIndex = 0;
            this.nameSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameSearchBox.TextChanged += new System.EventHandler(this.nameSearchBox_TextChanged);
            // 
            // commonSearchBox
            // 
            this.commonSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.commonSearchBox.Location = new System.Drawing.Point(3, 30);
            this.commonSearchBox.Name = "commonSearchBox";
            this.commonSearchBox.PlaceholderText = "Общий поиск...";
            this.commonSearchBox.Size = new System.Drawing.Size(1270, 34);
            this.commonSearchBox.TabIndex = 0;
            this.commonSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.commonSearchBox.TextChanged += new System.EventHandler(this.commonSearchBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1282, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.addNewEquipmentBtn);
            this.groupBox3.Controls.Add(this.structuresCmbBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.inventoryTimePicker);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.releaseTimePicker);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.inputPriceBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.inputNameBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.invNumBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1276, 499);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных";
            // 
            // releaseTimePicker
            // 
            this.releaseTimePicker.Location = new System.Drawing.Point(141, 158);
            this.releaseTimePicker.Name = "releaseTimePicker";
            this.releaseTimePicker.Size = new System.Drawing.Size(236, 34);
            this.releaseTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата выпуска";
            // 
            // inputPriceBox
            // 
            this.inputPriceBox.Location = new System.Drawing.Point(907, 104);
            this.inputPriceBox.Name = "inputPriceBox";
            this.inputPriceBox.Size = new System.Drawing.Size(363, 34);
            this.inputPriceBox.TabIndex = 5;
            this.inputPriceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPriceBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(845, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена*";
            // 
            // inputNameBox
            // 
            this.inputNameBox.Location = new System.Drawing.Point(123, 104);
            this.inputNameBox.Name = "inputNameBox";
            this.inputNameBox.Size = new System.Drawing.Size(672, 34);
            this.inputNameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название*";
            // 
            // invNumBox
            // 
            this.invNumBox.Enabled = false;
            this.invNumBox.Location = new System.Drawing.Point(200, 42);
            this.invNumBox.Name = "invNumBox";
            this.invNumBox.Size = new System.Drawing.Size(177, 34);
            this.invNumBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инвентарный номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата последней инвентаризации";
            // 
            // inventoryTimePicker
            // 
            this.inventoryTimePicker.Location = new System.Drawing.Point(751, 158);
            this.inventoryTimePicker.Name = "inventoryTimePicker";
            this.inventoryTimePicker.Size = new System.Drawing.Size(250, 34);
            this.inventoryTimePicker.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Структура";
            // 
            // structuresCmbBox
            // 
            this.structuresCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.structuresCmbBox.FormattingEnabled = true;
            this.structuresCmbBox.Location = new System.Drawing.Point(6, 262);
            this.structuresCmbBox.Name = "structuresCmbBox";
            this.structuresCmbBox.Size = new System.Drawing.Size(613, 35);
            this.structuresCmbBox.TabIndex = 11;
            // 
            // addNewEquipmentBtn
            // 
            this.addNewEquipmentBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewEquipmentBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.addNewEquipmentBtn.Location = new System.Drawing.Point(701, 249);
            this.addNewEquipmentBtn.Name = "addNewEquipmentBtn";
            this.addNewEquipmentBtn.Size = new System.Drawing.Size(569, 48);
            this.addNewEquipmentBtn.TabIndex = 12;
            this.addNewEquipmentBtn.Text = "Добавить";
            this.addNewEquipmentBtn.UseVisualStyleBackColor = true;
            this.addNewEquipmentBtn.Click += new System.EventHandler(this.addNewEquipmentBtn_Click);
            // 
            // EquipmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 545);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EquipmentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оборудование";
            this.Load += new System.EventHandler(this.EquipmentWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipmentGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private DataGridView dataEquipmentGV;
        private GroupBox groupBox1;
        private Button clearBtn;
        private TextBox priceSearchBox;
        private TextBox nameSearchBox;
        private TextBox commonSearchBox;
        private DataGridViewTextBoxColumn guidCol;
        private DataGridViewTextBoxColumn invNumCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn priceCol;
        private DataGridViewTextBoxColumn dareReleaseCol;
        private DataGridViewTextBoxColumn dateInventoryCol;
        private DataGridViewTextBoxColumn structureCol;
        private DataGridViewTextBoxColumn createdByCol;
        private DataGridViewTextBoxColumn createdDateCol;
        private DataGridViewTextBoxColumn updatedByCol;
        private DataGridViewTextBoxColumn updatedDateCol;
        private DataGridViewButtonColumn changeBtn;
        private DataGridViewButtonColumn deleteBtn;
        private GroupBox groupBox3;
        private DateTimePicker releaseTimePicker;
        private Label label4;
        private TextBox inputPriceBox;
        private Label label3;
        private TextBox inputNameBox;
        private Label label2;
        private TextBox invNumBox;
        private Label label1;
        private DateTimePicker inventoryTimePicker;
        private Label label5;
        private Button addNewEquipmentBtn;
        private ComboBox structuresCmbBox;
        private Label label6;
    }
}