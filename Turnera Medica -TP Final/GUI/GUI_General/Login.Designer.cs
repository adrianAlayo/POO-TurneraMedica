namespace Turnera_Medica__TP_Final.GUI
{
    partial class Login
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.login_email_user = new System.Windows.Forms.TextBox();
            this.login_password_user = new System.Windows.Forms.TextBox();
            this.lnkOlvide = new System.Windows.Forms.LinkLabel();
            this.lnkRegistro = new System.Windows.Forms.LinkLabel();
            this.SendLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(313, 91);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(153, 52);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "LOGIN";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(251, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(231, 236);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña:";
            // 
            // login_email_user
            // 
            this.login_email_user.BackColor = System.Drawing.Color.LightPink;
            this.login_email_user.Location = new System.Drawing.Point(322, 186);
            this.login_email_user.Name = "login_email_user";
            this.login_email_user.Size = new System.Drawing.Size(149, 20);
            this.login_email_user.TabIndex = 4;
            this.login_email_user.TextChanged += new System.EventHandler(this.login_email_user_TextChanged);
            // 
            // login_password_user
            // 
            this.login_password_user.BackColor = System.Drawing.Color.LightPink;
            this.login_password_user.Location = new System.Drawing.Point(322, 231);
            this.login_password_user.Name = "login_password_user";
            this.login_password_user.Size = new System.Drawing.Size(149, 20);
            this.login_password_user.TabIndex = 5;
            this.login_password_user.UseSystemPasswordChar = true;
            this.login_password_user.TextChanged += new System.EventHandler(this.login_password_user_TextChanged);
            // 
            // lnkOlvide
            // 
            this.lnkOlvide.AutoSize = true;
            this.lnkOlvide.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkOlvide.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkOlvide.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnkOlvide.Location = new System.Drawing.Point(330, 344);
            this.lnkOlvide.Name = "lnkOlvide";
            this.lnkOlvide.Size = new System.Drawing.Size(141, 15);
            this.lnkOlvide.TabIndex = 6;
            this.lnkOlvide.TabStop = true;
            this.lnkOlvide.Text = "Me olvidé la contraseña";
            this.lnkOlvide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOlvide_LinkClicked);
            // 
            // lnkRegistro
            // 
            this.lnkRegistro.AutoSize = true;
            this.lnkRegistro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkRegistro.LinkColor = System.Drawing.Color.DarkBlue;
            this.lnkRegistro.Location = new System.Drawing.Point(484, 284);
            this.lnkRegistro.Name = "lnkRegistro";
            this.lnkRegistro.Size = new System.Drawing.Size(74, 15);
            this.lnkRegistro.TabIndex = 7;
            this.lnkRegistro.TabStop = true;
            this.lnkRegistro.Text = "Registrarse";
            this.lnkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegistro_LinkClicked);
            // 
            // SendLogin
            // 
            this.SendLogin.BackColor = System.Drawing.Color.LightGreen;
            this.SendLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendLogin.Location = new System.Drawing.Point(353, 284);
            this.SendLogin.Name = "SendLogin";
            this.SendLogin.Size = new System.Drawing.Size(91, 40);
            this.SendLogin.TabIndex = 8;
            this.SendLogin.Text = "Confirmar";
            this.SendLogin.UseVisualStyleBackColor = false;
            this.SendLogin.Click += new System.EventHandler(this.SendLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendLogin);
            this.Controls.Add(this.lnkRegistro);
            this.Controls.Add(this.lnkOlvide);
            this.Controls.Add(this.login_password_user);
            this.Controls.Add(this.login_email_user);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Login";
            this.Text = "Confirmar";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox login_email_user;
        private System.Windows.Forms.TextBox login_password_user;
        private System.Windows.Forms.LinkLabel lnkOlvide;
        private System.Windows.Forms.LinkLabel lnkRegistro;
        private System.Windows.Forms.Button SendLogin;
    }
}