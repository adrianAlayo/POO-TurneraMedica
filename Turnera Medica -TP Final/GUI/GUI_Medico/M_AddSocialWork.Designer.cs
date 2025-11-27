namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    partial class M_AddSocialWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_AddSocialWork));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.socialwork_name_user = new System.Windows.Forms.TextBox();
            this.return_start_M = new System.Windows.Forms.Button();
            this.sent_socialwork = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.M_name_user_guia = new System.Windows.Forms.Label();
            this.SendLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir Obra Social";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(128, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Obra Social:";
            // 
            // socialwork_name_user
            // 
            this.socialwork_name_user.BackColor = System.Drawing.SystemColors.Control;
            this.socialwork_name_user.Font = new System.Drawing.Font("Arial", 9F);
            this.socialwork_name_user.Location = new System.Drawing.Point(237, 157);
            this.socialwork_name_user.Name = "socialwork_name_user";
            this.socialwork_name_user.Size = new System.Drawing.Size(200, 21);
            this.socialwork_name_user.TabIndex = 2;
            this.socialwork_name_user.TextChanged += new System.EventHandler(this.socialwork_name_user_TextChanged);
            // 
            // return_start_M
            // 
            this.return_start_M.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_M.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.return_start_M.Location = new System.Drawing.Point(44, 311);
            this.return_start_M.Name = "return_start_M";
            this.return_start_M.Size = new System.Drawing.Size(110, 35);
            this.return_start_M.TabIndex = 3;
            this.return_start_M.Text = "Volver";
            this.return_start_M.UseVisualStyleBackColor = false;
            this.return_start_M.Click += new System.EventHandler(this.return_start_M_Click);
            // 
            // sent_socialwork
            // 
            this.sent_socialwork.BackColor = System.Drawing.Color.LightGreen;
            this.sent_socialwork.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.sent_socialwork.Location = new System.Drawing.Point(288, 248);
            this.sent_socialwork.Name = "sent_socialwork";
            this.sent_socialwork.Size = new System.Drawing.Size(100, 35);
            this.sent_socialwork.TabIndex = 4;
            this.sent_socialwork.Text = "Añadir";
            this.sent_socialwork.UseVisualStyleBackColor = false;
            this.sent_socialwork.Click += new System.EventHandler(this.sent_socialwork_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.M_name_user_guia);
            this.panel1.Controls.Add(this.SendLogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 57);
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
            this.M_name_user_guia.Size = new System.Drawing.Size(137, 40);
            this.M_name_user_guia.TabIndex = 10;
            this.M_name_user_guia.Text = "Medico:";
            // 
            // SendLogin
            // 
            this.SendLogin.BackColor = System.Drawing.Color.Coral;
            this.SendLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SendLogin.Location = new System.Drawing.Point(472, 7);
            this.SendLogin.Name = "SendLogin";
            this.SendLogin.Size = new System.Drawing.Size(178, 41);
            this.SendLogin.TabIndex = 20;
            this.SendLogin.Text = "Cerrar Sesion";
            this.SendLogin.UseVisualStyleBackColor = false;
            this.SendLogin.Click += new System.EventHandler(this.SendLogin_Click);
            // 
            // M_AddSocialWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(663, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sent_socialwork);
            this.Controls.Add(this.return_start_M);
            this.Controls.Add(this.socialwork_name_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "M_AddSocialWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSocialWork";
            this.Load += new System.EventHandler(this.M_AddSocialWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox socialwork_name_user;
        private System.Windows.Forms.Button return_start_M;
        private System.Windows.Forms.Button sent_socialwork;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label M_name_user_guia;
        private System.Windows.Forms.Button SendLogin;
    }
}