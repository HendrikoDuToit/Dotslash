namespace SEN321Project
{
    partial class frmViewOrders
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
            this.dgvClientOrders = new System.Windows.Forms.DataGridView();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblReviewOrders = new System.Windows.Forms.Label();
            this.pnlViewOrders = new System.Windows.Forms.Panel();
            this.dgvClientOrderDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrders)).BeginInit();
            this.pnlViewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 428);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // dgvClientOrders
            // 
            this.dgvClientOrders.AllowUserToAddRows = false;
            this.dgvClientOrders.AllowUserToDeleteRows = false;
            this.dgvClientOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrders.Location = new System.Drawing.Point(11, 95);
            this.dgvClientOrders.MultiSelect = false;
            this.dgvClientOrders.Name = "dgvClientOrders";
            this.dgvClientOrders.ReadOnly = true;
            this.dgvClientOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientOrders.Size = new System.Drawing.Size(639, 151);
            this.dgvClientOrders.TabIndex = 2;
            this.dgvClientOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientOrders_CellClick);
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(295, 66);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 21);
            this.cmbClient.TabIndex = 3;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            this.cmbClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbClient_KeyPress);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(229, 69);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(60, 13);
            this.lblClientID.TabIndex = 4;
            this.lblClientID.Text = "Client ID:";
            // 
            // lblReviewOrders
            // 
            this.lblReviewOrders.AutoSize = true;
            this.lblReviewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewOrders.Location = new System.Drawing.Point(250, 15);
            this.lblReviewOrders.Name = "lblReviewOrders";
            this.lblReviewOrders.Size = new System.Drawing.Size(174, 31);
            this.lblReviewOrders.TabIndex = 5;
            this.lblReviewOrders.Text = "View Orders";
            // 
            // pnlViewOrders
            // 
            this.pnlViewOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewOrders.Controls.Add(this.dgvClientOrderDetails);
            this.pnlViewOrders.Controls.Add(this.dgvClientOrders);
            this.pnlViewOrders.Controls.Add(this.lblClientID);
            this.pnlViewOrders.Controls.Add(this.lblReviewOrders);
            this.pnlViewOrders.Controls.Add(this.btnBack);
            this.pnlViewOrders.Controls.Add(this.cmbClient);
            this.pnlViewOrders.Location = new System.Drawing.Point(12, 12);
            this.pnlViewOrders.Name = "pnlViewOrders";
            this.pnlViewOrders.Size = new System.Drawing.Size(661, 456);
            this.pnlViewOrders.TabIndex = 6;
            // 
            // dgvClientOrderDetails
            // 
            this.dgvClientOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrderDetails.Location = new System.Drawing.Point(11, 252);
            this.dgvClientOrderDetails.MultiSelect = false;
            this.dgvClientOrderDetails.Name = "dgvClientOrderDetails";
            this.dgvClientOrderDetails.ReadOnly = true;
            this.dgvClientOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientOrderDetails.Size = new System.Drawing.Size(639, 158);
            this.dgvClientOrderDetails.TabIndex = 6;
            // 
            // frmViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(685, 480);
            this.Controls.Add(this.pnlViewOrders);
            this.Name = "frmViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrders)).EndInit();
            this.pnlViewOrders.ResumeLayout(false);
            this.pnlViewOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvClientOrders;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblReviewOrders;
        private System.Windows.Forms.Panel pnlViewOrders;
        private System.Windows.Forms.DataGridView dgvClientOrderDetails;
    }
}