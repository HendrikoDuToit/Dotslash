namespace SEN321Project
{
    partial class frmViewInstallations
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
            this.pnlViewInstallations = new System.Windows.Forms.Panel();
            this.btnCancelInstallation = new System.Windows.Forms.Button();
            this.btnFinishInstallation = new System.Windows.Forms.Button();
            this.chkInstalled = new System.Windows.Forms.CheckBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvInstallations = new System.Windows.Forms.DataGridView();
            this.lblViewInstallations = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlViewInstallations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallations)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewInstallations
            // 
            this.pnlViewInstallations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewInstallations.Controls.Add(this.btnCancelInstallation);
            this.pnlViewInstallations.Controls.Add(this.btnFinishInstallation);
            this.pnlViewInstallations.Controls.Add(this.chkInstalled);
            this.pnlViewInstallations.Controls.Add(this.cmbStatus);
            this.pnlViewInstallations.Controls.Add(this.dgvInstallations);
            this.pnlViewInstallations.Controls.Add(this.lblViewInstallations);
            this.pnlViewInstallations.Controls.Add(this.btnBack);
            this.pnlViewInstallations.Location = new System.Drawing.Point(12, 12);
            this.pnlViewInstallations.Name = "pnlViewInstallations";
            this.pnlViewInstallations.Size = new System.Drawing.Size(504, 344);
            this.pnlViewInstallations.TabIndex = 8;
            // 
            // btnCancelInstallation
            // 
            this.btnCancelInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelInstallation.Location = new System.Drawing.Point(18, 266);
            this.btnCancelInstallation.Name = "btnCancelInstallation";
            this.btnCancelInstallation.Size = new System.Drawing.Size(227, 44);
            this.btnCancelInstallation.TabIndex = 26;
            this.btnCancelInstallation.Text = "Cancel Installation";
            this.btnCancelInstallation.UseVisualStyleBackColor = true;
            this.btnCancelInstallation.Click += new System.EventHandler(this.btnCancelInstallation_Click);
            // 
            // btnFinishInstallation
            // 
            this.btnFinishInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishInstallation.Location = new System.Drawing.Point(261, 266);
            this.btnFinishInstallation.Name = "btnFinishInstallation";
            this.btnFinishInstallation.Size = new System.Drawing.Size(226, 44);
            this.btnFinishInstallation.TabIndex = 25;
            this.btnFinishInstallation.Text = "Finish Installation";
            this.btnFinishInstallation.UseVisualStyleBackColor = true;
            this.btnFinishInstallation.Click += new System.EventHandler(this.btnFinishInstallation_Click);
            // 
            // chkInstalled
            // 
            this.chkInstalled.AutoSize = true;
            this.chkInstalled.Checked = true;
            this.chkInstalled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInstalled.Location = new System.Drawing.Point(309, 65);
            this.chkInstalled.Name = "chkInstalled";
            this.chkInstalled.Size = new System.Drawing.Size(65, 17);
            this.chkInstalled.TabIndex = 24;
            this.chkInstalled.Text = "Installed";
            this.chkInstalled.UseVisualStyleBackColor = true;
            this.chkInstalled.CheckedChanged += new System.EventHandler(this.chkInstalled_CheckedChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Assigned",
            "Unassigned"});
            this.cmbStatus.Location = new System.Drawing.Point(182, 63);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 23;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // dgvInstallations
            // 
            this.dgvInstallations.AllowUserToAddRows = false;
            this.dgvInstallations.AllowUserToDeleteRows = false;
            this.dgvInstallations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstallations.Location = new System.Drawing.Point(18, 90);
            this.dgvInstallations.MultiSelect = false;
            this.dgvInstallations.Name = "dgvInstallations";
            this.dgvInstallations.ReadOnly = true;
            this.dgvInstallations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstallations.Size = new System.Drawing.Size(469, 170);
            this.dgvInstallations.TabIndex = 22;
            // 
            // lblViewInstallations
            // 
            this.lblViewInstallations.AutoSize = true;
            this.lblViewInstallations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewInstallations.Location = new System.Drawing.Point(137, 13);
            this.lblViewInstallations.Name = "lblViewInstallations";
            this.lblViewInstallations.Size = new System.Drawing.Size(243, 31);
            this.lblViewInstallations.TabIndex = 5;
            this.lblViewInstallations.Text = "View Installations";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmViewInstallations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlViewInstallations);
            this.Name = "frmViewInstallations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmViewInstallations_Load);
            this.pnlViewInstallations.ResumeLayout(false);
            this.pnlViewInstallations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstallations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewInstallations;
        private System.Windows.Forms.Label lblViewInstallations;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkInstalled;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvInstallations;
        private System.Windows.Forms.Button btnCancelInstallation;
        private System.Windows.Forms.Button btnFinishInstallation;

    }
}