namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    partial class P_Start
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
            this.GetShifts = new System.Windows.Forms.Button();
            this.SendLogin = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GetInfo = new System.Windows.Forms.Button();
            this.GetShift = new System.Windows.Forms.Button();
            this.RequestAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(233, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(323, 52);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Menú Paciente";
            // 
            // GetShifts
            // 
            this.GetShifts.BackColor = System.Drawing.SystemColors.Control;
            this.GetShifts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetShifts.Location = new System.Drawing.Point(182, 153);
            this.GetShifts.Name = "GetShifts";
            this.GetShifts.Size = new System.Drawing.Size(91, 40);
            this.GetShifts.TabIndex = 16;
            this.GetShifts.Text = "Ver";
            this.GetShifts.UseVisualStyleBackColor = false;
            this.GetShifts.Click += new System.EventHandler(this.GetShifts_Click);
            // 
            // SendLogin
            // 
            this.SendLogin.BackColor = System.Drawing.Color.Coral;
            this.SendLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SendLogin.Location = new System.Drawing.Point(326, 379);
            this.SendLogin.Name = "SendLogin";
            this.SendLogin.Size = new System.Drawing.Size(140, 35);
            this.SendLogin.TabIndex = 20;
            this.SendLogin.Text = "Cerrar Sesion";
            this.SendLogin.UseVisualStyleBackColor = false;
            this.SendLogin.Click += new System.EventHandler(this.SendLogin_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(143, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(167, 19);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Ver todos los Turnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(487, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mi Informacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(145, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ver Turno especifico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(487, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Solicitar Turno";
            // 
            // GetInfo
            // 
            this.GetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.GetInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetInfo.Location = new System.Drawing.Point(504, 153);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(91, 40);
            this.GetInfo.TabIndex = 25;
            this.GetInfo.Text = "Ver";
            this.GetInfo.UseVisualStyleBackColor = false;
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // GetShift
            // 
            this.GetShift.BackColor = System.Drawing.SystemColors.Control;
            this.GetShift.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetShift.Location = new System.Drawing.Point(182, 302);
            this.GetShift.Name = "GetShift";
            this.GetShift.Size = new System.Drawing.Size(91, 40);
            this.GetShift.TabIndex = 26;
            this.GetShift.Text = "Ver";
            this.GetShift.UseVisualStyleBackColor = false;
            this.GetShift.Click += new System.EventHandler(this.GetShift_Click);
            // 
            // RequestAppointment
            // 
            this.RequestAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.RequestAppointment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.RequestAppointment.Location = new System.Drawing.Point(504, 302);
            this.RequestAppointment.Name = "RequestAppointment";
            this.RequestAppointment.Size = new System.Drawing.Size(91, 40);
            this.RequestAppointment.TabIndex = 27;
            this.RequestAppointment.Text = "Ver";
            this.RequestAppointment.UseVisualStyleBackColor = false;
            this.RequestAppointment.Click += new System.EventHandler(this.RequestAppointment_Click);
            // 
            // P_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RequestAppointment);
            this.Controls.Add(this.GetShift);
            this.Controls.Add(this.GetInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.SendLogin);
            this.Controls.Add(this.GetShifts);
            this.Controls.Add(this.lblTitulo);
            this.Name = "P_Start";
            this.Text = "Menú Paciente";
            this.Load += new System.EventHandler(this.P_Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button GetShifts;
        private System.Windows.Forms.Button SendLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetInfo;
        private System.Windows.Forms.Button GetShift;
        private System.Windows.Forms.Button RequestAppointment;
    }
}