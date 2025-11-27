namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    partial class P_AvailableShifts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_AvailableShifts));
            this.return_start_P = new System.Windows.Forms.Button();
            this.dataGridView_shifts_result = new System.Windows.Forms.DataGridView();
            this.take_turn_P = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SendLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P_name_user_guia = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shifts_result)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // return_start_P
            // 
            this.return_start_P.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_P.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_start_P.Location = new System.Drawing.Point(19, 288);
            this.return_start_P.Name = "return_start_P";
            this.return_start_P.Size = new System.Drawing.Size(178, 41);
            this.return_start_P.TabIndex = 1;
            this.return_start_P.Text = "Volver";
            this.return_start_P.UseVisualStyleBackColor = false;
            this.return_start_P.Click += new System.EventHandler(this.return_start_P_Click);
            // 
            // dataGridView_shifts_result
            // 
            this.dataGridView_shifts_result.AllowUserToAddRows = false;
            this.dataGridView_shifts_result.AllowUserToDeleteRows = false;
            this.dataGridView_shifts_result.AllowUserToResizeColumns = false;
            this.dataGridView_shifts_result.AllowUserToResizeRows = false;
            this.dataGridView_shifts_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_shifts_result.Location = new System.Drawing.Point(19, 21);
            this.dataGridView_shifts_result.MultiSelect = false;
            this.dataGridView_shifts_result.Name = "dataGridView_shifts_result";
            this.dataGridView_shifts_result.ReadOnly = true;
            this.dataGridView_shifts_result.Size = new System.Drawing.Size(567, 254);
            this.dataGridView_shifts_result.StandardTab = true;
            this.dataGridView_shifts_result.TabIndex = 2;
            this.dataGridView_shifts_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_shifts_result_CellContentClick);
            // 
            // take_turn_P
            // 
            this.take_turn_P.BackColor = System.Drawing.Color.LightGreen;
            this.take_turn_P.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.take_turn_P.Location = new System.Drawing.Point(408, 288);
            this.take_turn_P.Name = "take_turn_P";
            this.take_turn_P.Size = new System.Drawing.Size(178, 41);
            this.take_turn_P.TabIndex = 3;
            this.take_turn_P.Text = "Tomar Turno";
            this.take_turn_P.UseVisualStyleBackColor = false;
            this.take_turn_P.Click += new System.EventHandler(this.take_turn_P_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(99, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turnos Disponibles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SendLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.P_name_user_guia);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 57);
            this.panel1.TabIndex = 20;
            // 
            // SendLogin
            // 
            this.SendLogin.BackColor = System.Drawing.Color.Coral;
            this.SendLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SendLogin.Location = new System.Drawing.Point(609, 6);
            this.SendLogin.Name = "SendLogin";
            this.SendLogin.Size = new System.Drawing.Size(178, 41);
            this.SendLogin.TabIndex = 21;
            this.SendLogin.Text = "Cerrar Sesion";
            this.SendLogin.UseVisualStyleBackColor = false;
            this.SendLogin.Click += new System.EventHandler(this.SendLogin_Click);
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
            // P_name_user_guia
            // 
            this.P_name_user_guia.AutoSize = true;
            this.P_name_user_guia.Font = new System.Drawing.Font("Arial Black", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_name_user_guia.Location = new System.Drawing.Point(59, 7);
            this.P_name_user_guia.Name = "P_name_user_guia";
            this.P_name_user_guia.Size = new System.Drawing.Size(162, 40);
            this.P_name_user_guia.TabIndex = 10;
            this.P_name_user_guia.Text = "Paciente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.dataGridView_shifts_result);
            this.panel2.Controls.Add(this.take_turn_P);
            this.panel2.Controls.Add(this.return_start_P);
            this.panel2.Location = new System.Drawing.Point(117, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 339);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(117, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 71);
            this.panel3.TabIndex = 22;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // P_AvailableShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P_AvailableShifts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos Disponibles";
            this.Load += new System.EventHandler(this.P_AvailableShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shifts_result)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_start_P;
        private System.Windows.Forms.DataGridView dataGridView_shifts_result;
        private System.Windows.Forms.Button take_turn_P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label P_name_user_guia;
        private System.Windows.Forms.Button SendLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}