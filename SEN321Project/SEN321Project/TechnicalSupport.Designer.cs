namespace SEN321Project
{
    partial class frmTechnicalSupport
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
            this.pnlTechnicalSupport = new System.Windows.Forms.Panel();
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.btnFinishInstallation = new System.Windows.Forms.Button();
            this.btnViewTickets = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddInstallation = new System.Windows.Forms.Button();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.lblTechnicalSupport = new System.Windows.Forms.Label();
            this.pnlTechnicalSupport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTechnicalSupport
            // 
            this.pnlTechnicalSupport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTechnicalSupport.Controls.Add(this.btnAnswerCall);
            this.pnlTechnicalSupport.Controls.Add(this.btnFinishInstallation);
            this.pnlTechnicalSupport.Controls.Add(this.btnViewTickets);
            this.pnlTechnicalSupport.Controls.Add(this.btnBack);
            this.pnlTechnicalSupport.Controls.Add(this.btnAddInstallation);
            this.pnlTechnicalSupport.Controls.Add(this.btnAddTicket);
            this.pnlTechnicalSupport.Controls.Add(this.lblTechnicalSupport);
            this.pnlTechnicalSupport.Location = new System.Drawing.Point(12, 12);
            this.pnlTechnicalSupport.Name = "pnlTechnicalSupport";
            this.pnlTechnicalSupport.Size = new System.Drawing.Size(504, 344);
            this.pnlTechnicalSupport.TabIndex = 10;
            // 
            // btnAnswerCall
            // 
            this.btnAnswerCall.BackgroundImage = global::SEN321Project.Properties.Resources.Answer;
            this.btnAnswerCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnswerCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswerCall.Location = new System.Drawing.Point(417, 3);
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.Size = new System.Drawing.Size(82, 37);
            this.btnAnswerCall.TabIndex = 22;
            this.btnAnswerCall.UseVisualStyleBackColor = true;
            this.btnAnswerCall.Click += new System.EventHandler(this.btnAnswerCall_Click);
            // 
            // btnFinishInstallation
            // 
            this.btnFinishInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishInstallation.Location = new System.Drawing.Point(294, 122);
            this.btnFinishInstallation.Name = "btnFinishInstallation";
            this.btnFinishInstallation.Size = new System.Drawing.Size(149, 44);
            this.btnFinishInstallation.TabIndex = 21;
            this.btnFinishInstallation.Text = "View Installations";
            this.btnFinishInstallation.UseVisualStyleBackColor = true;
            this.btnFinishInstallation.Click += new System.EventHandler(this.btnFinishInstallation_Click);
            // 
            // btnViewTickets
            // 
            this.btnViewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTickets.Location = new System.Drawing.Point(294, 203);
            this.btnViewTickets.Name = "btnViewTickets";
            this.btnViewTickets.Size = new System.Drawing.Size(149, 44);
            this.btnViewTickets.TabIndex = 20;
            this.btnViewTickets.Text = "View Tickets";
            this.btnViewTickets.UseVisualStyleBackColor = true;
            this.btnViewTickets.Click += new System.EventHandler(this.button3_Click_1);
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
            // btnAddInstallation
            // 
            this.btnAddInstallation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstallation.Location = new System.Drawing.Point(77, 122);
            this.btnAddInstallation.Name = "btnAddInstallation";
            this.btnAddInstallation.Size = new System.Drawing.Size(149, 44);
            this.btnAddInstallation.TabIndex = 10;
            this.btnAddInstallation.Text = "Add Installation";
            this.btnAddInstallation.UseVisualStyleBackColor = true;
            this.btnAddInstallation.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.Location = new System.Drawing.Point(77, 203);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(149, 44);
            this.btnAddTicket.TabIndex = 9;
            this.btnAddTicket.Text = "Add Ticket";
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTechnicalSupport
            // 
            this.lblTechnicalSupport.AutoSize = true;
            this.lblTechnicalSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnicalSupport.Location = new System.Drawing.Point(134, 30);
            this.lblTechnicalSupport.Name = "lblTechnicalSupport";
            this.lblTechnicalSupport.Size = new System.Drawing.Size(250, 31);
            this.lblTechnicalSupport.TabIndex = 3;
            this.lblTechnicalSupport.Text = "Technical Support";
            // 
            // frmTechnicalSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlTechnicalSupport);
            this.Name = "frmTechnicalSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmTechnicalSupport_Load);
            this.pnlTechnicalSupport.ResumeLayout(false);
            this.pnlTechnicalSupport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTechnicalSupport;
        private System.Windows.Forms.Button btnAddInstallation;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.Label lblTechnicalSupport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewTickets;
        private System.Windows.Forms.Button btnFinishInstallation;
        private System.Windows.Forms.Button btnAnswerCall;
    }
}