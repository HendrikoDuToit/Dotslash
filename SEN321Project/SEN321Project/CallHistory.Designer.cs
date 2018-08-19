namespace SEN321Project
{
    partial class frmCallHistory
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
            this.pnlCallHistory = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvCallHistory = new System.Windows.Forms.DataGridView();
            this.lblCallHistory = new System.Windows.Forms.Label();
            this.pnlCallHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCallHistory
            // 
            this.pnlCallHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCallHistory.Controls.Add(this.lblCallHistory);
            this.pnlCallHistory.Controls.Add(this.dgvCallHistory);
            this.pnlCallHistory.Controls.Add(this.btnBack);
            this.pnlCallHistory.Location = new System.Drawing.Point(12, 12);
            this.pnlCallHistory.Name = "pnlCallHistory";
            this.pnlCallHistory.Size = new System.Drawing.Size(504, 344);
            this.pnlCallHistory.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvCallHistory
            // 
            this.dgvCallHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCallHistory.Location = new System.Drawing.Point(12, 62);
            this.dgvCallHistory.Name = "dgvCallHistory";
            this.dgvCallHistory.Size = new System.Drawing.Size(475, 248);
            this.dgvCallHistory.TabIndex = 5;
            // 
            // lblCallHistory
            // 
            this.lblCallHistory.AutoSize = true;
            this.lblCallHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallHistory.Location = new System.Drawing.Point(182, 19);
            this.lblCallHistory.Name = "lblCallHistory";
            this.lblCallHistory.Size = new System.Drawing.Size(166, 31);
            this.lblCallHistory.TabIndex = 6;
            this.lblCallHistory.Text = "Call History";
            // 
            // frmCallHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlCallHistory);
            this.Name = "frmCallHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmCallHistory_Load);
            this.pnlCallHistory.ResumeLayout(false);
            this.pnlCallHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCallHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvCallHistory;
        private System.Windows.Forms.Label lblCallHistory;
    }
}