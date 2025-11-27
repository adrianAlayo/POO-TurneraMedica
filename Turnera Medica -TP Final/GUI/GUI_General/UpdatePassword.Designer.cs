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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.return_login = new System.Windows.Forms.Button();
            this.update_password = new System.Windows.Forms.Button();
            this.update_confirmPass_user = new System.Windows.Forms.TextBox();
            this.update_newPass_user = new System.Windows.Forms.TextBox();
            this.update_email_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Location = new System.Drawing.Point(117, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 51);
            this.panel3.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(116, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cambiar Contraseña";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.return_login);
            this.panel2.Controls.Add(this.update_password);
            this.panel2.Controls.Add(this.update_confirmPass_user);
            this.panel2.Controls.Add(this.update_newPass_user);
            this.panel2.Controls.Add(this.update_email_user);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(117, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 339);
            this.panel2.TabIndex = 14;
            // 
            // return_login
            // 
            this.return_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.return_login.Location = new System.Drawing.Point(29, 272);
            this.return_login.Name = "return_login";
            this.return_login.Size = new System.Drawing.Size(178, 41);
            this.return_login.TabIndex = 19;
            this.return_login.Text = "Volver";
            this.return_login.UseVisualStyleBackColor = false;
            // 
            // update_password
            // 
            this.update_password.BackColor = System.Drawing.Color.LightGreen;
            this.update_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_password.Location = new System.Drawing.Point(289, 272);
            this.update_password.Name = "update_password";
            this.update_password.Size = new System.Drawing.Size(178, 41);
            this.update_password.TabIndex = 18;
            this.update_password.Text = "Cambiar Contraseña";
            this.update_password.UseVisualStyleBackColor = false;
            // 
            // update_confirmPass_user
            // 
            this.update_confirmPass_user.BackColor = System.Drawing.SystemColors.Control;
            this.update_confirmPass_user.Font = new System.Drawing.Font("Arial", 9F);
            this.update_confirmPass_user.Location = new System.Drawing.Point(259, 146);
            this.update_confirmPass_user.Name = "update_confirmPass_user";
            this.update_confirmPass_user.Size = new System.Drawing.Size(208, 21);
            this.update_confirmPass_user.TabIndex = 17;
            this.update_confirmPass_user.UseSystemPasswordChar = true;
            // 
            // update_newPass_user
            // 
            this.update_newPass_user.BackColor = System.Drawing.SystemColors.Control;
            this.update_newPass_user.Font = new System.Drawing.Font("Arial", 9F);
            this.update_newPass_user.Location = new System.Drawing.Point(29, 146);
            this.update_newPass_user.Name = "update_newPass_user";
            this.update_newPass_user.Size = new System.Drawing.Size(208, 21);
            this.update_newPass_user.TabIndex = 16;
            this.update_newPass_user.UseSystemPasswordChar = true;
            // 
            // update_email_user
            // 
            this.update_email_user.BackColor = System.Drawing.SystemColors.Control;
            this.update_email_user.Font = new System.Drawing.Font("Arial", 9F);
            this.update_email_user.Location = new System.Drawing.Point(29, 87);
            this.update_email_user.Name = "update_email_user";
            this.update_email_user.Size = new System.Drawing.Size(208, 21);
            this.update_email_user.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(255, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Correo Electronico:";
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(710, 380);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button return_login;
        private System.Windows.Forms.Button update_password;
        private System.Windows.Forms.TextBox update_confirmPass_user;
        private System.Windows.Forms.TextBox update_newPass_user;
        private System.Windows.Forms.TextBox update_email_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}