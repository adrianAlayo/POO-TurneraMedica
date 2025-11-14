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
            this.return_start_P = new System.Windows.Forms.Button();
            this.dataGridView_shifts_result = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shifts_result)).BeginInit();
            this.SuspendLayout();
            // 
            // return_start_P
            // 
            this.return_start_P.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_P.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_start_P.Location = new System.Drawing.Point(325, 398);
            this.return_start_P.Name = "return_start_P";
            this.return_start_P.Size = new System.Drawing.Size(150, 40);
            this.return_start_P.TabIndex = 1;
            this.return_start_P.Text = "Volver";
            this.return_start_P.UseVisualStyleBackColor = false;
            this.return_start_P.Click += new System.EventHandler(this.return_start_P_Click);
            // 
            // dataGridView_shifts_result
            // 
            this.dataGridView_shifts_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_shifts_result.Location = new System.Drawing.Point(282, 133);
            this.dataGridView_shifts_result.Name = "dataGridView_shifts_result";
            this.dataGridView_shifts_result.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_shifts_result.TabIndex = 2;
            this.dataGridView_shifts_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_shifts_result_CellContentClick);
            // 
            // P_AvailableShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_shifts_result);
            this.Controls.Add(this.return_start_P);
            this.Name = "P_AvailableShifts";
            this.Text = "P_AvailableShifts";
            this.Load += new System.EventHandler(this.P_AvailableShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shifts_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_start_P;
        private System.Windows.Forms.DataGridView dataGridView_shifts_result;
    }
}