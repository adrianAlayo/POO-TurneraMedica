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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.login_email_user = new System.Windows.Forms.TextBox();
            this.login_password_user = new System.Windows.Forms.TextBox();
            this.lnkOlvide = new System.Windows.Forms.LinkLabel();
            this.lnkRegistro = new System.Windows.Forms.LinkLabel();
            this.SendLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(308, 137);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Inicio de Sesión";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(238, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(191, 237);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 19);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Contraseña:";
            // 
            // login_email_user
            // 
            this.login_email_user.BackColor = System.Drawing.SystemColors.Control;
            this.login_email_user.Font = new System.Drawing.Font("Arial", 9F);
            this.login_email_user.Location = new System.Drawing.Point(301, 186);
            this.login_email_user.Name = "login_email_user";
            this.login_email_user.Size = new System.Drawing.Size(188, 21);
            this.login_email_user.TabIndex = 4;
            this.login_email_user.TextChanged += new System.EventHandler(this.login_email_user_TextChanged);
            // 
            // login_password_user
            // 
            this.login_password_user.BackColor = System.Drawing.SystemColors.Control;
            this.login_password_user.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password_user.Location = new System.Drawing.Point(301, 236);
            this.login_password_user.Name = "login_password_user";
            this.login_password_user.Size = new System.Drawing.Size(188, 20);
            this.login_password_user.TabIndex = 5;
            this.login_password_user.UseSystemPasswordChar = true;
            this.login_password_user.TextChanged += new System.EventHandler(this.login_password_user_TextChanged);
            this.login_password_user.DoubleClick += new System.EventHandler(this.login_password_user_DoubleClick);
            // 
            // lnkOlvide
            // 
            this.lnkOlvide.AutoSize = true;
            this.lnkOlvide.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkOlvide.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkOlvide.LinkColor = System.Drawing.Color.Navy;
            this.lnkOlvide.Location = new System.Drawing.Point(415, 363);
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
            this.lnkRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRegistro.LinkColor = System.Drawing.Color.Navy;
            this.lnkRegistro.Location = new System.Drawing.Point(263, 363);
            this.lnkRegistro.Name = "lnkRegistro";
            this.lnkRegistro.Size = new System.Drawing.Size(74, 15);
            this.lnkRegistro.TabIndex = 7;
            this.lnkRegistro.TabStop = true;
            this.lnkRegistro.Text = "Registrarse";
            this.lnkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegistro_LinkClicked);
            // 
            // SendLogin
            // 
            this.SendLogin.BackColor = System.Drawing.SystemColors.Control;
            this.SendLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendLogin.Location = new System.Drawing.Point(328, 292);
            this.SendLogin.Name = "SendLogin";
            this.SendLogin.Size = new System.Drawing.Size(136, 40);
            this.SendLogin.TabIndex = 8;
            this.SendLogin.Text = "Iniciar Sesion";
            this.SendLogin.UseVisualStyleBackColor = false;
            this.SendLogin.Click += new System.EventHandler(this.SendLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "Consultoría Médica";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SendLogin);
            this.Controls.Add(this.lnkRegistro);
            this.Controls.Add(this.lnkOlvide);
            this.Controls.Add(this.login_password_user);
            this.Controls.Add(this.login_email_user);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}