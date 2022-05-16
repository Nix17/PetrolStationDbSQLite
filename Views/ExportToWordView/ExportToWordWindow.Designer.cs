namespace PetrolStationDB.Views.ExportToWordView
{
    partial class ExportToWordWindow
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
            this.employeesCmbBox = new System.Windows.Forms.ComboBox();
            this.exportAllPsRadioBtn = new System.Windows.Forms.RadioButton();
            this.exportEquipsByEmpRadioBtn = new System.Windows.Forms.RadioButton();
            this.exportBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.employeesCmbBox);
            this.groupBox1.Controls.Add(this.exportAllPsRadioBtn);
            this.groupBox1.Controls.Add(this.exportEquipsByEmpRadioBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор экспорта";
            // 
            // employeesCmbBox
            // 
            this.employeesCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeesCmbBox.FormattingEnabled = true;
            this.employeesCmbBox.Location = new System.Drawing.Point(12, 117);
            this.employeesCmbBox.Name = "employeesCmbBox";
            this.employeesCmbBox.Size = new System.Drawing.Size(582, 35);
            this.employeesCmbBox.TabIndex = 2;
            // 
            // exportAllPsRadioBtn
            // 
            this.exportAllPsRadioBtn.AutoSize = true;
            this.exportAllPsRadioBtn.Location = new System.Drawing.Point(12, 33);
            this.exportAllPsRadioBtn.Name = "exportAllPsRadioBtn";
            this.exportAllPsRadioBtn.Size = new System.Drawing.Size(375, 31);
            this.exportAllPsRadioBtn.TabIndex = 1;
            this.exportAllPsRadioBtn.TabStop = true;
            this.exportAllPsRadioBtn.Text = "Экспорт всех АЗС с оборудованием";
            this.exportAllPsRadioBtn.UseVisualStyleBackColor = true;
            this.exportAllPsRadioBtn.CheckedChanged += new System.EventHandler(this.exportAllPsRadioBtn_CheckedChanged);
            // 
            // exportEquipsByEmpRadioBtn
            // 
            this.exportEquipsByEmpRadioBtn.AutoSize = true;
            this.exportEquipsByEmpRadioBtn.Location = new System.Drawing.Point(12, 80);
            this.exportEquipsByEmpRadioBtn.Name = "exportEquipsByEmpRadioBtn";
            this.exportEquipsByEmpRadioBtn.Size = new System.Drawing.Size(394, 31);
            this.exportEquipsByEmpRadioBtn.TabIndex = 0;
            this.exportEquipsByEmpRadioBtn.TabStop = true;
            this.exportEquipsByEmpRadioBtn.Text = "Экспорт оборудования по сотруднику";
            this.exportEquipsByEmpRadioBtn.UseVisualStyleBackColor = true;
            this.exportEquipsByEmpRadioBtn.CheckedChanged += new System.EventHandler(this.exportEquipsByEmpRadioBtn_CheckedChanged);
            // 
            // exportBtn
            // 
            this.exportBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.exportBtn.Location = new System.Drawing.Point(295, 177);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(304, 63);
            this.exportBtn.TabIndex = 1;
            this.exportBtn.Text = "Экспортировать";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // ExportToWordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 252);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ExportToWordWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспорт в WORD";
            this.Load += new System.EventHandler(this.ExportToWordWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox employeesCmbBox;
        private RadioButton exportAllPsRadioBtn;
        private RadioButton exportEquipsByEmpRadioBtn;
        private Button exportBtn;
    }
}