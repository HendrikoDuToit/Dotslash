namespace SEN321Project
{
    partial class frmAddComponent
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
            this.pnlAddComponent = new System.Windows.Forms.Panel();
            this.rtxDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAddComponent = new System.Windows.Forms.Label();
            this.pnlAddComponent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddComponent
            // 
            this.pnlAddComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddComponent.Controls.Add(this.rtxDescription);
            this.pnlAddComponent.Controls.Add(this.btnAddComponent);
            this.pnlAddComponent.Controls.Add(this.lblDescription);
            this.pnlAddComponent.Controls.Add(this.btnBack);
            this.pnlAddComponent.Controls.Add(this.lblAddComponent);
            this.pnlAddComponent.Location = new System.Drawing.Point(12, 12);
            this.pnlAddComponent.Name = "pnlAddComponent";
            this.pnlAddComponent.Size = new System.Drawing.Size(504, 344);
            this.pnlAddComponent.TabIndex = 1;
            // 
            // rtxDescription
            // 
            this.rtxDescription.Location = new System.Drawing.Point(32, 129);
            this.rtxDescription.Name = "rtxDescription";
            this.rtxDescription.Size = new System.Drawing.Size(425, 24);
            this.rtxDescription.TabIndex = 24;
            this.rtxDescription.Text = "";
            this.rtxDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxDescription_KeyPress);
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComponent.Location = new System.Drawing.Point(170, 246);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(149, 44);
            this.btnAddComponent.TabIndex = 23;
            this.btnAddComponent.Text = "Add Component";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(177, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(142, 13);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Component Description:";
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
            // lblAddComponent
            // 
            this.lblAddComponent.AutoSize = true;
            this.lblAddComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddComponent.Location = new System.Drawing.Point(121, 30);
            this.lblAddComponent.Name = "lblAddComponent";
            this.lblAddComponent.Size = new System.Drawing.Size(288, 31);
            this.lblAddComponent.TabIndex = 4;
            this.lblAddComponent.Text = "Add New Component";
            // 
            // frmAddComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlAddComponent);
            this.Name = "frmAddComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmAddComponent_Load);
            this.pnlAddComponent.ResumeLayout(false);
            this.pnlAddComponent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddComponent;
        private System.Windows.Forms.RichTextBox rtxDescription;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAddComponent;
    }
}