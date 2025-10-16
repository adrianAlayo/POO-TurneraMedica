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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lnkOlvide = new System.Windows.Forms.LinkLabel();
            this.lnkRegistro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(313, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Confirmar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(317, 183);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(87, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "PLEASE LOG IN";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(272, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(243, 292);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(313, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(313, 285);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lnkOlvide
            // 
            this.lnkOlvide.AutoSize = true;
            this.lnkOlvide.Location = new System.Drawing.Point(294, 366);
            this.lnkOlvide.Name = "lnkOlvide";
            this.lnkOlvide.Size = new System.Drawing.Size(122, 13);
            this.lnkOlvide.TabIndex = 6;
            this.lnkOlvide.TabStop = true;
            this.lnkOlvide.Text = "Me olvidé mi contraseña";
            this.lnkOlvide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOlvide_LinkClicked);
            // 
            // lnkRegistro
            // 
            this.lnkRegistro.AutoSize = true;
            this.lnkRegistro.Location = new System.Drawing.Point(501, 323);
            this.lnkRegistro.Name = "lnkRegistro";
            this.lnkRegistro.Size = new System.Drawing.Size(60, 13);
            this.lnkRegistro.TabIndex = 7;
            this.lnkRegistro.TabStop = true;
            this.lnkRegistro.Text = "Registrarse";
            this.lnkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegistro_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkRegistro);
            this.Controls.Add(this.lnkOlvide);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel lnkOlvide;
        private System.Windows.Forms.LinkLabel lnkRegistro;
    }
}