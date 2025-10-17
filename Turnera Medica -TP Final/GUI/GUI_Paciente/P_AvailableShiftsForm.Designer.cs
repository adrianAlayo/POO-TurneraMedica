namespace Turnera_Medica__TP_Final.GUI.GUI_Paciente
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
            this.return_start_P = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return_start_P
            // 
            this.return_start_P.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_P.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_start_P.Location = new System.Drawing.Point(326, 398);
            this.return_start_P.Name = "return_start_P";
            this.return_start_P.Size = new System.Drawing.Size(150, 40);
            this.return_start_P.TabIndex = 2;
            this.return_start_P.Text = "Volver";
            this.return_start_P.UseVisualStyleBackColor = false;
            this.return_start_P.Click += new System.EventHandler(this.return_start_P_Click);
            // 
            // P_AvailableShiftsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return_start_P);
            this.Name = "P_AvailableShiftsForm";
            this.Text = "P_AvailableShiftsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_start_P;
    }
}