namespace SEN321Project
{
    partial class frmClientManagement
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
            this.pnlClientManagement = new System.Windows.Forms.Panel();
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnUpdateOrders = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.lblClientManagement = new System.Windows.Forms.Label();
            this.pnlClientManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClientManagement
            // 
            this.pnlClientManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientManagement.Controls.Add(this.btnAnswerCall);
            this.pnlClientManagement.Controls.Add(this.btnViewOrders);
            this.pnlClientManagement.Controls.Add(this.btnUpdateOrders);
            this.pnlClientManagement.Controls.Add(this.btnAddOrder);
            this.pnlClientManagement.Controls.Add(this.btnBack);
            this.pnlClientManagement.Controls.Add(this.btnDeleteClient);
            this.pnlClientManagement.Controls.Add(this.btnUpdateClient);
            this.pnlClientManagement.Controls.Add(this.btnAddNewClient);
            this.pnlClientManagement.Controls.Add(this.lblClientManagement);
            this.pnlClientManagement.Location = new System.Drawing.Point(12, 12);
            this.pnlClientManagement.Name = "pnlClientManagement";
            this.pnlClientManagement.Size = new System.Drawing.Size(504, 344);
            this.pnlClientManagement.TabIndex = 0;
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
            // btnViewOrders
            // 
            this.btnViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(274, 247);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(149, 44);
            this.btnViewOrders.TabIndex = 21;
            this.btnViewOrders.Text = "View Client Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnUpdateOrders
            // 
            this.btnUpdateOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrders.Location = new System.Drawing.Point(274, 175);
            this.btnUpdateOrders.Name = "btnUpdateOrders";
            this.btnUpdateOrders.Size = new System.Drawing.Size(149, 44);
            this.btnUpdateOrders.TabIndex = 20;
            this.btnUpdateOrders.Text = "Update Client Orders";
            this.btnUpdateOrders.UseVisualStyleBackColor = true;
            this.btnUpdateOrders.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(274, 97);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(149, 44);
            this.btnAddOrder.TabIndex = 19;
            this.btnAddOrder.Text = "Add New Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(74, 247);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(149, 44);
            this.btnDeleteClient.TabIndex = 17;
            this.btnDeleteClient.Text = "Delete An Existing Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(74, 175);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(149, 44);
            this.btnUpdateClient.TabIndex = 16;
            this.btnUpdateClient.Text = "Update An Existing Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClient.Location = new System.Drawing.Point(74, 97);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(149, 44);
            this.btnAddNewClient.TabIndex = 15;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblClientManagement
            // 
            this.lblClientManagement.AutoSize = true;
            this.lblClientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientManagement.Location = new System.Drawing.Point(129, 30);
            this.lblClientManagement.Name = "lblClientManagement";
            this.lblClientManagement.Size = new System.Drawing.Size(265, 31);
            this.lblClientManagement.TabIndex = 14;
            this.lblClientManagement.Text = "Client Management";
            // 
            // frmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlClientManagement);
            this.Name = "frmClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmClientManagement_Load);
            this.pnlClientManagement.ResumeLayout(false);
            this.pnlClientManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClientManagement;
        private System.Windows.Forms.Label lblClientManagement;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnUpdateOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnAnswerCall;
    }
}