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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.socialwork_name_user = new System.Windows.Forms.TextBox();
            this.return_start_M = new System.Windows.Forms.Button();
            this.sent_socialwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir Obra Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Obra Social:";
            // 
            // socialwork_name_user
            // 
            this.socialwork_name_user.BackColor = System.Drawing.Color.LightPink;
            this.socialwork_name_user.Location = new System.Drawing.Point(217, 160);
            this.socialwork_name_user.Name = "socialwork_name_user";
            this.socialwork_name_user.Size = new System.Drawing.Size(217, 20);
            this.socialwork_name_user.TabIndex = 2;
            this.socialwork_name_user.TextChanged += new System.EventHandler(this.socialwork_name_user_TextChanged);
            // 
            // return_start_M
            // 
            this.return_start_M.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_M.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_start_M.Location = new System.Drawing.Point(44, 347);
            this.return_start_M.Name = "return_start_M";
            this.return_start_M.Size = new System.Drawing.Size(100, 40);
            this.return_start_M.TabIndex = 3;
            this.return_start_M.Text = "Volver";
            this.return_start_M.UseVisualStyleBackColor = false;
            this.return_start_M.Click += new System.EventHandler(this.return_start_M_Click);
            // 
            // sent_socialwork
            // 
            this.sent_socialwork.BackColor = System.Drawing.Color.LightGreen;
            this.sent_socialwork.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sent_socialwork.Location = new System.Drawing.Point(272, 239);
            this.sent_socialwork.Name = "sent_socialwork";
            this.sent_socialwork.Size = new System.Drawing.Size(100, 40);
            this.sent_socialwork.TabIndex = 4;
            this.sent_socialwork.Text = "Añadir";
            this.sent_socialwork.UseVisualStyleBackColor = false;
            this.sent_socialwork.Click += new System.EventHandler(this.sent_socialwork_Click);
            // 
            // M_AddSocialWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.sent_socialwork);
            this.Controls.Add(this.return_start_M);
            this.Controls.Add(this.socialwork_name_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "M_AddSocialWork";
            this.Text = "AddSocialWork";
            this.Load += new System.EventHandler(this.M_AddSocialWork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox socialwork_name_user;
        private System.Windows.Forms.Button return_start_M;
        private System.Windows.Forms.Button sent_socialwork;
    }
}