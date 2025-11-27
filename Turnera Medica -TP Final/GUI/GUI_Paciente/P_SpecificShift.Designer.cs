namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    partial class P_SpecificShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_SpecificShift));
            this.return_start_P = new System.Windows.Forms.Button();
            this.P_SpecificShift_list = new System.Windows.Forms.DataGridView();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.searchShift = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SendLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P_name_user_guia = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P_SpecificShift_list)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // return_start_P
            // 
            this.return_start_P.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_P.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.return_start_P.Location = new System.Drawing.Point(309, 248);
            this.return_start_P.Name = "return_start_P";
            this.return_start_P.Size = new System.Drawing.Size(178, 41);
            this.return_start_P.TabIndex = 1;
            this.return_start_P.Text = "Volver";
            this.return_start_P.UseVisualStyleBackColor = false;
            this.return_start_P.Click += new System.EventHandler(this.return_start_P_Click);
            // 
            // P_SpecificShift_list
            // 
            this.P_SpecificShift_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P_SpecificShift_list.Location = new System.Drawing.Point(131, 12);
            this.P_SpecificShift_list.MultiSelect = false;
            this.P_SpecificShift_list.Name = "P_SpecificShift_list";
            this.P_SpecificShift_list.ReadOnly = true;
            this.P_SpecificShift_list.Size = new System.Drawing.Size(630, 230);
            this.P_SpecificShift_list.TabIndex = 2;
            this.P_SpecificShift_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.P_SpecificShift_list_CellContentClick);
            // 
            // selectDate
            // 
            this.selectDate.CustomFormat = "dd/MM/yyyy";
            this.selectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectDate.Location = new System.Drawing.Point(16, 71);
            this.selectDate.MaxDate = new System.DateTime(2025, 12, 12, 0, 0, 0, 0);
            this.selectDate.MinDate = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(109, 20);
            this.selectDate.TabIndex = 3;
            this.selectDate.Value = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.selectDate.ValueChanged += new System.EventHandler(this.selectDate_ValueChanged);
            // 
            // searchShift
            // 
            this.searchShift.BackColor = System.Drawing.Color.PaleGreen;
            this.searchShift.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.searchShift.Location = new System.Drawing.Point(16, 109);
            this.searchShift.Name = "searchShift";
            this.searchShift.Size = new System.Drawing.Size(110, 30);
            this.searchShift.TabIndex = 4;
            this.searchShift.Text = "Buscar";
            this.searchShift.UseVisualStyleBackColor = false;
            this.searchShift.Click += new System.EventHandler(this.searchShift_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(135, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Turno Especifico";
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
            this.P_name_user_guia.Click += new System.EventHandler(this.P_name_user_guia_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.P_SpecificShift_list);
            this.panel2.Controls.Add(this.return_start_P);
            this.panel2.Controls.Add(this.selectDate);
            this.panel2.Controls.Add(this.searchShift);
            this.panel2.Location = new System.Drawing.Point(12, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 302);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 71);
            this.panel3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha:";
            // 
            // P_SpecificShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "P_SpecificShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Turno Especifico";
            this.Load += new System.EventHandler(this.P_SpecificShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_SpecificShift_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_start_P;
        private System.Windows.Forms.DataGridView P_SpecificShift_list;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.Button searchShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label P_name_user_guia;
        private System.Windows.Forms.Button SendLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}