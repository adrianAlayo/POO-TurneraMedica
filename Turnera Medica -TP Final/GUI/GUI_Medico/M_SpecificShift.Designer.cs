namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    partial class M_SpecificShift
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
            this.return_start_M = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.searchShifts = new System.Windows.Forms.Button();
            this.M_SpecificShift_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.M_SpecificShift_list)).BeginInit();
            this.SuspendLayout();
            // 
            // return_start_M
            // 
            this.return_start_M.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_M.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_start_M.Location = new System.Drawing.Point(325, 398);
            this.return_start_M.Name = "return_start_M";
            this.return_start_M.Size = new System.Drawing.Size(150, 40);
            this.return_start_M.TabIndex = 0;
            this.return_start_M.Text = "Volver";
            this.return_start_M.UseVisualStyleBackColor = false;
            this.return_start_M.Click += new System.EventHandler(this.return_start_M_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Turno Especifico";
            // 
            // selectDate
            // 
            this.selectDate.CustomFormat = "dd/MM/yyyy";
            this.selectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectDate.Location = new System.Drawing.Point(348, 99);
            this.selectDate.MaxDate = new System.DateTime(2025, 12, 12, 0, 0, 0, 0);
            this.selectDate.MinDate = new System.DateTime(2025, 11, 10, 0, 0, 0, 0);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(103, 20);
            this.selectDate.TabIndex = 2;
            this.selectDate.Value = new System.DateTime(2025, 11, 10, 0, 0, 0, 0);
            this.selectDate.ValueChanged += new System.EventHandler(this.selectDate_ValueChanged);
            this.selectDate.Validating += new System.ComponentModel.CancelEventHandler(this.selectDate_Validating);
            // 
            // searchShifts
            // 
            this.searchShifts.BackColor = System.Drawing.Color.LightGreen;
            this.searchShifts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchShifts.Location = new System.Drawing.Point(486, 98);
            this.searchShifts.Name = "searchShifts";
            this.searchShifts.Size = new System.Drawing.Size(90, 26);
            this.searchShifts.TabIndex = 3;
            this.searchShifts.Text = "Buscar";
            this.searchShifts.UseVisualStyleBackColor = false;
            this.searchShifts.Click += new System.EventHandler(this.searchShifts_Click);
            // 
            // M_SpecificShift_list
            // 
            this.M_SpecificShift_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.M_SpecificShift_list.Location = new System.Drawing.Point(67, 143);
            this.M_SpecificShift_list.MultiSelect = false;
            this.M_SpecificShift_list.Name = "M_SpecificShift_list";
            this.M_SpecificShift_list.ReadOnly = true;
            this.M_SpecificShift_list.Size = new System.Drawing.Size(663, 233);
            this.M_SpecificShift_list.TabIndex = 4;
            this.M_SpecificShift_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.M_SpecificShift_list_CellContentClick);
            // 
            // M_SpecificShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.M_SpecificShift_list);
            this.Controls.Add(this.searchShifts);
            this.Controls.Add(this.selectDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_start_M);
            this.Name = "M_SpecificShift";
            this.Text = "SpecificShift";
            this.Load += new System.EventHandler(this.M_SpecificShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.M_SpecificShift_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_start_M;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.Button searchShifts;
        private System.Windows.Forms.DataGridView M_SpecificShift_list;
    }
}