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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update_email_user = new System.Windows.Forms.TextBox();
            this.update_newPass_user = new System.Windows.Forms.TextBox();
            this.update_confirmPass_user = new System.Windows.Forms.TextBox();
            this.update_password = new System.Windows.Forms.Button();
            this.return_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo Electronico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 52);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cambiar Contraseña";
            // 
            // update_email_user
            // 
            this.update_email_user.BackColor = System.Drawing.Color.LightPink;
            this.update_email_user.Location = new System.Drawing.Point(228, 164);
            this.update_email_user.Name = "update_email_user";
            this.update_email_user.Size = new System.Drawing.Size(245, 20);
            this.update_email_user.TabIndex = 5;
            this.update_email_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // update_newPass_user
            // 
            this.update_newPass_user.BackColor = System.Drawing.Color.LightPink;
            this.update_newPass_user.Location = new System.Drawing.Point(228, 201);
            this.update_newPass_user.Name = "update_newPass_user";
            this.update_newPass_user.Size = new System.Drawing.Size(245, 20);
            this.update_newPass_user.TabIndex = 6;
            this.update_newPass_user.UseSystemPasswordChar = true;
            this.update_newPass_user.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // update_confirmPass_user
            // 
            this.update_confirmPass_user.BackColor = System.Drawing.Color.LightPink;
            this.update_confirmPass_user.Location = new System.Drawing.Point(228, 238);
            this.update_confirmPass_user.Name = "update_confirmPass_user";
            this.update_confirmPass_user.Size = new System.Drawing.Size(245, 20);
            this.update_confirmPass_user.TabIndex = 7;
            this.update_confirmPass_user.UseSystemPasswordChar = true;
            this.update_confirmPass_user.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // update_password
            // 
            this.update_password.BackColor = System.Drawing.Color.LightGreen;
            this.update_password.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_password.Location = new System.Drawing.Point(228, 284);
            this.update_password.Name = "update_password";
            this.update_password.Size = new System.Drawing.Size(245, 40);
            this.update_password.TabIndex = 10;
            this.update_password.Text = "Cambiar Contraseña";
            this.update_password.UseVisualStyleBackColor = false;
            this.update_password.Click += new System.EventHandler(this.update_password_Click);
            // 
            // return_login
            // 
            this.return_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_login.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_login.Location = new System.Drawing.Point(40, 308);
            this.return_login.Name = "return_login";
            this.return_login.Size = new System.Drawing.Size(100, 40);
            this.return_login.TabIndex = 11;
            this.return_login.Text = "Volver";
            this.return_login.UseVisualStyleBackColor = false;
            this.return_login.Click += new System.EventHandler(this.return_login_Click);
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 380);
            this.Controls.Add(this.return_login);
            this.Controls.Add(this.update_password);
            this.Controls.Add(this.update_confirmPass_user);
            this.Controls.Add(this.update_newPass_user);
            this.Controls.Add(this.update_email_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            this.Load += new System.EventHandler(this.UpdatePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox update_email_user;
        private System.Windows.Forms.TextBox update_newPass_user;
        private System.Windows.Forms.TextBox update_confirmPass_user;
        private System.Windows.Forms.Button update_password;
        private System.Windows.Forms.Button return_login;
    }
}