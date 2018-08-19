namespace SEN321Project
{
    partial class frmConfirmProduct
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
            this.pnlUpdateClient = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.ComponentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.pnlUpdateClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpdateClient
            // 
            this.pnlUpdateClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateClient.Controls.Add(this.btnConfirm);
            this.pnlUpdateClient.Controls.Add(this.dgvProductDetails);
            this.pnlUpdateClient.Controls.Add(this.btnEditProduct);
            this.pnlUpdateClient.Location = new System.Drawing.Point(12, 12);
            this.pnlUpdateClient.Name = "pnlUpdateClient";
            this.pnlUpdateClient.Size = new System.Drawing.Size(555, 339);
            this.pnlUpdateClient.TabIndex = 55;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(274, 290);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(276, 44);
            this.btnConfirm.TabIndex = 54;
            this.btnConfirm.Text = "Confirm Product";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentID,
            this.Description,
            this.Quantity});
            this.dgvProductDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvProductDetails.MultiSelect = false;
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.ReadOnly = true;
            this.dgvProductDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(547, 281);
            this.dgvProductDetails.TabIndex = 53;
            // 
            // ComponentID
            // 
            this.ComponentID.HeaderText = "ComponentID";
            this.ComponentID.Name = "ComponentID";
            this.ComponentID.ReadOnly = true;
            this.ComponentID.Width = 80;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 123;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Location = new System.Drawing.Point(3, 290);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(265, 44);
            this.btnEditProduct.TabIndex = 52;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // frmConfirmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(579, 363);
            this.Controls.Add(this.pnlUpdateClient);
            this.Name = "frmConfirmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmConfirmProduct_Load);
            this.pnlUpdateClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpdateClient;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnEditProduct;
    }
}