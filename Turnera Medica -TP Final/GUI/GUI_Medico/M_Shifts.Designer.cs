﻿namespace Turnera_Medica__TP_Final.GUI.GUI_Medico
{
    partial class M_Shifts
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
            this.return_start_M = new System.Windows.Forms.Button();
            this.M_Shfts_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.M_Shfts_list)).BeginInit();
            this.SuspendLayout();
            // 
            // return_start_M
            // 
            this.return_start_M.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.return_start_M.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_start_M.Location = new System.Drawing.Point(326, 398);
            this.return_start_M.Name = "return_start_M";
            this.return_start_M.Size = new System.Drawing.Size(150, 40);
            this.return_start_M.TabIndex = 0;
            this.return_start_M.Text = "Volver";
            this.return_start_M.UseVisualStyleBackColor = false;
            this.return_start_M.Click += new System.EventHandler(this.return_start_M_Click);
            // 
            // M_Shfts_list
            // 
            this.M_Shfts_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.M_Shfts_list.Location = new System.Drawing.Point(30, 83);
            this.M_Shfts_list.Name = "M_Shfts_list";
            this.M_Shfts_list.Size = new System.Drawing.Size(737, 277);
            this.M_Shfts_list.TabIndex = 1;
            this.M_Shfts_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.M_Shfts_list_CellContentClick);
            // 
            // M_Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.M_Shfts_list);
            this.Controls.Add(this.return_start_M);
            this.Name = "M_Shifts";
            this.Text = "Shifts";
            this.Load += new System.EventHandler(this.M_Shifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.M_Shfts_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button return_start_M;
        private System.Windows.Forms.DataGridView M_Shfts_list;
    }
}