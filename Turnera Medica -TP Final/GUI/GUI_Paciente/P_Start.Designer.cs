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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Start));
            this.GetShifts = new System.Windows.Forms.Button();
            this.SendLogin = new System.Windows.Forms.Button();
            this.GetInfo = new System.Windows.Forms.Button();
            this.GetShift = new System.Windows.Forms.Button();
            this.RequestAppointment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P_name_user_guia = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetShifts
            // 
            this.GetShifts.BackColor = System.Drawing.SystemColors.Control;
            this.GetShifts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetShifts.Location = new System.Drawing.Point(55, 34);
            this.GetShifts.Name = "GetShifts";
            this.GetShifts.Size = new System.Drawing.Size(178, 41);
            this.GetShifts.TabIndex = 16;
            this.GetShifts.Text = "Turnos";
            this.GetShifts.UseVisualStyleBackColor = false;
            this.GetShifts.Click += new System.EventHandler(this.GetShifts_Click);
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
            // GetInfo
            // 
            this.GetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.GetInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetInfo.Location = new System.Drawing.Point(322, 34);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(178, 41);
            this.GetInfo.TabIndex = 25;
            this.GetInfo.Text = "Mi Información";
            this.GetInfo.UseVisualStyleBackColor = false;
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // GetShift
            // 
            this.GetShift.BackColor = System.Drawing.SystemColors.Control;
            this.GetShift.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetShift.Location = new System.Drawing.Point(55, 134);
            this.GetShift.Name = "GetShift";
            this.GetShift.Size = new System.Drawing.Size(178, 41);
            this.GetShift.TabIndex = 26;
            this.GetShift.Text = "Turno Especifco";
            this.GetShift.UseVisualStyleBackColor = false;
            this.GetShift.Click += new System.EventHandler(this.GetShift_Click);
            // 
            // RequestAppointment
            // 
            this.RequestAppointment.BackColor = System.Drawing.SystemColors.Control;
            this.RequestAppointment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.RequestAppointment.Location = new System.Drawing.Point(322, 134);
            this.RequestAppointment.Name = "RequestAppointment";
            this.RequestAppointment.Size = new System.Drawing.Size(178, 41);
            this.RequestAppointment.TabIndex = 27;
            this.RequestAppointment.Text = "Solicitar Turno";
            this.RequestAppointment.UseVisualStyleBackColor = false;
            this.RequestAppointment.Click += new System.EventHandler(this.RequestAppointment_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.P_name_user_guia);
            this.panel1.Controls.Add(this.SendLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 57);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.P_name_user_guia.Size = new System.Drawing.Size(87, 40);
            this.P_name_user_guia.TabIndex = 10;
            this.P_name_user_guia.Text = "Hola";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(126, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 71);
            this.panel2.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(114, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "Menú Principal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.GetShift);
            this.panel3.Controls.Add(this.GetShifts);
            this.panel3.Controls.Add(this.RequestAppointment);
            this.panel3.Controls.Add(this.GetInfo);
            this.panel3.Location = new System.Drawing.Point(126, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 213);
            this.panel3.TabIndex = 31;
            // 
            // P_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Paciente";
            this.Load += new System.EventHandler(this.P_Start_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GetShifts;
        private System.Windows.Forms.Button SendLogin;
        private System.Windows.Forms.Button GetInfo;
        private System.Windows.Forms.Button GetShift;
        private System.Windows.Forms.Button RequestAppointment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label P_name_user_guia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}