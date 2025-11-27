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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Start));
            this.GetShifts = new System.Windows.Forms.Button();
            this.GetShift = new System.Windows.Forms.Button();
            this.GetSocialWork = new System.Windows.Forms.Button();
            this.GetInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.M_name_user_guia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetShifts
            // 
            this.GetShifts.BackColor = System.Drawing.SystemColors.Control;
            this.GetShifts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetShifts.Location = new System.Drawing.Point(55, 34);
            this.GetShifts.Name = "GetShifts";
            this.GetShifts.Size = new System.Drawing.Size(178, 41);
            this.GetShifts.TabIndex = 9;
            this.GetShifts.Text = "Turnos";
            this.GetShifts.UseVisualStyleBackColor = false;
            this.GetShifts.Click += new System.EventHandler(this.GetShifts_Click);
            // 
            // GetShift
            // 
            this.GetShift.BackColor = System.Drawing.SystemColors.Control;
            this.GetShift.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetShift.Location = new System.Drawing.Point(55, 134);
            this.GetShift.Name = "GetShift";
            this.GetShift.Size = new System.Drawing.Size(178, 41);
            this.GetShift.TabIndex = 11;
            this.GetShift.Text = "Turno Especifico";
            this.GetShift.UseVisualStyleBackColor = false;
            this.GetShift.Click += new System.EventHandler(this.GetShift_Click);
            // 
            // GetSocialWork
            // 
            this.GetSocialWork.BackColor = System.Drawing.SystemColors.Control;
            this.GetSocialWork.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetSocialWork.Location = new System.Drawing.Point(322, 134);
            this.GetSocialWork.Name = "GetSocialWork";
            this.GetSocialWork.Size = new System.Drawing.Size(178, 41);
            this.GetSocialWork.TabIndex = 12;
            this.GetSocialWork.Text = "Añadir Obra Social";
            this.GetSocialWork.UseVisualStyleBackColor = false;
            this.GetSocialWork.Click += new System.EventHandler(this.GetSocialWork_Click);
            // 
            // GetInfo
            // 
            this.GetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.GetInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.GetInfo.Location = new System.Drawing.Point(346, 34);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(178, 41);
            this.GetInfo.TabIndex = 10;
            this.GetInfo.Text = "Mi Informacion";
            this.GetInfo.UseVisualStyleBackColor = false;
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.M_name_user_guia);
            this.panel1.Controls.Add(this.button1);
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
            this.M_name_user_guia.Size = new System.Drawing.Size(87, 40);
            this.M_name_user_guia.TabIndex = 10;
            this.M_name_user_guia.Text = "Hola";
            this.M_name_user_guia.Click += new System.EventHandler(this.P_name_user_guia_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(609, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.GetShifts);
            this.panel3.Controls.Add(this.GetShift);
            this.panel3.Controls.Add(this.GetSocialWork);
            this.panel3.Controls.Add(this.GetInfo);
            this.panel3.Location = new System.Drawing.Point(126, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 213);
            this.panel3.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(126, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 71);
            this.panel2.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(124, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "Menú Principal";
            // 
            // M_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "M_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Medico";
            this.Load += new System.EventHandler(this.M_Start_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetShifts;
        private System.Windows.Forms.Button GetShift;
        private System.Windows.Forms.Button GetSocialWork;
        private System.Windows.Forms.Button GetInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label M_name_user_guia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}