namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    partial class P_AvailableShiftsForm
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ReturnPreRegister = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectSpeciality = new System.Windows.Forms.ComboBox();
            this.SearchShift_Send = new System.Windows.Forms.Button();
            this.selectOffice = new System.Windows.Forms.ComboBox();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(170, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(491, 52);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "TURNOS DISPONIBLES";
            // 
            // ReturnPreRegister
            // 
            this.ReturnPreRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReturnPreRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReturnPreRegister.FlatAppearance.BorderSize = 10;
            this.ReturnPreRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.ReturnPreRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ReturnPreRegister.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnPreRegister.Location = new System.Drawing.Point(238, 335);
            this.ReturnPreRegister.Name = "ReturnPreRegister";
            this.ReturnPreRegister.Size = new System.Drawing.Size(113, 37);
            this.ReturnPreRegister.TabIndex = 36;
            this.ReturnPreRegister.Text = "Volver";
            this.ReturnPreRegister.UseVisualStyleBackColor = false;
            this.ReturnPreRegister.Click += new System.EventHandler(this.ReturnPreRegister_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(281, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 15);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Especialidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Consultorio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SelectSpeciality
            // 
            this.SelectSpeciality.BackColor = System.Drawing.Color.LightPink;
            this.SelectSpeciality.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSpeciality.FormattingEnabled = true;
            this.SelectSpeciality.Items.AddRange(new object[] {
            "Cardiología",
            "Pediatría",
            "Dermatología",
            "Traumatología",
            "Clínica Médica"});
            this.SelectSpeciality.Location = new System.Drawing.Point(370, 147);
            this.SelectSpeciality.Name = "SelectSpeciality";
            this.SelectSpeciality.Size = new System.Drawing.Size(149, 24);
            this.SelectSpeciality.TabIndex = 54;
            this.SelectSpeciality.SelectedIndexChanged += new System.EventHandler(this.SelectSpeciality_SelectedIndexChanged);
            // 
            // SearchShift_Send
            // 
            this.SearchShift_Send.BackColor = System.Drawing.Color.LightGreen;
            this.SearchShift_Send.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchShift_Send.Location = new System.Drawing.Point(463, 335);
            this.SearchShift_Send.Name = "SearchShift_Send";
            this.SearchShift_Send.Size = new System.Drawing.Size(122, 37);
            this.SearchShift_Send.TabIndex = 55;
            this.SearchShift_Send.Text = "Buscar";
            this.SearchShift_Send.UseVisualStyleBackColor = false;
            this.SearchShift_Send.Click += new System.EventHandler(this.SearchShift_Send_Click);
            // 
            // selectOffice
            // 
            this.selectOffice.BackColor = System.Drawing.Color.LightPink;
            this.selectOffice.FormattingEnabled = true;
            this.selectOffice.Items.AddRange(new object[] {
            "Corrientes 1500",
            "Corrientes 3200",
            "Carabobo 3000",
            "México 2500",
            "Uruguay 4000",
            "Yrigoyen 3500"});
            this.selectOffice.Location = new System.Drawing.Point(370, 260);
            this.selectOffice.Name = "selectOffice";
            this.selectOffice.Size = new System.Drawing.Size(149, 21);
            this.selectOffice.TabIndex = 56;
            this.selectOffice.SelectedIndexChanged += new System.EventHandler(this.selectOffice_SelectedIndexChanged);
            // 
            // selectDate
            // 
            this.selectDate.CustomFormat = "dd/mm/yyyy";
            this.selectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectDate.Location = new System.Drawing.Point(370, 207);
            this.selectDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.selectDate.MinDate = new System.DateTime(2025, 11, 10, 0, 0, 0, 0);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(149, 20);
            this.selectDate.TabIndex = 57;
            this.selectDate.Value = new System.DateTime(2025, 11, 10, 0, 0, 0, 0);
            this.selectDate.ValueChanged += new System.EventHandler(this.selectDate_ValueChanged);
            // 
            // P_AvailableShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectDate);
            this.Controls.Add(this.selectOffice);
            this.Controls.Add(this.SearchShift_Send);
            this.Controls.Add(this.SelectSpeciality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.ReturnPreRegister);
            this.Controls.Add(this.lblTitulo);
            this.Name = "P_AvailableShiftsForm";
            this.Text = "P_AvailableShiftsForm";
            this.Load += new System.EventHandler(this.P_AvailableShiftsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button ReturnPreRegister;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectSpeciality;
        private System.Windows.Forms.Button SearchShift_Send;
        private System.Windows.Forms.ComboBox selectOffice;
        private System.Windows.Forms.DateTimePicker selectDate;
    }
}