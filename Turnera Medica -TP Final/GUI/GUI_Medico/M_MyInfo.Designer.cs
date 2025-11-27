namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    partial class M_MyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_MyInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.M_name_user_guia = new System.Windows.Forms.Label();
            this.SendLogin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.return_start_M = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.M_MyInfo_lastName = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.M_MyInfo_socialWorck = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.office = new System.Windows.Forms.Label();
            this.speciality = new System.Windows.Forms.Label();
            this.consult_amount = new System.Windows.Forms.Label();
            this.M_MyInfo_ChekInTime = new System.Windows.Forms.Label();
            this.M_MyInfo_ChekOutTime = new System.Windows.Forms.Label();
            this.M_MyInfo_dni = new System.Windows.Forms.TextBox();
            this.M_MyInfo_phone = new System.Windows.Forms.TextBox();
            this.M_MyInfo_speciality = new System.Windows.Forms.TextBox();
            this.M_MyInfo_office = new System.Windows.Forms.TextBox();
            this.M_MyInfo_name = new System.Windows.Forms.TextBox();
            this.M_MyInfo_consult_price = new System.Windows.Forms.TextBox();
            this.M_MyInfo_last_name = new System.Windows.Forms.TextBox();
            this.M_MyInfo_age = new System.Windows.Forms.TextBox();
            this.M_MyInfo_email = new System.Windows.Forms.TextBox();
            this.M_MyInfo_social_works = new System.Windows.Forms.TextBox();
            this.M_MyInfo_entry_time = new System.Windows.Forms.TextBox();
            this.M_MyInfo_departure_time = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.M_name_user_guia);
            this.panel1.Controls.Add(this.SendLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 57);
            this.panel1.TabIndex = 29;
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
            // M_name_user_guia
            // 
            this.M_name_user_guia.AutoSize = true;
            this.M_name_user_guia.Font = new System.Drawing.Font("Arial Black", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_name_user_guia.Location = new System.Drawing.Point(59, 7);
            this.M_name_user_guia.Name = "M_name_user_guia";
            this.M_name_user_guia.Size = new System.Drawing.Size(137, 40);
            this.M_name_user_guia.TabIndex = 10;
            this.M_name_user_guia.Text = "Medico:";
            // 
            // SendLogin
            // 
            this.SendLogin.BackColor = System.Drawing.Color.Coral;
            this.SendLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SendLogin.Location = new System.Drawing.Point(609, 6);
            this.SendLogin.Name = "SendLogin";
            this.SendLogin.Size = new System.Drawing.Size(178, 41);
            this.SendLogin.TabIndex = 20;
            this.SendLogin.Text = "Cerrar Sesion";
            this.SendLogin.UseVisualStyleBackColor = false;
            this.SendLogin.Click += new System.EventHandler(this.SendLogin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.M_MyInfo_last_name);
            this.panel3.Controls.Add(this.return_start_M);
            this.panel3.Controls.Add(this.M_MyInfo_departure_time);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.M_MyInfo_entry_time);
            this.panel3.Controls.Add(this.M_MyInfo_lastName);
            this.panel3.Controls.Add(this.M_MyInfo_social_works);
            this.panel3.Controls.Add(this.email);
            this.panel3.Controls.Add(this.M_MyInfo_email);
            this.panel3.Controls.Add(this.M_MyInfo_socialWorck);
            this.panel3.Controls.Add(this.M_MyInfo_age);
            this.panel3.Controls.Add(this.dni);
            this.panel3.Controls.Add(this.age);
            this.panel3.Controls.Add(this.M_MyInfo_consult_price);
            this.panel3.Controls.Add(this.phone);
            this.panel3.Controls.Add(this.M_MyInfo_name);
            this.panel3.Controls.Add(this.office);
            this.panel3.Controls.Add(this.M_MyInfo_office);
            this.panel3.Controls.Add(this.speciality);
            this.panel3.Controls.Add(this.M_MyInfo_speciality);
            this.panel3.Controls.Add(this.consult_amount);
            this.panel3.Controls.Add(this.M_MyInfo_phone);
            this.panel3.Controls.Add(this.M_MyInfo_ChekInTime);
            this.panel3.Controls.Add(this.M_MyInfo_dni);
            this.panel3.Controls.Add(this.M_MyInfo_ChekOutTime);
            this.panel3.Location = new System.Drawing.Point(57, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 404);
            this.panel3.TabIndex = 31;
            // 
            // return_start_M
            // 
            this.return_start_M.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_M.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.return_start_M.Location = new System.Drawing.Point(79, 350);
            this.return_start_M.Name = "return_start_M";
            this.return_start_M.Size = new System.Drawing.Size(178, 41);
            this.return_start_M.TabIndex = 2;
            this.return_start_M.Text = "Volver";
            this.return_start_M.UseVisualStyleBackColor = false;
            this.return_start_M.Click += new System.EventHandler(this.return_start_M_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(91, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(76, 19);
            this.name.TabIndex = 4;
            this.name.Text = "Nombre:";
            this.name.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // M_MyInfo_lastName
            // 
            this.M_MyInfo_lastName.AutoSize = true;
            this.M_MyInfo_lastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_MyInfo_lastName.Location = new System.Drawing.Point(285, 33);
            this.M_MyInfo_lastName.Name = "M_MyInfo_lastName";
            this.M_MyInfo_lastName.Size = new System.Drawing.Size(77, 19);
            this.M_MyInfo_lastName.TabIndex = 5;
            this.M_MyInfo_lastName.Text = "Apellido:";
            this.M_MyInfo_lastName.Click += new System.EventHandler(this.M_MyInfo_lastName_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(474, 95);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 19);
            this.email.TabIndex = 6;
            this.email.Text = "Email:";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // M_MyInfo_socialWorck
            // 
            this.M_MyInfo_socialWorck.AutoSize = true;
            this.M_MyInfo_socialWorck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_MyInfo_socialWorck.Location = new System.Drawing.Point(91, 219);
            this.M_MyInfo_socialWorck.Name = "M_MyInfo_socialWorck";
            this.M_MyInfo_socialWorck.Size = new System.Drawing.Size(130, 19);
            this.M_MyInfo_socialWorck.TabIndex = 7;
            this.M_MyInfo_socialWorck.Text = "Obras Sociales:";
            this.M_MyInfo_socialWorck.Click += new System.EventHandler(this.label3_Click);
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.Location = new System.Drawing.Point(91, 95);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(43, 19);
            this.dni.TabIndex = 8;
            this.dni.Text = "DNI:";
            this.dni.Click += new System.EventHandler(this.dni_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(474, 33);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(55, 19);
            this.age.TabIndex = 9;
            this.age.Text = "Edad:";
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(285, 95);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(80, 19);
            this.phone.TabIndex = 10;
            this.phone.Text = "Telefeno:";
            this.phone.Click += new System.EventHandler(this.phone_Click);
            // 
            // office
            // 
            this.office.AutoSize = true;
            this.office.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.office.Location = new System.Drawing.Point(285, 156);
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(105, 19);
            this.office.TabIndex = 11;
            this.office.Text = "Consultorio:";
            this.office.Click += new System.EventHandler(this.M_MyInfo_office_Click);
            // 
            // speciality
            // 
            this.speciality.AutoSize = true;
            this.speciality.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciality.Location = new System.Drawing.Point(91, 156);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(113, 19);
            this.speciality.TabIndex = 12;
            this.speciality.Text = "Especialidad:";
            this.speciality.Click += new System.EventHandler(this.label8_Click);
            // 
            // consult_amount
            // 
            this.consult_amount.AutoSize = true;
            this.consult_amount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consult_amount.Location = new System.Drawing.Point(474, 156);
            this.consult_amount.Name = "consult_amount";
            this.consult_amount.Size = new System.Drawing.Size(166, 19);
            this.consult_amount.TabIndex = 13;
            this.consult_amount.Text = "Cobro por Consulta:";
            this.consult_amount.Click += new System.EventHandler(this.consult_amount_Click);
            // 
            // M_MyInfo_ChekInTime
            // 
            this.M_MyInfo_ChekInTime.AutoSize = true;
            this.M_MyInfo_ChekInTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_MyInfo_ChekInTime.Location = new System.Drawing.Point(91, 281);
            this.M_MyInfo_ChekInTime.Name = "M_MyInfo_ChekInTime";
            this.M_MyInfo_ChekInTime.Size = new System.Drawing.Size(159, 19);
            this.M_MyInfo_ChekInTime.TabIndex = 14;
            this.M_MyInfo_ChekInTime.Text = "Horario de Entrada:";
            this.M_MyInfo_ChekInTime.Click += new System.EventHandler(this.label11_Click);
            // 
            // M_MyInfo_ChekOutTime
            // 
            this.M_MyInfo_ChekOutTime.AutoSize = true;
            this.M_MyInfo_ChekOutTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_MyInfo_ChekOutTime.Location = new System.Drawing.Point(285, 281);
            this.M_MyInfo_ChekOutTime.Name = "M_MyInfo_ChekOutTime";
            this.M_MyInfo_ChekOutTime.Size = new System.Drawing.Size(146, 19);
            this.M_MyInfo_ChekOutTime.TabIndex = 15;
            this.M_MyInfo_ChekOutTime.Text = "Horario de Salida:";
            this.M_MyInfo_ChekOutTime.Click += new System.EventHandler(this.M_MyInfo_ChekOutTime_Click);
            // 
            // M_MyInfo_dni
            // 
            this.M_MyInfo_dni.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_dni.Location = new System.Drawing.Point(95, 117);
            this.M_MyInfo_dni.Name = "M_MyInfo_dni";
            this.M_MyInfo_dni.ReadOnly = true;
            this.M_MyInfo_dni.Size = new System.Drawing.Size(162, 21);
            this.M_MyInfo_dni.TabIndex = 17;
            this.M_MyInfo_dni.TextChanged += new System.EventHandler(this.M_MyInfo_dni_TextChanged_1);
            // 
            // M_MyInfo_phone
            // 
            this.M_MyInfo_phone.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_phone.Location = new System.Drawing.Point(289, 117);
            this.M_MyInfo_phone.Name = "M_MyInfo_phone";
            this.M_MyInfo_phone.ReadOnly = true;
            this.M_MyInfo_phone.Size = new System.Drawing.Size(162, 21);
            this.M_MyInfo_phone.TabIndex = 18;
            this.M_MyInfo_phone.TextChanged += new System.EventHandler(this.M_MyInfo_phone_TextChanged_1);
            // 
            // M_MyInfo_speciality
            // 
            this.M_MyInfo_speciality.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_speciality.Location = new System.Drawing.Point(95, 178);
            this.M_MyInfo_speciality.Name = "M_MyInfo_speciality";
            this.M_MyInfo_speciality.ReadOnly = true;
            this.M_MyInfo_speciality.Size = new System.Drawing.Size(162, 21);
            this.M_MyInfo_speciality.TabIndex = 19;
            this.M_MyInfo_speciality.TextChanged += new System.EventHandler(this.M_MyInfo_speciality_TextChanged_1);
            // 
            // M_MyInfo_office
            // 
            this.M_MyInfo_office.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_office.Location = new System.Drawing.Point(289, 178);
            this.M_MyInfo_office.Name = "M_MyInfo_office";
            this.M_MyInfo_office.ReadOnly = true;
            this.M_MyInfo_office.Size = new System.Drawing.Size(162, 21);
            this.M_MyInfo_office.TabIndex = 20;
            this.M_MyInfo_office.TextChanged += new System.EventHandler(this.M_MyInfo_office_TextChanged_1);
            // 
            // M_MyInfo_name
            // 
            this.M_MyInfo_name.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_name.Location = new System.Drawing.Point(95, 55);
            this.M_MyInfo_name.Name = "M_MyInfo_name";
            this.M_MyInfo_name.ReadOnly = true;
            this.M_MyInfo_name.Size = new System.Drawing.Size(162, 21);
            this.M_MyInfo_name.TabIndex = 21;
            this.M_MyInfo_name.TextChanged += new System.EventHandler(this.M_MyInfo_name_TextChanged);
            // 
            // M_MyInfo_consult_price
            // 
            this.M_MyInfo_consult_price.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_consult_price.Location = new System.Drawing.Point(478, 178);
            this.M_MyInfo_consult_price.Name = "M_MyInfo_consult_price";
            this.M_MyInfo_consult_price.ReadOnly = true;
            this.M_MyInfo_consult_price.Size = new System.Drawing.Size(162, 21);
            this.M_MyInfo_consult_price.TabIndex = 22;
            this.M_MyInfo_consult_price.TextChanged += new System.EventHandler(this.M_MyInfo_consult_price_TextChanged);
            // 
            // M_MyInfo_last_name
            // 
            this.M_MyInfo_last_name.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_last_name.Location = new System.Drawing.Point(289, 55);
            this.M_MyInfo_last_name.Name = "M_MyInfo_last_name";
            this.M_MyInfo_last_name.ReadOnly = true;
            this.M_MyInfo_last_name.Size = new System.Drawing.Size(162, 21);
            this.M_MyInfo_last_name.TabIndex = 23;
            this.M_MyInfo_last_name.TextChanged += new System.EventHandler(this.M_MyInfo_last_name_TextChanged);
            // 
            // M_MyInfo_age
            // 
            this.M_MyInfo_age.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_age.Location = new System.Drawing.Point(478, 55);
            this.M_MyInfo_age.Name = "M_MyInfo_age";
            this.M_MyInfo_age.ReadOnly = true;
            this.M_MyInfo_age.Size = new System.Drawing.Size(162, 21);
            this.M_MyInfo_age.TabIndex = 24;
            this.M_MyInfo_age.TextChanged += new System.EventHandler(this.M_MyInfo_age_TextChanged);
            // 
            // M_MyInfo_email
            // 
            this.M_MyInfo_email.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_email.Location = new System.Drawing.Point(478, 117);
            this.M_MyInfo_email.Name = "M_MyInfo_email";
            this.M_MyInfo_email.ReadOnly = true;
            this.M_MyInfo_email.Size = new System.Drawing.Size(162, 21);
            this.M_MyInfo_email.TabIndex = 25;
            this.M_MyInfo_email.TextChanged += new System.EventHandler(this.M_MyInfo_email_TextChanged);
            // 
            // M_MyInfo_social_works
            // 
            this.M_MyInfo_social_works.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_social_works.Location = new System.Drawing.Point(95, 241);
            this.M_MyInfo_social_works.Name = "M_MyInfo_social_works";
            this.M_MyInfo_social_works.ReadOnly = true;
            this.M_MyInfo_social_works.Size = new System.Drawing.Size(356, 21);
            this.M_MyInfo_social_works.TabIndex = 26;
            this.M_MyInfo_social_works.TextChanged += new System.EventHandler(this.M_MyInfo_social_works_TextChanged);
            // 
            // M_MyInfo_entry_time
            // 
            this.M_MyInfo_entry_time.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_entry_time.Location = new System.Drawing.Point(95, 309);
            this.M_MyInfo_entry_time.Name = "M_MyInfo_entry_time";
            this.M_MyInfo_entry_time.ReadOnly = true;
            this.M_MyInfo_entry_time.Size = new System.Drawing.Size(133, 21);
            this.M_MyInfo_entry_time.TabIndex = 27;
            this.M_MyInfo_entry_time.TextChanged += new System.EventHandler(this.M_MyInfo_entry_time_TextChanged);
            // 
            // M_MyInfo_departure_time
            // 
            this.M_MyInfo_departure_time.Font = new System.Drawing.Font("Arial", 9F);
            this.M_MyInfo_departure_time.Location = new System.Drawing.Point(289, 309);
            this.M_MyInfo_departure_time.Name = "M_MyInfo_departure_time";
            this.M_MyInfo_departure_time.ReadOnly = true;
            this.M_MyInfo_departure_time.Size = new System.Drawing.Size(133, 21);
            this.M_MyInfo_departure_time.TabIndex = 28;
            this.M_MyInfo_departure_time.TextChanged += new System.EventHandler(this.M_MyInfo_departure_time_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(57, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 71);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(194, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mi información";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // M_MyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "M_MyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Informacion";
            this.Load += new System.EventHandler(this.M_MyInfo_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label M_name_user_guia;
        private System.Windows.Forms.Button SendLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button return_start_M;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label M_MyInfo_lastName;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label M_MyInfo_socialWorck;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label office;
        private System.Windows.Forms.Label speciality;
        private System.Windows.Forms.Label consult_amount;
        private System.Windows.Forms.Label M_MyInfo_ChekInTime;
        private System.Windows.Forms.Label M_MyInfo_ChekOutTime;
        private System.Windows.Forms.TextBox M_MyInfo_dni;
        private System.Windows.Forms.TextBox M_MyInfo_phone;
        private System.Windows.Forms.TextBox M_MyInfo_speciality;
        private System.Windows.Forms.TextBox M_MyInfo_office;
        private System.Windows.Forms.TextBox M_MyInfo_name;
        private System.Windows.Forms.TextBox M_MyInfo_consult_price;
        private System.Windows.Forms.TextBox M_MyInfo_last_name;
        private System.Windows.Forms.TextBox M_MyInfo_age;
        private System.Windows.Forms.TextBox M_MyInfo_email;
        private System.Windows.Forms.TextBox M_MyInfo_social_works;
        private System.Windows.Forms.TextBox M_MyInfo_entry_time;
        private System.Windows.Forms.TextBox M_MyInfo_departure_time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}