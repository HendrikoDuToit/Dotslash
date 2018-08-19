namespace SEN321Project
{
    partial class frmProductManagement
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
            this.pnlProductManagement = new System.Windows.Forms.Panel();
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblProductManagement = new System.Windows.Forms.Label();
            this.pnlProductManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProductManagement
            // 
            this.pnlProductManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProductManagement.Controls.Add(this.btnAnswerCall);
            this.pnlProductManagement.Controls.Add(this.btnBack);
            this.pnlProductManagement.Controls.Add(this.btnDeleteProduct);
            this.pnlProductManagement.Controls.Add(this.btnUpdateProduct);
            this.pnlProductManagement.Controls.Add(this.btnAddProduct);
            this.pnlProductManagement.Controls.Add(this.lblProductManagement);
            this.pnlProductManagement.Location = new System.Drawing.Point(12, 12);
            this.pnlProductManagement.Name = "pnlProductManagement";
            this.pnlProductManagement.Size = new System.Drawing.Size(504, 344);
            this.pnlProductManagement.TabIndex = 0;
            // 
            // btnAnswerCall
            // 
            this.btnAnswerCall.BackgroundImage = global::SEN321Project.Properties.Resources.Answer;
            this.btnAnswerCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnswerCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswerCall.Location = new System.Drawing.Point(417, 3);
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.Size = new System.Drawing.Size(82, 37);
            this.btnAnswerCall.TabIndex = 13;
            this.btnAnswerCall.UseVisualStyleBackColor = true;
            this.btnAnswerCall.Click += new System.EventHandler(this.btnAnswerCall_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(175, 238);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(149, 44);
            this.btnDeleteProduct.TabIndex = 18;
            this.btnDeleteProduct.Text = "Delete An Existing Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(175, 167);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(149, 44);
            this.btnUpdateProduct.TabIndex = 17;
            this.btnUpdateProduct.Text = "Update An Existing Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(175, 97);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(149, 44);
            this.btnAddProduct.TabIndex = 16;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProductManagement
            // 
            this.lblProductManagement.AutoSize = true;
            this.lblProductManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductManagement.Location = new System.Drawing.Point(109, 32);
            this.lblProductManagement.Name = "lblProductManagement";
            this.lblProductManagement.Size = new System.Drawing.Size(290, 31);
            this.lblProductManagement.TabIndex = 4;
            this.lblProductManagement.Text = "Product Management";
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlProductManagement);
            this.Name = "frmProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            this.pnlProductManagement.ResumeLayout(false);
            this.pnlProductManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProductManagement;
        private System.Windows.Forms.Label lblProductManagement;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAnswerCall;
    }
}