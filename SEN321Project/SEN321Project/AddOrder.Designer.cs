namespace SEN321Project
{
    partial class frmAddOrder
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
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblAddOrder = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.pnlAddOrder = new System.Windows.Forms.Panel();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblR = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.pnlAddOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 421);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(92, 109);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(106, 21);
            this.cmbClient.TabIndex = 1;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            this.cmbClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbClient_KeyPress);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(47, 112);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 13);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(47, 146);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(47, 182);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 13);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(47, 217);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(83, 13);
            this.lblDob.TabIndex = 5;
            this.lblDob.Text = "Date of Birth:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 146);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(162, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(133, 182);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(162, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // lblAddOrder
            // 
            this.lblAddOrder.AutoSize = true;
            this.lblAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOrder.Location = new System.Drawing.Point(179, 39);
            this.lblAddOrder.Name = "lblAddOrder";
            this.lblAddOrder.Size = new System.Drawing.Size(262, 31);
            this.lblAddOrder.TabIndex = 9;
            this.lblAddOrder.Text = "Place A New Order";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(464, 217);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(132, 20);
            this.txtPrice.TabIndex = 16;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(400, 158);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 13);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(394, 220);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(220, 109);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(55, 13);
            this.lblProduct.TabIndex = 11;
            this.lblProduct.Text = "Product:";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(281, 106);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(324, 21);
            this.cmbProduct.TabIndex = 10;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            this.cmbProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbProduct_KeyPress);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(464, 156);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(132, 20);
            this.nudQuantity.TabIndex = 20;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudQuantity_KeyPress);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(239, 368);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(149, 44);
            this.btnAddProduct.TabIndex = 21;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(524, 417);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(95, 27);
            this.btnConfirmOrder.TabIndex = 22;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // pnlAddOrder
            // 
            this.pnlAddOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddOrder.Controls.Add(this.dtpDateOfBirth);
            this.pnlAddOrder.Controls.Add(this.lblR);
            this.pnlAddOrder.Controls.Add(this.cmbPaymentMethod);
            this.pnlAddOrder.Controls.Add(this.lblPaymentMethod);
            this.pnlAddOrder.Controls.Add(this.lblAddOrder);
            this.pnlAddOrder.Controls.Add(this.btnConfirmOrder);
            this.pnlAddOrder.Controls.Add(this.btnBack);
            this.pnlAddOrder.Controls.Add(this.btnAddProduct);
            this.pnlAddOrder.Controls.Add(this.cmbClient);
            this.pnlAddOrder.Controls.Add(this.nudQuantity);
            this.pnlAddOrder.Controls.Add(this.lblClient);
            this.pnlAddOrder.Controls.Add(this.lblName);
            this.pnlAddOrder.Controls.Add(this.txtPrice);
            this.pnlAddOrder.Controls.Add(this.lblSurname);
            this.pnlAddOrder.Controls.Add(this.lblQuantity);
            this.pnlAddOrder.Controls.Add(this.lblDob);
            this.pnlAddOrder.Controls.Add(this.lblPrice);
            this.pnlAddOrder.Controls.Add(this.txtName);
            this.pnlAddOrder.Controls.Add(this.txtSurname);
            this.pnlAddOrder.Controls.Add(this.lblProduct);
            this.pnlAddOrder.Controls.Add(this.cmbProduct);
            this.pnlAddOrder.Location = new System.Drawing.Point(15, 11);
            this.pnlAddOrder.Name = "pnlAddOrder";
            this.pnlAddOrder.Size = new System.Drawing.Size(624, 449);
            this.pnlAddOrder.TabIndex = 23;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(133, 213);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1910, 2, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(162, 20);
            this.dtpDateOfBirth.TabIndex = 39;
            this.dtpDateOfBirth.Value = new System.DateTime(1910, 2, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDateOfBirth_KeyPress);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(449, 220);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(15, 13);
            this.lblR.TabIndex = 25;
            this.lblR.Text = "R";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Anually",
            "Quarterly",
            "Monthly",
            "Weekly"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(309, 276);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(132, 21);
            this.cmbPaymentMethod.TabIndex = 24;
            this.cmbPaymentMethod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPaymentMethod_KeyPress);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(198, 279);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(105, 13);
            this.lblPaymentMethod.TabIndex = 23;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // frmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(651, 472);
            this.Controls.Add(this.pnlAddOrder);
            this.Name = "frmAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmPlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.pnlAddOrder.ResumeLayout(false);
            this.pnlAddOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblAddOrder;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Panel pnlAddOrder;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
    }
}