namespace Turnera_Medica__TP_Final.GUI
{
    partial class RegisterMedic
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
            this.s = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerM_dni_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerM_montConsul_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerM_email_user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registerM_password_user = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.registerM_confirPassword_user = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.registerM_socialWork_user = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.registerM_numberPhone_user = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.registerM_lastName_user = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RegisterM_send = new System.Windows.Forms.Button();
            this.ReturnPreRegister = new System.Windows.Forms.Button();
            this.registerM_name_user = new System.Windows.Forms.TextBox();
            this.registerM_age_user = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.registerM_speciality_user = new System.Windows.Forms.ComboBox();
            this.registerM_office_user = new System.Windows.Forms.ComboBox();
            this.registerM_entryTime_user = new System.Windows.Forms.DateTimePicker();
            this.registerM_departureTime_user = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(129, 115);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(76, 19);
            this.s.TabIndex = 6;
            this.s.Text = "Nombre:";
            this.s.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "Formulario Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "DNI:";
            // 
            // registerM_dni_user
            // 
            this.registerM_dni_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_dni_user.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerM_dni_user.Location = new System.Drawing.Point(213, 207);
            this.registerM_dni_user.Name = "registerM_dni_user";
            this.registerM_dni_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_dni_user.TabIndex = 8;
            this.registerM_dni_user.TextChanged += new System.EventHandler(this.registerM_dni_user_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(41, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Monto por Consulta:";
            // 
            // registerM_montConsul_user
            // 
            this.registerM_montConsul_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_montConsul_user.Font = new System.Drawing.Font("Arial", 9F);
            this.registerM_montConsul_user.Location = new System.Drawing.Point(213, 252);
            this.registerM_montConsul_user.Name = "registerM_montConsul_user";
            this.registerM_montConsul_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_montConsul_user.TabIndex = 12;
            this.registerM_montConsul_user.TextChanged += new System.EventHandler(this.registerM_montConsul_user_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(150, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            // 
            // registerM_email_user
            // 
            this.registerM_email_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_email_user.Font = new System.Drawing.Font("Arial", 9F);
            this.registerM_email_user.Location = new System.Drawing.Point(213, 346);
            this.registerM_email_user.Name = "registerM_email_user";
            this.registerM_email_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_email_user.TabIndex = 10;
            this.registerM_email_user.TextChanged += new System.EventHandler(this.registerM_email_user_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(438, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Contraseña:";
            // 
            // registerM_password_user
            // 
            this.registerM_password_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_password_user.Font = new System.Drawing.Font("Arial", 9F);
            this.registerM_password_user.Location = new System.Drawing.Point(548, 299);
            this.registerM_password_user.Name = "registerM_password_user";
            this.registerM_password_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_password_user.TabIndex = 16;
            this.registerM_password_user.UseSystemPasswordChar = true;
            this.registerM_password_user.TextChanged += new System.EventHandler(this.registerM_password_user_TextChanged);
            this.registerM_password_user.DoubleClick += new System.EventHandler(this.registerM_password_user_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(102, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Consultorio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Confirmar Contraseña:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // registerM_confirPassword_user
            // 
            this.registerM_confirPassword_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_confirPassword_user.Font = new System.Drawing.Font("Arial", 9F);
            this.registerM_confirPassword_user.Location = new System.Drawing.Point(213, 390);
            this.registerM_confirPassword_user.Name = "registerM_confirPassword_user";
            this.registerM_confirPassword_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_confirPassword_user.TabIndex = 28;
            this.registerM_confirPassword_user.UseSystemPasswordChar = true;
            this.registerM_confirPassword_user.TextChanged += new System.EventHandler(this.registerM_confirPassword_user_TextChanged);
            this.registerM_confirPassword_user.DoubleClick += new System.EventHandler(this.registerM_confirPassword_user_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(416, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Horario de Entrada:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(438, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Obra Social:";
            // 
            // registerM_socialWork_user
            // 
            this.registerM_socialWork_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_socialWork_user.Font = new System.Drawing.Font("Arial", 9F);
            this.registerM_socialWork_user.Location = new System.Drawing.Point(548, 251);
            this.registerM_socialWork_user.Name = "registerM_socialWork_user";
            this.registerM_socialWork_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_socialWork_user.TabIndex = 24;
            this.registerM_socialWork_user.TextChanged += new System.EventHandler(this.registerM_socialWork_user_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(428, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Especialidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(460, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefono:";
            // 
            // registerM_numberPhone_user
            // 
            this.registerM_numberPhone_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_numberPhone_user.Font = new System.Drawing.Font("Arial", 9F);
            this.registerM_numberPhone_user.Location = new System.Drawing.Point(548, 162);
            this.registerM_numberPhone_user.Name = "registerM_numberPhone_user";
            this.registerM_numberPhone_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_numberPhone_user.TabIndex = 20;
            this.registerM_numberPhone_user.TextChanged += new System.EventHandler(this.registerM_numberPhone_user_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(460, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Apellido:";
            // 
            // registerM_lastName_user
            // 
            this.registerM_lastName_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_lastName_user.Font = new System.Drawing.Font("Arial", 9F);
            this.registerM_lastName_user.Location = new System.Drawing.Point(548, 115);
            this.registerM_lastName_user.Name = "registerM_lastName_user";
            this.registerM_lastName_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_lastName_user.TabIndex = 18;
            this.registerM_lastName_user.TextChanged += new System.EventHandler(this.registerM_lastName_user_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(428, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Horario de Salida:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // RegisterM_send
            // 
            this.RegisterM_send.BackColor = System.Drawing.Color.LightGreen;
            this.RegisterM_send.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterM_send.Location = new System.Drawing.Point(355, 465);
            this.RegisterM_send.Name = "RegisterM_send";
            this.RegisterM_send.Size = new System.Drawing.Size(122, 37);
            this.RegisterM_send.TabIndex = 33;
            this.RegisterM_send.Text = "Registrarse";
            this.RegisterM_send.UseVisualStyleBackColor = false;
            this.RegisterM_send.Click += new System.EventHandler(this.RegisterM_send_Click);
            // 
            // ReturnPreRegister
            // 
            this.ReturnPreRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReturnPreRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReturnPreRegister.FlatAppearance.BorderSize = 10;
            this.ReturnPreRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.ReturnPreRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ReturnPreRegister.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnPreRegister.Location = new System.Drawing.Point(45, 507);
            this.ReturnPreRegister.Name = "ReturnPreRegister";
            this.ReturnPreRegister.Size = new System.Drawing.Size(110, 35);
            this.ReturnPreRegister.TabIndex = 35;
            this.ReturnPreRegister.Text = "Volver";
            this.ReturnPreRegister.UseVisualStyleBackColor = false;
            this.ReturnPreRegister.Click += new System.EventHandler(this.ReturnPreRegister_Click);
            // 
            // registerM_name_user
            // 
            this.registerM_name_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_name_user.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerM_name_user.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registerM_name_user.Location = new System.Drawing.Point(213, 114);
            this.registerM_name_user.Name = "registerM_name_user";
            this.registerM_name_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_name_user.TabIndex = 39;
            this.registerM_name_user.TextChanged += new System.EventHandler(this.registerM_name_user_TextChanged);
            // 
            // registerM_age_user
            // 
            this.registerM_age_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_age_user.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerM_age_user.Location = new System.Drawing.Point(213, 163);
            this.registerM_age_user.Name = "registerM_age_user";
            this.registerM_age_user.Size = new System.Drawing.Size(188, 21);
            this.registerM_age_user.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(152, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 19);
            this.label14.TabIndex = 58;
            this.label14.Text = "Edad:";
            // 
            // registerM_speciality_user
            // 
            this.registerM_speciality_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_speciality_user.Font = new System.Drawing.Font("Arial", 9F);
            this.registerM_speciality_user.FormattingEnabled = true;
            this.registerM_speciality_user.Items.AddRange(new object[] {
            "Cardiología",
            "Pediatría",
            "Dermatología",
            "Traumatología",
            "Clínica Médica"});
            this.registerM_speciality_user.Location = new System.Drawing.Point(548, 206);
            this.registerM_speciality_user.Name = "registerM_speciality_user";
            this.registerM_speciality_user.Size = new System.Drawing.Size(188, 23);
            this.registerM_speciality_user.TabIndex = 60;
            this.registerM_speciality_user.SelectedIndexChanged += new System.EventHandler(this.registerM_speciality_user_SelectedIndexChanged);
            // 
            // registerM_office_user
            // 
            this.registerM_office_user.BackColor = System.Drawing.SystemColors.Control;
            this.registerM_office_user.Font = new System.Drawing.Font("Arial", 9F);
            this.registerM_office_user.FormattingEnabled = true;
            this.registerM_office_user.Items.AddRange(new object[] {
            "Corrientes 1500",
            "Carabobo 3000",
            "México 2500",
            "Uruguay 4000",
            "Yrigoyen 3500"});
            this.registerM_office_user.Location = new System.Drawing.Point(213, 298);
            this.registerM_office_user.Name = "registerM_office_user";
            this.registerM_office_user.Size = new System.Drawing.Size(188, 23);
            this.registerM_office_user.TabIndex = 61;
            this.registerM_office_user.SelectedIndexChanged += new System.EventHandler(this.registerM_office_user_SelectedIndexChanged);
            // 
            // registerM_entryTime_user
            // 
            this.registerM_entryTime_user.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.registerM_entryTime_user.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerM_entryTime_user.CustomFormat = "HH:mm";
            this.registerM_entryTime_user.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.registerM_entryTime_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registerM_entryTime_user.Location = new System.Drawing.Point(581, 346);
            this.registerM_entryTime_user.MaxDate = new System.DateTime(2025, 12, 12, 0, 0, 0, 0);
            this.registerM_entryTime_user.MinDate = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.registerM_entryTime_user.Name = "registerM_entryTime_user";
            this.registerM_entryTime_user.ShowUpDown = true;
            this.registerM_entryTime_user.Size = new System.Drawing.Size(87, 20);
            this.registerM_entryTime_user.TabIndex = 62;
            this.registerM_entryTime_user.Value = new System.DateTime(2025, 11, 20, 9, 0, 0, 0);
            this.registerM_entryTime_user.ValueChanged += new System.EventHandler(this.registerM_entryTime_user_ValueChanged);
            // 
            // registerM_departureTime_user
            // 
            this.registerM_departureTime_user.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.registerM_departureTime_user.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerM_departureTime_user.CustomFormat = "HH:mm";
            this.registerM_departureTime_user.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.registerM_departureTime_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registerM_departureTime_user.Location = new System.Drawing.Point(581, 391);
            this.registerM_departureTime_user.MaxDate = new System.DateTime(2025, 12, 12, 0, 0, 0, 0);
            this.registerM_departureTime_user.MinDate = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.registerM_departureTime_user.Name = "registerM_departureTime_user";
            this.registerM_departureTime_user.ShowUpDown = true;
            this.registerM_departureTime_user.Size = new System.Drawing.Size(87, 20);
            this.registerM_departureTime_user.TabIndex = 63;
            this.registerM_departureTime_user.Value = new System.DateTime(2025, 11, 20, 15, 0, 0, 0);
            this.registerM_departureTime_user.ValueChanged += new System.EventHandler(this.registerM_departureTime_user_ValueChanged);
            // 
            // RegisterMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.registerM_departureTime_user);
            this.Controls.Add(this.registerM_entryTime_user);
            this.Controls.Add(this.registerM_office_user);
            this.Controls.Add(this.registerM_speciality_user);
            this.Controls.Add(this.registerM_age_user);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.registerM_name_user);
            this.Controls.Add(this.ReturnPreRegister);
            this.Controls.Add(this.RegisterM_send);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.registerM_confirPassword_user);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.registerM_socialWork_user);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.registerM_numberPhone_user);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.registerM_lastName_user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registerM_password_user);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerM_montConsul_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registerM_email_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerM_dni_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterMedic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Medico";
            this.Load += new System.EventHandler(this.RegisterMedic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registerM_dni_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registerM_montConsul_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox registerM_email_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox registerM_password_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox registerM_confirPassword_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox registerM_socialWork_user;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox registerM_numberPhone_user;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox registerM_lastName_user;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button RegisterM_send;
        private System.Windows.Forms.Button ReturnPreRegister;
        private System.Windows.Forms.TextBox registerM_name_user;
        private System.Windows.Forms.TextBox registerM_age_user;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox registerM_speciality_user;
        private System.Windows.Forms.ComboBox registerM_office_user;
        private System.Windows.Forms.DateTimePicker registerM_entryTime_user;
        private System.Windows.Forms.DateTimePicker registerM_departureTime_user;
    }
}