namespace SEN321Project
{
    partial class frmAddInstallation
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
            this.pnlAddInstallation = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTechniciansUnavailable = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.cmbTechnician = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddInstallation = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblAddInstallation = new System.Windows.Forms.Label();
            this.pnlAddInstallation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddInstallation
            // 
            this.pnlAddInstallation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddInstallation.Controls.Add(this.lblInfo);
            this.pnlAddInstallation.Controls.Add(this.lblTechniciansUnavailable);
            this.pnlAddInstallation.Controls.Add(this.txtClientID);
            this.pnlAddInstallation.Controls.Add(this.lblTechnician);
            this.pnlAddInstallation.Controls.Add(this.cmbTechnician);
            this.pnlAddInstallation.Controls.Add(this.btnBack);
            this.pnlAddInstallation.Controls.Add(this.btnAddInstallation);
            this.pnlAddInstallation.Controls.Add(this.txtPrice);
            this.pnlAddInstallation.Controls.Add(this.txtOrderDate);
            this.pnlAddInstallation.Controls.Add(this.txtPaymentMethod);
            this.pnlAddInstallation.Controls.Add(this.lblPrice);
            this.pnlAddInstallation.Controls.Add(this.lblPaymentMethod);
            this.pnlAddInstallation.Controls.Add(this.lblOrderDate);
            this.pnlAddInstallation.Controls.Add(this.lblClientID);
            this.pnlAddInstallation.Controls.Add(this.cmbOrder);
            this.pnlAddInstallation.Controls.Add(this.lblOrderID);
            this.pnlAddInstallation.Controls.Add(this.lblAddInstallation);
            this.pnlAddInstallation.Location = new System.Drawing.Point(12, 12);
            this.pnlAddInstallation.Name = "pnlAddInstallation";
            this.pnlAddInstallation.Size = new System.Drawing.Size(504, 344);
            this.pnlAddInstallation.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(116, 52);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(292, 12);
            this.lblInfo.TabIndex = 34;
            this.lblInfo.Text = "Only orders that have been delivered can be scheduled for installations";
            // 
            // lblTechniciansUnavailable
            // 
            this.lblTechniciansUnavailable.AutoSize = true;
            this.lblTechniciansUnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechniciansUnavailable.Location = new System.Drawing.Point(63, 279);
            this.lblTechniciansUnavailable.Name = "lblTechniciansUnavailable";
            this.lblTechniciansUnavailable.Size = new System.Drawing.Size(152, 12);
            this.lblTechniciansUnavailable.TabIndex = 33;
            this.lblTechniciansUnavailable.Text = "No technicians available at this time";
            this.lblTechniciansUnavailable.Visible = false;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(140, 132);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(100, 20);
            this.txtClientID.TabIndex = 32;
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnician.Location = new System.Drawing.Point(38, 258);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(74, 13);
            this.lblTechnician.TabIndex = 31;
            this.lblTechnician.Text = "Technician:";
            // 
            // cmbTechnician
            // 
            this.cmbTechnician.FormattingEnabled = true;
            this.cmbTechnician.Location = new System.Drawing.Point(118, 255);
            this.cmbTechnician.Name = "cmbTechnician";
            this.cmbTechnician.Size = new System.Drawing.Size(122, 21);
            this.cmbTechnician.TabIndex = 30;
            this.cmbTechnician.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTechnician_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnAddInstallation
            // 
            this.btnAddInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstallation.Location = new System.Drawing.Point(280, 242);
            this.btnAddInstallation.Name = "btnAddInstallation";
            this.btnAddInstallation.Size = new System.Drawing.Size(149, 44);
            this.btnAddInstallation.TabIndex = 28;
            this.btnAddInstallation.Text = "Add";
            this.btnAddInstallation.UseVisualStyleBackColor = true;
            this.btnAddInstallation.Click += new System.EventHandler(this.btnAddInstallation_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(356, 177);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 25;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(356, 138);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderDate.TabIndex = 24;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(140, 171);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ReadOnly = true;
            this.txtPaymentMethod.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentMethod.TabIndex = 22;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(277, 177);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price:";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(32, 174);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(105, 13);
            this.lblPaymentMethod.TabIndex = 20;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(277, 138);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(73, 13);
            this.lblOrderDate.TabIndex = 19;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(32, 135);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(60, 13);
            this.lblClientID.TabIndex = 18;
            this.lblClientID.Text = "Client ID:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(229, 85);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbOrder.TabIndex = 17;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            this.cmbOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOrder_KeyPress);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(164, 89);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(59, 13);
            this.lblOrderID.TabIndex = 16;
            this.lblOrderID.Text = "Order ID:";
            // 
            // lblAddInstallation
            // 
            this.lblAddInstallation.AutoSize = true;
            this.lblAddInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddInstallation.Location = new System.Drawing.Point(152, 21);
            this.lblAddInstallation.Name = "lblAddInstallation";
            this.lblAddInstallation.Size = new System.Drawing.Size(216, 31);
            this.lblAddInstallation.TabIndex = 15;
            this.lblAddInstallation.Text = "Add Installation";
            // 
            // frmAddInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlAddInstallation);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmAddInstallation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmAssignTechnicians_Load);
            this.pnlAddInstallation.ResumeLayout(false);
            this.pnlAddInstallation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddInstallation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddInstallation;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblAddInstallation;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.ComboBox cmbTechnician;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblTechniciansUnavailable;
        private System.Windows.Forms.Label lblInfo;

    }
}