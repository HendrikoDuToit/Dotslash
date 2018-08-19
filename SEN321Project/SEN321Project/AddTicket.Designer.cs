namespace SEN321Project
{
    partial class frmAddTicket
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.lblFaultDescription = new System.Windows.Forms.Label();
            this.cmbTechnician = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbTypeOfService = new System.Windows.Forms.ComboBox();
            this.lblServiceRequired = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddTicket = new System.Windows.Forms.Label();
            this.rtxFaultDescription = new System.Windows.Forms.RichTextBox();
            this.pnlAddTicket = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblTechniciansUnavailable = new System.Windows.Forms.Label();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.pnlAddTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(179, 89);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(55, 13);
            this.lblProduct.TabIndex = 11;
            this.lblProduct.Text = "Product:";
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnician.Location = new System.Drawing.Point(50, 253);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(74, 13);
            this.lblTechnician.TabIndex = 15;
            this.lblTechnician.Text = "Technician:";
            // 
            // lblFaultDescription
            // 
            this.lblFaultDescription.AutoSize = true;
            this.lblFaultDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaultDescription.Location = new System.Drawing.Point(288, 134);
            this.lblFaultDescription.Name = "lblFaultDescription";
            this.lblFaultDescription.Size = new System.Drawing.Size(107, 13);
            this.lblFaultDescription.TabIndex = 7;
            this.lblFaultDescription.Text = "Fault Description:";
            // 
            // cmbTechnician
            // 
            this.cmbTechnician.FormattingEnabled = true;
            this.cmbTechnician.Location = new System.Drawing.Point(25, 268);
            this.cmbTechnician.Name = "cmbTechnician";
            this.cmbTechnician.Size = new System.Drawing.Size(122, 21);
            this.cmbTechnician.TabIndex = 14;
            this.cmbTechnician.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTechnician_KeyPress);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(240, 86);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(265, 21);
            this.cmbProduct.TabIndex = 10;
            this.cmbProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProduct_KeyPress);
            // 
            // cmbTypeOfService
            // 
            this.cmbTypeOfService.FormattingEnabled = true;
            this.cmbTypeOfService.Location = new System.Drawing.Point(25, 210);
            this.cmbTypeOfService.Name = "cmbTypeOfService";
            this.cmbTypeOfService.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeOfService.TabIndex = 9;
            this.cmbTypeOfService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTypeOfService_KeyPress);
            // 
            // lblServiceRequired
            // 
            this.lblServiceRequired.AutoSize = true;
            this.lblServiceRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceRequired.Location = new System.Drawing.Point(33, 195);
            this.lblServiceRequired.Name = "lblServiceRequired";
            this.lblServiceRequired.Size = new System.Drawing.Size(109, 13);
            this.lblServiceRequired.TabIndex = 8;
            this.lblServiceRequired.Text = "Service Required:";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(26, 86);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 21);
            this.cmbClient.TabIndex = 4;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            this.cmbClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbClient_KeyPress);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(62, 71);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 13);
            this.lblClient.TabIndex = 5;
            this.lblClient.Text = "Client:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 355);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblAddTicket
            // 
            this.lblAddTicket.AutoSize = true;
            this.lblAddTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTicket.Location = new System.Drawing.Point(176, 25);
            this.lblAddTicket.Name = "lblAddTicket";
            this.lblAddTicket.Size = new System.Drawing.Size(168, 31);
            this.lblAddTicket.TabIndex = 3;
            this.lblAddTicket.Text = "Add a ticket";
            // 
            // rtxFaultDescription
            // 
            this.rtxFaultDescription.Location = new System.Drawing.Point(182, 162);
            this.rtxFaultDescription.Name = "rtxFaultDescription";
            this.rtxFaultDescription.Size = new System.Drawing.Size(323, 104);
            this.rtxFaultDescription.TabIndex = 6;
            this.rtxFaultDescription.Text = "";
            // 
            // pnlAddTicket
            // 
            this.pnlAddTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddTicket.Controls.Add(this.lblInfo);
            this.pnlAddTicket.Controls.Add(this.cmbOrder);
            this.pnlAddTicket.Controls.Add(this.lblOrder);
            this.pnlAddTicket.Controls.Add(this.lblTechniciansUnavailable);
            this.pnlAddTicket.Controls.Add(this.btnSubmitTicket);
            this.pnlAddTicket.Controls.Add(this.lblAddTicket);
            this.pnlAddTicket.Controls.Add(this.lblClient);
            this.pnlAddTicket.Controls.Add(this.lblTechnician);
            this.pnlAddTicket.Controls.Add(this.btnBack);
            this.pnlAddTicket.Controls.Add(this.cmbTechnician);
            this.pnlAddTicket.Controls.Add(this.cmbClient);
            this.pnlAddTicket.Controls.Add(this.rtxFaultDescription);
            this.pnlAddTicket.Controls.Add(this.lblProduct);
            this.pnlAddTicket.Controls.Add(this.lblFaultDescription);
            this.pnlAddTicket.Controls.Add(this.cmbProduct);
            this.pnlAddTicket.Controls.Add(this.lblServiceRequired);
            this.pnlAddTicket.Controls.Add(this.cmbTypeOfService);
            this.pnlAddTicket.Location = new System.Drawing.Point(12, 12);
            this.pnlAddTicket.Name = "pnlAddTicket";
            this.pnlAddTicket.Size = new System.Drawing.Size(520, 383);
            this.pnlAddTicket.TabIndex = 16;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(148, 56);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(231, 12);
            this.lblInfo.TabIndex = 35;
            this.lblInfo.Text = "Only products that have been installed can have tickets";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(26, 143);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbOrder.TabIndex = 19;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            this.cmbOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOrder_KeyPress);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(63, 127);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(42, 13);
            this.lblOrder.TabIndex = 18;
            this.lblOrder.Text = "Order:";
            // 
            // lblTechniciansUnavailable
            // 
            this.lblTechniciansUnavailable.AutoSize = true;
            this.lblTechniciansUnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechniciansUnavailable.Location = new System.Drawing.Point(14, 294);
            this.lblTechniciansUnavailable.Name = "lblTechniciansUnavailable";
            this.lblTechniciansUnavailable.Size = new System.Drawing.Size(152, 12);
            this.lblTechniciansUnavailable.TabIndex = 17;
            this.lblTechniciansUnavailable.Text = "No technicians available at this time";
            this.lblTechniciansUnavailable.Visible = false;
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitTicket.Location = new System.Drawing.Point(262, 291);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(149, 44);
            this.btnSubmitTicket.TabIndex = 16;
            this.btnSubmitTicket.Text = "Submit Ticket";
            this.btnSubmitTicket.UseVisualStyleBackColor = true;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // frmAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(544, 407);
            this.Controls.Add(this.pnlAddTicket);
            this.Name = "frmAddTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmAddTicket_Load);
            this.pnlAddTicket.ResumeLayout(false);
            this.pnlAddTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.Label lblFaultDescription;
        private System.Windows.Forms.ComboBox cmbTechnician;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbTypeOfService;
        private System.Windows.Forms.Label lblServiceRequired;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddTicket;
        private System.Windows.Forms.RichTextBox rtxFaultDescription;
        private System.Windows.Forms.Panel pnlAddTicket;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.Label lblTechniciansUnavailable;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblInfo;

    }
}