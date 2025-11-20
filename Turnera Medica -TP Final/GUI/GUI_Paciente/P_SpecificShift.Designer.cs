namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    partial class P_SpecificShift
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
            this.return_start_P = new System.Windows.Forms.Button();
            this.P_SpecificShift_list = new System.Windows.Forms.DataGridView();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.searchShift = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P_SpecificShift_list)).BeginInit();
            this.SuspendLayout();
            // 
            // return_start_P
            // 
            this.return_start_P.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_P.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.return_start_P.Location = new System.Drawing.Point(351, 403);
            this.return_start_P.Name = "return_start_P";
            this.return_start_P.Size = new System.Drawing.Size(110, 35);
            this.return_start_P.TabIndex = 1;
            this.return_start_P.Text = "Volver";
            this.return_start_P.UseVisualStyleBackColor = false;
            this.return_start_P.Click += new System.EventHandler(this.return_start_P_Click);
            // 
            // P_SpecificShift_list
            // 
            this.P_SpecificShift_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P_SpecificShift_list.Location = new System.Drawing.Point(83, 145);
            this.P_SpecificShift_list.MultiSelect = false;
            this.P_SpecificShift_list.Name = "P_SpecificShift_list";
            this.P_SpecificShift_list.ReadOnly = true;
            this.P_SpecificShift_list.Size = new System.Drawing.Size(630, 230);
            this.P_SpecificShift_list.TabIndex = 2;
            this.P_SpecificShift_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.P_SpecificShift_list_CellContentClick);
            // 
            // selectDate
            // 
            this.selectDate.CustomFormat = "dd/MM/yyyy";
            this.selectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectDate.Location = new System.Drawing.Point(352, 94);
            this.selectDate.MaxDate = new System.DateTime(2025, 12, 12, 0, 0, 0, 0);
            this.selectDate.MinDate = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(109, 20);
            this.selectDate.TabIndex = 3;
            this.selectDate.Value = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.selectDate.ValueChanged += new System.EventHandler(this.selectDate_ValueChanged);
            // 
            // searchShift
            // 
            this.searchShift.BackColor = System.Drawing.Color.PaleGreen;
            this.searchShift.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchShift.Location = new System.Drawing.Point(494, 93);
            this.searchShift.Name = "searchShift";
            this.searchShift.Size = new System.Drawing.Size(90, 26);
            this.searchShift.TabIndex = 4;
            this.searchShift.Text = "Buscar";
            this.searchShift.UseVisualStyleBackColor = false;
            this.searchShift.Click += new System.EventHandler(this.searchShift_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Turno Especifico";
            // 
            // P_SpecificShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchShift);
            this.Controls.Add(this.selectDate);
            this.Controls.Add(this.P_SpecificShift_list);
            this.Controls.Add(this.return_start_P);
            this.Name = "P_SpecificShift";
            this.Text = "Buscar Turno Especifico";
            this.Load += new System.EventHandler(this.P_SpecificShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_SpecificShift_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_start_P;
        private System.Windows.Forms.DataGridView P_SpecificShift_list;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.Button searchShift;
        private System.Windows.Forms.Label label1;
    }
}