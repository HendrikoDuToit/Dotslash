namespace SEN321Project
{
    partial class frmViewTickets
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblViewTickets = new System.Windows.Forms.Label();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.pnlViewTickets = new System.Windows.Forms.Panel();
            this.chkOpen = new System.Windows.Forms.CheckBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.pnlViewTickets.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblViewTickets
            // 
            this.lblViewTickets.AutoSize = true;
            this.lblViewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewTickets.Location = new System.Drawing.Point(163, 12);
            this.lblViewTickets.Name = "lblViewTickets";
            this.lblViewTickets.Size = new System.Drawing.Size(180, 31);
            this.lblViewTickets.TabIndex = 5;
            this.lblViewTickets.Text = "View Tickets";
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(17, 74);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(469, 186);
            this.dgvTickets.TabIndex = 2;
            // 
            // pnlViewTickets
            // 
            this.pnlViewTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewTickets.Controls.Add(this.chkOpen);
            this.pnlViewTickets.Controls.Add(this.cmbStatus);
            this.pnlViewTickets.Controls.Add(this.btnCancelTicket);
            this.pnlViewTickets.Controls.Add(this.btnCloseTicket);
            this.pnlViewTickets.Controls.Add(this.dgvTickets);
            this.pnlViewTickets.Controls.Add(this.lblViewTickets);
            this.pnlViewTickets.Controls.Add(this.btnBack);
            this.pnlViewTickets.Location = new System.Drawing.Point(12, 12);
            this.pnlViewTickets.Name = "pnlViewTickets";
            this.pnlViewTickets.Size = new System.Drawing.Size(504, 344);
            this.pnlViewTickets.TabIndex = 7;
            // 
            // chkOpen
            // 
            this.chkOpen.AutoSize = true;
            this.chkOpen.Checked = true;
            this.chkOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpen.Location = new System.Drawing.Point(323, 48);
            this.chkOpen.Name = "chkOpen";
            this.chkOpen.Size = new System.Drawing.Size(52, 17);
            this.chkOpen.TabIndex = 21;
            this.chkOpen.Text = "Open";
            this.chkOpen.UseVisualStyleBackColor = true;
            this.chkOpen.CheckedChanged += new System.EventHandler(this.chkOpen_CheckedChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Assigned",
            "Unassigned"});
            this.cmbStatus.Location = new System.Drawing.Point(196, 46);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 20;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTicket.Location = new System.Drawing.Point(17, 266);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(227, 44);
            this.btnCancelTicket.TabIndex = 19;
            this.btnCancelTicket.Text = "Cancel Ticket";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click_1);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTicket.Location = new System.Drawing.Point(260, 266);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(226, 44);
            this.btnCloseTicket.TabIndex = 18;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnAssignTechnician_Click);
            // 
            // frmViewTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlViewTickets);
            this.Name = "frmViewTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmViewOpenTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.pnlViewTickets.ResumeLayout(false);
            this.pnlViewTickets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblViewTickets;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.Panel pnlViewTickets;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.CheckBox chkOpen;

    }
}