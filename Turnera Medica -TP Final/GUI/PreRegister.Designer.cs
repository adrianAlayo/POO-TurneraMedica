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
            this.label1 = new System.Windows.Forms.Label();
            this.medico_option_user = new System.Windows.Forms.Button();
            this.paciente_option_user = new System.Windows.Forms.Button();
            this.ReturnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir Rol";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // medico_option_user
            // 
            this.medico_option_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.medico_option_user.FlatAppearance.BorderSize = 10;
            this.medico_option_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.medico_option_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.medico_option_user.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medico_option_user.Location = new System.Drawing.Point(363, 191);
            this.medico_option_user.Name = "medico_option_user";
            this.medico_option_user.Size = new System.Drawing.Size(113, 37);
            this.medico_option_user.TabIndex = 1;
            this.medico_option_user.Text = "Medico";
            this.medico_option_user.UseVisualStyleBackColor = true;
            this.medico_option_user.Click += new System.EventHandler(this.Medico_option_user_Click);
            // 
            // paciente_option_user
            // 
            this.paciente_option_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.paciente_option_user.FlatAppearance.BorderSize = 10;
            this.paciente_option_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.paciente_option_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.paciente_option_user.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paciente_option_user.Location = new System.Drawing.Point(363, 271);
            this.paciente_option_user.Name = "paciente_option_user";
            this.paciente_option_user.Size = new System.Drawing.Size(113, 37);
            this.paciente_option_user.TabIndex = 2;
            this.paciente_option_user.Text = "Paciente";
            this.paciente_option_user.UseVisualStyleBackColor = true;
            this.paciente_option_user.Click += new System.EventHandler(this.paciente_option_user_Click);
            // 
            // ReturnLogin
            // 
            this.ReturnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReturnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReturnLogin.FlatAppearance.BorderSize = 10;
            this.ReturnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.ReturnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ReturnLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLogin.Location = new System.Drawing.Point(363, 372);
            this.ReturnLogin.Name = "ReturnLogin";
            this.ReturnLogin.Size = new System.Drawing.Size(113, 37);
            this.ReturnLogin.TabIndex = 4;
            this.ReturnLogin.Text = "Volver";
            this.ReturnLogin.UseVisualStyleBackColor = false;
            this.ReturnLogin.Click += new System.EventHandler(this.ReturnLogin_Click);
            // 
            // PreRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnLogin);
            this.Controls.Add(this.paciente_option_user);
            this.Controls.Add(this.medico_option_user);
            this.Controls.Add(this.label1);
            this.Name = "PreRegister";
            this.Text = "PreRegister";
            this.Load += new System.EventHandler(this.PreRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button medico_option_user;
        private System.Windows.Forms.Button paciente_option_user;
        private System.Windows.Forms.Button ReturnLogin;
    }
}