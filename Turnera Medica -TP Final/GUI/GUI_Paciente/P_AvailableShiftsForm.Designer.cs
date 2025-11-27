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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_AvailableShiftsForm));
            this.ReturnPreRegister = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectSpeciality = new System.Windows.Forms.ComboBox();
            this.SearchShift_Send = new System.Windows.Forms.Button();
            this.selectOffice = new System.Windows.Forms.ComboBox();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SendLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P_name_user_guia = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnPreRegister
            // 
            this.ReturnPreRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReturnPreRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReturnPreRegister.FlatAppearance.BorderSize = 10;
            this.ReturnPreRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.ReturnPreRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ReturnPreRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnPreRegister.Location = new System.Drawing.Point(16, 232);
            this.ReturnPreRegister.Name = "ReturnPreRegister";
            this.ReturnPreRegister.Size = new System.Drawing.Size(178, 41);
            this.ReturnPreRegister.TabIndex = 36;
            this.ReturnPreRegister.Text = "Volver";
            this.ReturnPreRegister.UseVisualStyleBackColor = false;
            this.ReturnPreRegister.Click += new System.EventHandler(this.ReturnPreRegister_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(166, 21);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(113, 19);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Especialidad:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(194, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(174, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Consultorio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SelectSpeciality
            // 
            this.SelectSpeciality.BackColor = System.Drawing.SystemColors.Control;
            this.SelectSpeciality.Font = new System.Drawing.Font("Arial", 9F);
            this.SelectSpeciality.FormattingEnabled = true;
            this.SelectSpeciality.Items.AddRange(new object[] {
            "Cardiología",
            "Pediatría",
            "Dermatología",
            "Traumatología",
            "Clínica Médica"});
            this.SelectSpeciality.Location = new System.Drawing.Point(151, 43);
            this.SelectSpeciality.Name = "SelectSpeciality";
            this.SelectSpeciality.Size = new System.Drawing.Size(149, 23);
            this.SelectSpeciality.TabIndex = 54;
            this.SelectSpeciality.SelectedIndexChanged += new System.EventHandler(this.SelectSpeciality_SelectedIndexChanged);
            // 
            // SearchShift_Send
            // 
            this.SearchShift_Send.BackColor = System.Drawing.Color.PaleGreen;
            this.SearchShift_Send.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchShift_Send.Location = new System.Drawing.Point(259, 232);
            this.SearchShift_Send.Name = "SearchShift_Send";
            this.SearchShift_Send.Size = new System.Drawing.Size(178, 41);
            this.SearchShift_Send.TabIndex = 55;
            this.SearchShift_Send.Text = "Buscar";
            this.SearchShift_Send.UseVisualStyleBackColor = false;
            this.SearchShift_Send.Click += new System.EventHandler(this.SearchShift_Send_Click);
            // 
            // selectOffice
            // 
            this.selectOffice.BackColor = System.Drawing.SystemColors.Control;
            this.selectOffice.Font = new System.Drawing.Font("Arial", 9F);
            this.selectOffice.FormattingEnabled = true;
            this.selectOffice.Items.AddRange(new object[] {
            "Corrientes 1500",
            "Carabobo 3000",
            "México 2500",
            "Uruguay 4000",
            "Yrigoyen 3500"});
            this.selectOffice.Location = new System.Drawing.Point(151, 161);
            this.selectOffice.Name = "selectOffice";
            this.selectOffice.Size = new System.Drawing.Size(149, 23);
            this.selectOffice.TabIndex = 56;
            this.selectOffice.SelectedIndexChanged += new System.EventHandler(this.selectOffice_SelectedIndexChanged);
            // 
            // selectDate
            // 
            this.selectDate.CustomFormat = "dd/MM/2025";
            this.selectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectDate.Location = new System.Drawing.Point(151, 103);
            this.selectDate.MaxDate = new System.DateTime(2025, 12, 12, 0, 0, 0, 0);
            this.selectDate.MinDate = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(149, 20);
            this.selectDate.TabIndex = 57;
            this.selectDate.Value = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.selectDate.ValueChanged += new System.EventHandler(this.selectDate_ValueChanged);
            this.selectDate.Validating += new System.ComponentModel.CancelEventHandler(this.selectDate_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SendLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.P_name_user_guia);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 56);
            this.panel1.TabIndex = 58;
            // 
            // SendLogin
            // 
            this.SendLogin.BackColor = System.Drawing.Color.Coral;
            this.SendLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SendLogin.Location = new System.Drawing.Point(609, 6);
            this.SendLogin.Name = "SendLogin";
            this.SendLogin.Size = new System.Drawing.Size(178, 41);
            this.SendLogin.TabIndex = 21;
            this.SendLogin.Text = "Cerrar Sesion";
            this.SendLogin.UseVisualStyleBackColor = false;
            this.SendLogin.Click += new System.EventHandler(this.SendLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // P_name_user_guia
            // 
            this.P_name_user_guia.AutoSize = true;
            this.P_name_user_guia.Font = new System.Drawing.Font("Arial Black", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_name_user_guia.Location = new System.Drawing.Point(59, 7);
            this.P_name_user_guia.Name = "P_name_user_guia";
            this.P_name_user_guia.Size = new System.Drawing.Size(162, 40);
            this.P_name_user_guia.TabIndex = 10;
            this.P_name_user_guia.Text = "Paciente:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.SelectSpeciality);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.SearchShift_Send);
            this.panel3.Controls.Add(this.selectOffice);
            this.panel3.Controls.Add(this.ReturnPreRegister);
            this.panel3.Controls.Add(this.selectDate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(202, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 286);
            this.panel3.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(202, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 71);
            this.panel2.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "Turnos Disponibles";
            // 
            // P_AvailableShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P_AvailableShiftsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Turnos Disponibles";
            this.Load += new System.EventHandler(this.P_AvailableShiftsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ReturnPreRegister;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectSpeciality;
        private System.Windows.Forms.Button SearchShift_Send;
        private System.Windows.Forms.ComboBox selectOffice;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label P_name_user_guia;
        private System.Windows.Forms.Button SendLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}