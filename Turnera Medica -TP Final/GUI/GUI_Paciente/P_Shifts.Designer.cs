namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
{
    partial class P_Shifts
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
            this.return_start_P = new System.Windows.Forms.Button();
            this.P_Shifts_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P_Shifts_list)).BeginInit();
            this.SuspendLayout();
            // 
            // return_start_P
            // 
            this.return_start_P.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_P.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_start_P.Location = new System.Drawing.Point(331, 398);
            this.return_start_P.Name = "return_start_P";
            this.return_start_P.Size = new System.Drawing.Size(150, 40);
            this.return_start_P.TabIndex = 1;
            this.return_start_P.Text = "Volver";
            this.return_start_P.UseVisualStyleBackColor = false;
            this.return_start_P.Click += new System.EventHandler(this.return_start_P_Click);
            // 
            // P_Shifts_list
            // 
            this.P_Shifts_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.P_Shifts_list.Location = new System.Drawing.Point(12, 127);
            this.P_Shifts_list.MultiSelect = false;
            this.P_Shifts_list.Name = "P_Shifts_list";
            this.P_Shifts_list.ReadOnly = true;
            this.P_Shifts_list.Size = new System.Drawing.Size(770, 218);
            this.P_Shifts_list.TabIndex = 2;
            this.P_Shifts_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.P_Shifts_list_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mis Turnos";
            // 
            // P_Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_Shifts_list);
            this.Controls.Add(this.return_start_P);
            this.Name = "P_Shifts";
            this.Text = "P_Shifts";
            this.Load += new System.EventHandler(this.P_Shifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_Shifts_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button return_start_P;
        private System.Windows.Forms.DataGridView P_Shifts_list;
        private System.Windows.Forms.Label label1;
    }
}