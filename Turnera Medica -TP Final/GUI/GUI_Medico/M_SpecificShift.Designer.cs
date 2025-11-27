namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    partial class M_SpecificShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_SpecificShift));
            this.return_start_M = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.searchShifts = new System.Windows.Forms.Button();
            this.M_SpecificShift_list = new System.Windows.Forms.DataGridView();
            this.attendedShift = new System.Windows.Forms.Button();
            this.canceledShift = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.M_name_user_guia = new System.Windows.Forms.Label();
            this.SendLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.M_SpecificShift_list)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // return_start_M
            // 
            this.return_start_M.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_M.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.return_start_M.Location = new System.Drawing.Point(348, 403);
            this.return_start_M.Name = "return_start_M";
            this.return_start_M.Size = new System.Drawing.Size(110, 35);
            this.return_start_M.TabIndex = 0;
            this.return_start_M.Text = "Volver";
            this.return_start_M.UseVisualStyleBackColor = false;
            this.return_start_M.Click += new System.EventHandler(this.return_start_M_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Turno Especifico";
            // 
            // selectDate
            // 
            this.selectDate.CustomFormat = "dd/MM/yyyy";
            this.selectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectDate.Location = new System.Drawing.Point(348, 99);
            this.selectDate.MaxDate = new System.DateTime(2025, 12, 12, 0, 0, 0, 0);
            this.selectDate.MinDate = new System.DateTime(2025, 11, 10, 0, 0, 0, 0);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(103, 20);
            this.selectDate.TabIndex = 2;
            this.selectDate.Value = new System.DateTime(2025, 11, 10, 0, 0, 0, 0);
            this.selectDate.ValueChanged += new System.EventHandler(this.selectDate_ValueChanged);
            this.selectDate.Validating += new System.ComponentModel.CancelEventHandler(this.selectDate_Validating);
            // 
            // searchShifts
            // 
            this.searchShifts.BackColor = System.Drawing.Color.LightGreen;
            this.searchShifts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchShifts.Location = new System.Drawing.Point(486, 98);
            this.searchShifts.Name = "searchShifts";
            this.searchShifts.Size = new System.Drawing.Size(90, 26);
            this.searchShifts.TabIndex = 3;
            this.searchShifts.Text = "Buscar";
            this.searchShifts.UseVisualStyleBackColor = false;
            this.searchShifts.Click += new System.EventHandler(this.searchShifts_Click);
            // 
            // M_SpecificShift_list
            // 
            this.M_SpecificShift_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.M_SpecificShift_list.Location = new System.Drawing.Point(114, 143);
            this.M_SpecificShift_list.MultiSelect = false;
            this.M_SpecificShift_list.Name = "M_SpecificShift_list";
            this.M_SpecificShift_list.ReadOnly = true;
            this.M_SpecificShift_list.Size = new System.Drawing.Size(663, 233);
            this.M_SpecificShift_list.TabIndex = 4;
            this.M_SpecificShift_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.M_SpecificShift_list_CellContentClick);
            // 
            // attendedShift
            // 
            this.attendedShift.BackColor = System.Drawing.Color.Coral;
            this.attendedShift.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendedShift.Location = new System.Drawing.Point(12, 177);
            this.attendedShift.Name = "attendedShift";
            this.attendedShift.Size = new System.Drawing.Size(90, 26);
            this.attendedShift.TabIndex = 5;
            this.attendedShift.Text = "Asistió";
            this.attendedShift.UseVisualStyleBackColor = false;
            this.attendedShift.Click += new System.EventHandler(this.attendedShift_Click);
            // 
            // canceledShift
            // 
            this.canceledShift.BackColor = System.Drawing.Color.Coral;
            this.canceledShift.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canceledShift.Location = new System.Drawing.Point(12, 224);
            this.canceledShift.Name = "canceledShift";
            this.canceledShift.Size = new System.Drawing.Size(90, 26);
            this.canceledShift.TabIndex = 6;
            this.canceledShift.Text = "Canceló";
            this.canceledShift.UseVisualStyleBackColor = false;
            this.canceledShift.Click += new System.EventHandler(this.canceledShift_Click);
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
            this.panel1.Size = new System.Drawing.Size(813, 57);
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
            this.SendLogin.Location = new System.Drawing.Point(609, 6);
            this.SendLogin.Name = "SendLogin";
            this.SendLogin.Size = new System.Drawing.Size(178, 41);
            this.SendLogin.TabIndex = 20;
            this.SendLogin.Text = "Cerrar Sesion";
            this.SendLogin.UseVisualStyleBackColor = false;
            this.SendLogin.Click += new System.EventHandler(this.SendLogin_Click);
            // 
            // M_SpecificShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canceledShift);
            this.Controls.Add(this.attendedShift);
            this.Controls.Add(this.M_SpecificShift_list);
            this.Controls.Add(this.searchShifts);
            this.Controls.Add(this.selectDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_start_M);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "M_SpecificShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Turno Especifico";
            this.Load += new System.EventHandler(this.M_SpecificShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.M_SpecificShift_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_start_M;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.Button searchShifts;
        private System.Windows.Forms.DataGridView M_SpecificShift_list;
        private System.Windows.Forms.Button attendedShift;
        private System.Windows.Forms.Button canceledShift;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label M_name_user_guia;
        private System.Windows.Forms.Button SendLogin;
    }
}