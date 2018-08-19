namespace SEN321Project
{
    partial class frmUpdateOrder
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
            this.pnlUpdateOrder = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.chkDelivered = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtPaymentMethod = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblUpdateOrder = new System.Windows.Forms.Label();
            this.pnlUpdateOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUpdateOrder
            // 
            this.pnlUpdateOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateOrder.Controls.Add(this.btnBack);
            this.pnlUpdateOrder.Controls.Add(this.btnFinishOrder);
            this.pnlUpdateOrder.Controls.Add(this.btnCancelOrder);
            this.pnlUpdateOrder.Controls.Add(this.chkDelivered);
            this.pnlUpdateOrder.Controls.Add(this.txtPrice);
            this.pnlUpdateOrder.Controls.Add(this.txtOrderDate);
            this.pnlUpdateOrder.Controls.Add(this.txtClientID);
            this.pnlUpdateOrder.Controls.Add(this.txtPaymentMethod);
            this.pnlUpdateOrder.Controls.Add(this.lblPrice);
            this.pnlUpdateOrder.Controls.Add(this.lblPaymentMethod);
            this.pnlUpdateOrder.Controls.Add(this.lblOrderDate);
            this.pnlUpdateOrder.Controls.Add(this.lblClientID);
            this.pnlUpdateOrder.Controls.Add(this.cmbOrder);
            this.pnlUpdateOrder.Controls.Add(this.lblOrderID);
            this.pnlUpdateOrder.Controls.Add(this.lblUpdateOrder);
            this.pnlUpdateOrder.Location = new System.Drawing.Point(12, 12);
            this.pnlUpdateOrder.Name = "pnlUpdateOrder";
            this.pnlUpdateOrder.Size = new System.Drawing.Size(504, 344);
            this.pnlUpdateOrder.TabIndex = 0;
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
            this.btnBack.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishOrder.Location = new System.Drawing.Point(307, 240);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(149, 44);
            this.btnFinishOrder.TabIndex = 28;
            this.btnFinishOrder.Text = "Finish Order";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Location = new System.Drawing.Point(65, 240);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(149, 44);
            this.btnCancelOrder.TabIndex = 27;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // chkDelivered
            // 
            this.chkDelivered.AutoSize = true;
            this.chkDelivered.Enabled = false;
            this.chkDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDelivered.Location = new System.Drawing.Point(318, 91);
            this.chkDelivered.Name = "chkDelivered";
            this.chkDelivered.Size = new System.Drawing.Size(87, 17);
            this.chkDelivered.TabIndex = 26;
            this.chkDelivered.Text = "Delivered?";
            this.chkDelivered.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(367, 186);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 25;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(367, 147);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderDate.TabIndex = 24;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(151, 141);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.ReadOnly = true;
            this.txtClientID.Size = new System.Drawing.Size(100, 20);
            this.txtClientID.TabIndex = 23;
            // 
            // txtPaymentMethod
            // 
            this.txtPaymentMethod.Location = new System.Drawing.Point(151, 180);
            this.txtPaymentMethod.Name = "txtPaymentMethod";
            this.txtPaymentMethod.ReadOnly = true;
            this.txtPaymentMethod.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentMethod.TabIndex = 22;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(288, 186);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Price:";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(43, 183);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(105, 13);
            this.lblPaymentMethod.TabIndex = 20;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(288, 147);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(73, 13);
            this.lblOrderDate.TabIndex = 19;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(43, 144);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(60, 13);
            this.lblClientID.TabIndex = 18;
            this.lblClientID.Text = "Client ID:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(191, 87);
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
            this.lblOrderID.Location = new System.Drawing.Point(126, 91);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(59, 13);
            this.lblOrderID.TabIndex = 16;
            this.lblOrderID.Text = "Order ID:";
            // 
            // lblUpdateOrder
            // 
            this.lblUpdateOrder.AutoSize = true;
            this.lblUpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateOrder.Location = new System.Drawing.Point(163, 27);
            this.lblUpdateOrder.Name = "lblUpdateOrder";
            this.lblUpdateOrder.Size = new System.Drawing.Size(190, 31);
            this.lblUpdateOrder.TabIndex = 15;
            this.lblUpdateOrder.Text = "Update Order";
            // 
            // frmUpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlUpdateOrder);
            this.Name = "frmUpdateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmUpdateOrder_Load);
            this.pnlUpdateOrder.ResumeLayout(false);
            this.pnlUpdateOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdateOrder;
        private System.Windows.Forms.Label lblUpdateOrder;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.CheckBox chkDelivered;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnBack;
    }
}