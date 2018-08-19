namespace SEN321Project
{
    partial class frmAddProduct
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
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.btnConfirmProduct = new System.Windows.Forms.Button();
            this.lblAddComponent = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount1 = new System.Windows.Forms.Label();
            this.cmbComponent = new System.Windows.Forms.ComboBox();
            this.lblComponent = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.rtxDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.pnlAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddProduct.Controls.Add(this.btnConfirmProduct);
            this.pnlAddProduct.Controls.Add(this.lblAddComponent);
            this.pnlAddProduct.Controls.Add(this.nudAmount);
            this.pnlAddProduct.Controls.Add(this.lblAmount1);
            this.pnlAddProduct.Controls.Add(this.cmbComponent);
            this.pnlAddProduct.Controls.Add(this.lblComponent);
            this.pnlAddProduct.Controls.Add(this.lblPrice);
            this.pnlAddProduct.Controls.Add(this.rtxDescription);
            this.pnlAddProduct.Controls.Add(this.btnAddComponent);
            this.pnlAddProduct.Controls.Add(this.txtPrice);
            this.pnlAddProduct.Controls.Add(this.lblDescription);
            this.pnlAddProduct.Controls.Add(this.btnBack);
            this.pnlAddProduct.Controls.Add(this.lblAddProduct);
            this.pnlAddProduct.Location = new System.Drawing.Point(12, 12);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(504, 344);
            this.pnlAddProduct.TabIndex = 0;
            // 
            // btnConfirmProduct
            // 
            this.btnConfirmProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmProduct.Location = new System.Drawing.Point(394, 312);
            this.btnConfirmProduct.Name = "btnConfirmProduct";
            this.btnConfirmProduct.Size = new System.Drawing.Size(105, 27);
            this.btnConfirmProduct.TabIndex = 44;
            this.btnConfirmProduct.Text = "Confirm Product";
            this.btnConfirmProduct.UseVisualStyleBackColor = true;
            this.btnConfirmProduct.Click += new System.EventHandler(this.btnConfirmProduct_Click);
            // 
            // lblAddComponent
            // 
            this.lblAddComponent.AutoSize = true;
            this.lblAddComponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddComponent.Location = new System.Drawing.Point(96, 176);
            this.lblAddComponent.Name = "lblAddComponent";
            this.lblAddComponent.Size = new System.Drawing.Size(129, 13);
            this.lblAddComponent.TabIndex = 42;
            this.lblAddComponent.Text = "Add new component?";
            this.lblAddComponent.Click += new System.EventHandler(this.label10_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(433, 130);
            this.nudAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(37, 20);
            this.nudAmount.TabIndex = 29;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudAmount_KeyPress);
            // 
            // lblAmount1
            // 
            this.lblAmount1.AutoSize = true;
            this.lblAmount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount1.Location = new System.Drawing.Point(366, 132);
            this.lblAmount1.Name = "lblAmount1";
            this.lblAmount1.Size = new System.Drawing.Size(53, 13);
            this.lblAmount1.TabIndex = 28;
            this.lblAmount1.Text = "Amount:";
            // 
            // cmbComponent
            // 
            this.cmbComponent.FormattingEnabled = true;
            this.cmbComponent.Location = new System.Drawing.Point(141, 127);
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.Size = new System.Drawing.Size(188, 21);
            this.cmbComponent.TabIndex = 27;
            this.cmbComponent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbComponent_KeyPress);
            // 
            // lblComponent
            // 
            this.lblComponent.AutoSize = true;
            this.lblComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponent.Location = new System.Drawing.Point(12, 130);
            this.lblComponent.Name = "lblComponent";
            this.lblComponent.Size = new System.Drawing.Size(74, 13);
            this.lblComponent.TabIndex = 26;
            this.lblComponent.Text = "Component:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(279, 176);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price:";
            // 
            // rtxDescription
            // 
            this.rtxDescription.Location = new System.Drawing.Point(141, 86);
            this.rtxDescription.Name = "rtxDescription";
            this.rtxDescription.Size = new System.Drawing.Size(329, 22);
            this.rtxDescription.TabIndex = 24;
            this.rtxDescription.Text = "";
            this.rtxDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxDescription_KeyPress);
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponent.Location = new System.Drawing.Point(180, 240);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(149, 44);
            this.btnAddComponent.TabIndex = 23;
            this.btnAddComponent.Text = "Add Component";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(340, 173);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 20);
            this.txtPrice.TabIndex = 22;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 91);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(123, 13);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Product Description:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(135, 27);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(240, 31);
            this.lblAddProduct.TabIndex = 4;
            this.lblAddProduct.Text = "Add New Product";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlAddProduct);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.pnlAddProduct.ResumeLayout(false);
            this.pnlAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddProduct;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Label lblComponent;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RichTextBox rtxDescription;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lblAmount1;
        private System.Windows.Forms.ComboBox cmbComponent;
        private System.Windows.Forms.Label lblAddComponent;
        private System.Windows.Forms.Button btnConfirmProduct;
    }
}