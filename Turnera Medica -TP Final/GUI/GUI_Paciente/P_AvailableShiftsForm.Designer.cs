﻿namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    partial class P_AvailableShiftsForm
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
            this.login_email_user = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ReturnPreRegister = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterP_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(170, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(491, 52);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "TURNOS DISPONIBLES";
            // 
            // login_email_user
            // 
            this.login_email_user.BackColor = System.Drawing.Color.LightPink;
            this.login_email_user.Location = new System.Drawing.Point(370, 146);
            this.login_email_user.Name = "login_email_user";
            this.login_email_user.Size = new System.Drawing.Size(149, 20);
            this.login_email_user.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightPink;
            this.textBox1.Location = new System.Drawing.Point(370, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightPink;
            this.textBox2.Location = new System.Drawing.Point(370, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 19;
            // 
            // ReturnPreRegister
            // 
            this.ReturnPreRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReturnPreRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReturnPreRegister.FlatAppearance.BorderSize = 10;
            this.ReturnPreRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.ReturnPreRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ReturnPreRegister.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnPreRegister.Location = new System.Drawing.Point(238, 335);
            this.ReturnPreRegister.Name = "ReturnPreRegister";
            this.ReturnPreRegister.Size = new System.Drawing.Size(113, 37);
            this.ReturnPreRegister.TabIndex = 36;
            this.ReturnPreRegister.Text = "Volver";
            this.ReturnPreRegister.UseVisualStyleBackColor = false;
            this.ReturnPreRegister.Click += new System.EventHandler(this.ReturnPreRegister_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(281, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 15);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Especialidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Consultorio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterP_send
            // 
            this.RegisterP_send.BackColor = System.Drawing.Color.LightGreen;
            this.RegisterP_send.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterP_send.Location = new System.Drawing.Point(468, 335);
            this.RegisterP_send.Name = "RegisterP_send";
            this.RegisterP_send.Size = new System.Drawing.Size(122, 37);
            this.RegisterP_send.TabIndex = 53;
            this.RegisterP_send.Text = "Buscar";
            this.RegisterP_send.UseVisualStyleBackColor = false;
            this.RegisterP_send.Click += new System.EventHandler(this.RegisterP_send_Click);
            // 
            // P_AvailableShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterP_send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.ReturnPreRegister);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.login_email_user);
            this.Controls.Add(this.lblTitulo);
            this.Name = "P_AvailableShiftsForm";
            this.Text = "P_AvailableShiftsForm";
            this.Load += new System.EventHandler(this.P_AvailableShiftsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox login_email_user;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ReturnPreRegister;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegisterP_send;
    }
}