namespace Turnera_Medica__TP_Final.GUI
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.update_confirmPass_user = new System.Windows.Forms.TextBox();
            this.update_newPass_user = new System.Windows.Forms.TextBox();
            this.update_email_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.return_login = new System.Windows.Forms.Button();
            this.update_password = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Location = new System.Drawing.Point(140, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 51);
            this.panel3.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(128, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cambiar Contraseña";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.update_confirmPass_user);
            this.panel2.Controls.Add(this.update_newPass_user);
            this.panel2.Controls.Add(this.update_email_user);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.return_login);
            this.panel2.Controls.Add(this.update_password);
            this.panel2.Location = new System.Drawing.Point(140, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 312);
            this.panel2.TabIndex = 14;
            // 
            // update_confirmPass_user
            // 
            this.update_confirmPass_user.BackColor = System.Drawing.SystemColors.Control;
            this.update_confirmPass_user.Font = new System.Drawing.Font("Arial", 9F);
            this.update_confirmPass_user.Location = new System.Drawing.Point(256, 155);
            this.update_confirmPass_user.Name = "update_confirmPass_user";
            this.update_confirmPass_user.Size = new System.Drawing.Size(208, 21);
            this.update_confirmPass_user.TabIndex = 19;
            this.update_confirmPass_user.UseSystemPasswordChar = true;
            this.update_confirmPass_user.TextChanged += new System.EventHandler(this.update_confirmPass_user_TextChanged);
            this.update_confirmPass_user.DoubleClick += new System.EventHandler(this.update_confirmPass_user_DoubleClick_1);
            // 
            // update_newPass_user
            // 
            this.update_newPass_user.BackColor = System.Drawing.SystemColors.Control;
            this.update_newPass_user.Font = new System.Drawing.Font("Arial", 9F);
            this.update_newPass_user.Location = new System.Drawing.Point(18, 155);
            this.update_newPass_user.Name = "update_newPass_user";
            this.update_newPass_user.Size = new System.Drawing.Size(208, 21);
            this.update_newPass_user.TabIndex = 18;
            this.update_newPass_user.UseSystemPasswordChar = true;
            this.update_newPass_user.TextChanged += new System.EventHandler(this.update_newPass_user_TextChanged);
            this.update_newPass_user.DoubleClick += new System.EventHandler(this.update_newPass_user_DoubleClick_1);
            // 
            // update_email_user
            // 
            this.update_email_user.BackColor = System.Drawing.SystemColors.Control;
            this.update_email_user.Font = new System.Drawing.Font("Arial", 9F);
            this.update_email_user.Location = new System.Drawing.Point(17, 91);
            this.update_email_user.Name = "update_email_user";
            this.update_email_user.Size = new System.Drawing.Size(208, 21);
            this.update_email_user.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(252, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Correo Electronico:";
            // 
            // return_login
            // 
            this.return_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.return_login.Location = new System.Drawing.Point(20, 245);
            this.return_login.Name = "return_login";
            this.return_login.Size = new System.Drawing.Size(178, 41);
            this.return_login.TabIndex = 13;
            this.return_login.Text = "Volver";
            this.return_login.UseVisualStyleBackColor = false;
            this.return_login.Click += new System.EventHandler(this.return_login_Click_1);
            // 
            // update_password
            // 
            this.update_password.BackColor = System.Drawing.Color.LightGreen;
            this.update_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_password.Location = new System.Drawing.Point(286, 245);
            this.update_password.Name = "update_password";
            this.update_password.Size = new System.Drawing.Size(178, 41);
            this.update_password.TabIndex = 12;
            this.update_password.Text = "Cambiar Contraseña";
            this.update_password.UseVisualStyleBackColor = false;
            this.update_password.Click += new System.EventHandler(this.update_password_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(75, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(414, 52);
            this.label15.TabIndex = 10;
            this.label15.Text = "Consultoría Médica";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 72);
            this.panel1.TabIndex = 70;
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
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(773, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.UpdatePassword_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox update_confirmPass_user;
        private System.Windows.Forms.TextBox update_newPass_user;
        private System.Windows.Forms.TextBox update_email_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button return_login;
        private System.Windows.Forms.Button update_password;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}