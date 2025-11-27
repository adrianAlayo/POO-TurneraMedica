namespace Turnera_Medica__TP_Final.GUI
{
    partial class PreRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreRegister));
            this.medico_option_user = new System.Windows.Forms.Button();
            this.paciente_option_user = new System.Windows.Forms.Button();
            this.ReturnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // medico_option_user
            // 
            this.medico_option_user.BackColor = System.Drawing.SystemColors.Control;
            this.medico_option_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medico_option_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.medico_option_user.FlatAppearance.BorderSize = 10;
            this.medico_option_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.medico_option_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.medico_option_user.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.medico_option_user.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medico_option_user.Location = new System.Drawing.Point(89, 93);
            this.medico_option_user.Name = "medico_option_user";
            this.medico_option_user.Size = new System.Drawing.Size(178, 41);
            this.medico_option_user.TabIndex = 1;
            this.medico_option_user.Text = "Medico";
            this.medico_option_user.UseVisualStyleBackColor = false;
            this.medico_option_user.Click += new System.EventHandler(this.Medico_option_user_Click);
            // 
            // paciente_option_user
            // 
            this.paciente_option_user.BackColor = System.Drawing.SystemColors.Control;
            this.paciente_option_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paciente_option_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.paciente_option_user.FlatAppearance.BorderSize = 10;
            this.paciente_option_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.paciente_option_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.paciente_option_user.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paciente_option_user.Location = new System.Drawing.Point(89, 163);
            this.paciente_option_user.Name = "paciente_option_user";
            this.paciente_option_user.Size = new System.Drawing.Size(178, 41);
            this.paciente_option_user.TabIndex = 2;
            this.paciente_option_user.Text = "Paciente";
            this.paciente_option_user.UseVisualStyleBackColor = false;
            this.paciente_option_user.Click += new System.EventHandler(this.paciente_option_user_Click);
            // 
            // ReturnLogin
            // 
            this.ReturnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReturnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReturnLogin.FlatAppearance.BorderSize = 10;
            this.ReturnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.ReturnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ReturnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLogin.Location = new System.Drawing.Point(89, 276);
            this.ReturnLogin.Name = "ReturnLogin";
            this.ReturnLogin.Size = new System.Drawing.Size(178, 41);
            this.ReturnLogin.TabIndex = 4;
            this.ReturnLogin.Text = "Volver";
            this.ReturnLogin.UseVisualStyleBackColor = false;
            this.ReturnLogin.Click += new System.EventHandler(this.ReturnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 52);
            this.label2.TabIndex = 10;
            this.label2.Text = "Consultoría Médica";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 74);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.medico_option_user);
            this.panel2.Controls.Add(this.ReturnLogin);
            this.panel2.Controls.Add(this.paciente_option_user);
            this.panel2.Location = new System.Drawing.Point(251, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 329);
            this.panel2.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(124, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Elegir Rol";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 51);
            this.panel3.TabIndex = 15;
            // 
            // PreRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.PreRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button medico_option_user;
        private System.Windows.Forms.Button paciente_option_user;
        private System.Windows.Forms.Button ReturnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitulo;
    }
}