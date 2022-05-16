namespace PetrolStationDB.Views.PetrolStationView
{
    partial class ListEquipmentFromPS
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
            this.dataListEquipPsGV = new System.Windows.Forms.DataGridView();
            this.numCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListEquipPsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.dataListEquipPsGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список";
            // 
            // dataListEquipPsGV
            // 
            this.dataListEquipPsGV.AllowUserToAddRows = false;
            this.dataListEquipPsGV.AllowUserToDeleteRows = false;
            this.dataListEquipPsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListEquipPsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCol,
            this.invNumCol,
            this.nameCol});
            this.dataListEquipPsGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListEquipPsGV.Location = new System.Drawing.Point(3, 30);
            this.dataListEquipPsGV.Name = "dataListEquipPsGV";
            this.dataListEquipPsGV.RowHeadersWidth = 51;
            this.dataListEquipPsGV.RowTemplate.Height = 29;
            this.dataListEquipPsGV.Size = new System.Drawing.Size(976, 420);
            this.dataListEquipPsGV.TabIndex = 0;
            // 
            // numCol
            // 
            this.numCol.FillWeight = 7.266233F;
            this.numCol.HeaderText = "#";
            this.numCol.MinimumWidth = 6;
            this.numCol.Name = "numCol";
            this.numCol.ReadOnly = true;
            this.numCol.Width = 125;
            // 
            // invNumCol
            // 
            this.invNumCol.FillWeight = 11.98511F;
            this.invNumCol.HeaderText = "Инвентарный номер";
            this.invNumCol.MinimumWidth = 6;
            this.invNumCol.Name = "invNumCol";
            this.invNumCol.ReadOnly = true;
            this.invNumCol.Width = 200;
            // 
            // nameCol
            // 
            this.nameCol.FillWeight = 280.7487F;
            this.nameCol.HeaderText = "Название";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 600;
            // 
            // ListEquipmentFromPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ListEquipmentFromPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список оборудования";
            this.Load += new System.EventHandler(this.ListEquipmentFromPS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListEquipPsGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataListEquipPsGV;
        private DataGridViewTextBoxColumn numCol;
        private DataGridViewTextBoxColumn invNumCol;
        private DataGridViewTextBoxColumn nameCol;
    }
}