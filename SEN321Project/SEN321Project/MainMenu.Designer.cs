namespace SEN321Project
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnViewCalls = new System.Windows.Forms.Button();
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.btnTechnicalSupport = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnClientManagement = new System.Windows.Forms.Button();
            this.pnlMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(180, 38);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(155, 31);
            this.lblMainMenu.TabIndex = 3;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(3, 316);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainMenu.Controls.Add(this.btnViewCalls);
            this.pnlMainMenu.Controls.Add(this.btnAnswerCall);
            this.pnlMainMenu.Controls.Add(this.btnTechnicalSupport);
            this.pnlMainMenu.Controls.Add(this.btnProductManagement);
            this.pnlMainMenu.Controls.Add(this.btnClientManagement);
            this.pnlMainMenu.Controls.Add(this.lblMainMenu);
            this.pnlMainMenu.Controls.Add(this.btnLogOut);
            this.pnlMainMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(504, 344);
            this.pnlMainMenu.TabIndex = 9;
            // 
            // btnViewCalls
            // 
            this.btnViewCalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCalls.Location = new System.Drawing.Point(383, 316);
            this.btnViewCalls.Name = "btnViewCalls";
            this.btnViewCalls.Size = new System.Drawing.Size(116, 23);
            this.btnViewCalls.TabIndex = 13;
            this.btnViewCalls.Text = "View Call History";
            this.btnViewCalls.UseVisualStyleBackColor = true;
            this.btnViewCalls.Click += new System.EventHandler(this.btnViewCalls_Click);
            // 
            // btnAnswerCall
            // 
            this.btnAnswerCall.BackgroundImage = global::SEN321Project.Properties.Resources.Answer;
            this.btnAnswerCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnswerCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswerCall.Location = new System.Drawing.Point(417, 3);
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.Size = new System.Drawing.Size(82, 37);
            this.btnAnswerCall.TabIndex = 12;
            this.btnAnswerCall.UseVisualStyleBackColor = true;
            this.btnAnswerCall.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTechnicalSupport
            // 
            this.btnTechnicalSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnicalSupport.Location = new System.Drawing.Point(186, 230);
            this.btnTechnicalSupport.Name = "btnTechnicalSupport";
            this.btnTechnicalSupport.Size = new System.Drawing.Size(149, 44);
            this.btnTechnicalSupport.TabIndex = 11;
            this.btnTechnicalSupport.Text = "Technical Support";
            this.btnTechnicalSupport.UseVisualStyleBackColor = true;
            this.btnTechnicalSupport.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagement.Location = new System.Drawing.Point(186, 168);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(149, 44);
            this.btnProductManagement.TabIndex = 10;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClientManagement
            // 
            this.btnClientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientManagement.Location = new System.Drawing.Point(186, 106);
            this.btnClientManagement.Name = "btnClientManagement";
            this.btnClientManagement.Size = new System.Drawing.Size(149, 44);
            this.btnClientManagement.TabIndex = 9;
            this.btnClientManagement.Text = "Client Management";
            this.btnClientManagement.UseVisualStyleBackColor = true;
            this.btnClientManagement.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Button btnTechnicalSupport;
        private System.Windows.Forms.Button btnProductManagement;
        private System.Windows.Forms.Button btnClientManagement;
        private System.Windows.Forms.Button btnAnswerCall;
        private System.Windows.Forms.Button btnViewCalls;
    }
}