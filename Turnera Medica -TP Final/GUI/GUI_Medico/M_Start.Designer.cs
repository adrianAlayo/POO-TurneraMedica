namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    partial class M_Start
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
            this.GetShifts = new System.Windows.Forms.Button();
            this.GetShift = new System.Windows.Forms.Button();
            this.GetSocialWork = new System.Windows.Forms.Button();
            this.SendLogin = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetShifts
            // 
            this.GetShifts.BackColor = System.Drawing.SystemColors.Control;
            this.GetShifts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetShifts.Location = new System.Drawing.Point(188, 151);
            this.GetShifts.Name = "GetShifts";
            this.GetShifts.Size = new System.Drawing.Size(91, 40);
            this.GetShifts.TabIndex = 9;
            this.GetShifts.Text = "Ver";
            this.GetShifts.UseVisualStyleBackColor = false;
            this.GetShifts.Click += new System.EventHandler(this.GetShifts_Click);
            // 
            // GetShift
            // 
            this.GetShift.BackColor = System.Drawing.SystemColors.Control;
            this.GetShift.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetShift.Location = new System.Drawing.Point(188, 302);
            this.GetShift.Name = "GetShift";
            this.GetShift.Size = new System.Drawing.Size(91, 40);
            this.GetShift.TabIndex = 11;
            this.GetShift.Text = "Ver";
            this.GetShift.UseVisualStyleBackColor = false;
            this.GetShift.Click += new System.EventHandler(this.GetShift_Click);
            // 
            // GetSocialWork
            // 
            this.GetSocialWork.BackColor = System.Drawing.SystemColors.Control;
            this.GetSocialWork.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetSocialWork.Location = new System.Drawing.Point(507, 302);
            this.GetSocialWork.Name = "GetSocialWork";
            this.GetSocialWork.Size = new System.Drawing.Size(91, 40);
            this.GetSocialWork.TabIndex = 12;
            this.GetSocialWork.Text = "Ver";
            this.GetSocialWork.UseVisualStyleBackColor = false;
            this.GetSocialWork.Click += new System.EventHandler(this.GetSocialWork_Click);
            // 
            // SendLogin
            // 
            this.SendLogin.BackColor = System.Drawing.Color.Coral;
            this.SendLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SendLogin.Location = new System.Drawing.Point(329, 375);
            this.SendLogin.Name = "SendLogin";
            this.SendLogin.Size = new System.Drawing.Size(140, 35);
            this.SendLogin.TabIndex = 13;
            this.SendLogin.Text = "Cerrar Sesion";
            this.SendLogin.UseVisualStyleBackColor = false;
            this.SendLogin.Click += new System.EventHandler(this.SendLogin_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(252, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(291, 52);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Menú Medico";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(152, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(167, 19);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Ver todos los Turnos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(152, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ver Turno especifico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(491, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mi Informacion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(477, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Añadir obra social";
            // 
            // GetInfo
            // 
            this.GetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.GetInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetInfo.Location = new System.Drawing.Point(507, 151);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(91, 40);
            this.GetInfo.TabIndex = 10;
            this.GetInfo.Text = "Ver";
            this.GetInfo.UseVisualStyleBackColor = false;
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // M_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.SendLogin);
            this.Controls.Add(this.GetSocialWork);
            this.Controls.Add(this.GetShift);
            this.Controls.Add(this.GetInfo);
            this.Controls.Add(this.GetShifts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "M_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Medico";
            this.Load += new System.EventHandler(this.M_Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetShifts;
        private System.Windows.Forms.Button GetShift;
        private System.Windows.Forms.Button GetSocialWork;
        private System.Windows.Forms.Button SendLogin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetInfo;
    }
}