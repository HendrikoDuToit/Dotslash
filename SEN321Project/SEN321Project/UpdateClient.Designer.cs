namespace SEN321Project
{
    partial class frmUpdateClient
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
            this.components = new System.ComponentModel.Container();
            this.lblUpdateClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlUpdateClient = new System.Windows.Forms.Panel();
            this.lblPostalCodeHelp = new System.Windows.Forms.Label();
            this.lblStreetHelp = new System.Windows.Forms.Label();
            this.lblCityHelp = new System.Windows.Forms.Label();
            this.lblSurnameHelp = new System.Windows.Forms.Label();
            this.lblNameHelp = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblPoBox = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlUpdateClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUpdateClient
            // 
            this.lblUpdateClient.AutoSize = true;
            this.lblUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateClient.Location = new System.Drawing.Point(194, 22);
            this.lblUpdateClient.Name = "lblUpdateClient";
            this.lblUpdateClient.Size = new System.Drawing.Size(192, 31);
            this.lblUpdateClient.TabIndex = 47;
            this.lblUpdateClient.Text = "Update Client";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(146, 83);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 21);
            this.cmbClient.TabIndex = 48;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged_1);
            this.cmbClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbClient_KeyPress);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(91, 86);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 13);
            this.lblClient.TabIndex = 49;
            this.lblClient.Text = "Client:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(212, 254);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 44);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // pnlUpdateClient
            // 
            this.pnlUpdateClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateClient.Controls.Add(this.lblPostalCodeHelp);
            this.pnlUpdateClient.Controls.Add(this.lblStreetHelp);
            this.pnlUpdateClient.Controls.Add(this.lblCityHelp);
            this.pnlUpdateClient.Controls.Add(this.lblSurnameHelp);
            this.pnlUpdateClient.Controls.Add(this.lblNameHelp);
            this.pnlUpdateClient.Controls.Add(this.lblContract);
            this.pnlUpdateClient.Controls.Add(this.txtContract);
            this.pnlUpdateClient.Controls.Add(this.dtpDob);
            this.pnlUpdateClient.Controls.Add(this.lblName);
            this.pnlUpdateClient.Controls.Add(this.lblSurname);
            this.pnlUpdateClient.Controls.Add(this.lblDoB);
            this.pnlUpdateClient.Controls.Add(this.txtCity);
            this.pnlUpdateClient.Controls.Add(this.lblCity);
            this.pnlUpdateClient.Controls.Add(this.txtStreet);
            this.pnlUpdateClient.Controls.Add(this.lblStreet);
            this.pnlUpdateClient.Controls.Add(this.txtPostalCode);
            this.pnlUpdateClient.Controls.Add(this.lblPoBox);
            this.pnlUpdateClient.Controls.Add(this.txtSurname);
            this.pnlUpdateClient.Controls.Add(this.txtName);
            this.pnlUpdateClient.Controls.Add(this.lblUpdateClient);
            this.pnlUpdateClient.Controls.Add(this.btnBack);
            this.pnlUpdateClient.Controls.Add(this.btnUpdate);
            this.pnlUpdateClient.Controls.Add(this.lblClient);
            this.pnlUpdateClient.Controls.Add(this.cmbClient);
            this.pnlUpdateClient.Location = new System.Drawing.Point(12, 12);
            this.pnlUpdateClient.Name = "pnlUpdateClient";
            this.pnlUpdateClient.Size = new System.Drawing.Size(555, 339);
            this.pnlUpdateClient.TabIndex = 53;
            // 
            // lblPostalCodeHelp
            // 
            this.lblPostalCodeHelp.AutoSize = true;
            this.lblPostalCodeHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPostalCodeHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCodeHelp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPostalCodeHelp.Location = new System.Drawing.Point(499, 215);
            this.lblPostalCodeHelp.Name = "lblPostalCodeHelp";
            this.lblPostalCodeHelp.Size = new System.Drawing.Size(14, 13);
            this.lblPostalCodeHelp.TabIndex = 72;
            this.lblPostalCodeHelp.Text = "?";
            this.lblPostalCodeHelp.Visible = false;
            this.lblPostalCodeHelp.MouseHover += new System.EventHandler(this.lblPostalCodeHelp_MouseHover);
            // 
            // lblStreetHelp
            // 
            this.lblStreetHelp.AutoSize = true;
            this.lblStreetHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStreetHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetHelp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStreetHelp.Location = new System.Drawing.Point(499, 171);
            this.lblStreetHelp.Name = "lblStreetHelp";
            this.lblStreetHelp.Size = new System.Drawing.Size(14, 13);
            this.lblStreetHelp.TabIndex = 71;
            this.lblStreetHelp.Text = "?";
            this.lblStreetHelp.Visible = false;
            this.lblStreetHelp.MouseHover += new System.EventHandler(this.lblStreetHelp_MouseHover);
            // 
            // lblCityHelp
            // 
            this.lblCityHelp.AutoSize = true;
            this.lblCityHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCityHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityHelp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCityHelp.Location = new System.Drawing.Point(499, 131);
            this.lblCityHelp.Name = "lblCityHelp";
            this.lblCityHelp.Size = new System.Drawing.Size(14, 13);
            this.lblCityHelp.TabIndex = 70;
            this.lblCityHelp.Text = "?";
            this.lblCityHelp.Visible = false;
            this.lblCityHelp.MouseHover += new System.EventHandler(this.lblCityHelp_MouseHover);
            // 
            // lblSurnameHelp
            // 
            this.lblSurnameHelp.AutoSize = true;
            this.lblSurnameHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSurnameHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameHelp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSurnameHelp.Location = new System.Drawing.Point(263, 171);
            this.lblSurnameHelp.Name = "lblSurnameHelp";
            this.lblSurnameHelp.Size = new System.Drawing.Size(14, 13);
            this.lblSurnameHelp.TabIndex = 69;
            this.lblSurnameHelp.Text = "?";
            this.lblSurnameHelp.Visible = false;
            this.lblSurnameHelp.MouseHover += new System.EventHandler(this.lblSurnameHelp_MouseHover);
            // 
            // lblNameHelp
            // 
            this.lblNameHelp.AutoSize = true;
            this.lblNameHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameHelp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNameHelp.Location = new System.Drawing.Point(263, 131);
            this.lblNameHelp.Name = "lblNameHelp";
            this.lblNameHelp.Size = new System.Drawing.Size(14, 13);
            this.lblNameHelp.TabIndex = 68;
            this.lblNameHelp.Text = "?";
            this.lblNameHelp.Visible = false;
            this.lblNameHelp.MouseHover += new System.EventHandler(this.lblNameHelp_MouseHover);
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.Location = new System.Drawing.Point(316, 86);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(59, 13);
            this.lblContract.TabIndex = 67;
            this.lblContract.Text = "Contract:";
            // 
            // txtContract
            // 
            this.txtContract.Enabled = false;
            this.txtContract.Location = new System.Drawing.Point(383, 83);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(100, 20);
            this.txtContract.TabIndex = 66;
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(146, 212);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(100, 20);
            this.dtpDob.TabIndex = 65;
            this.dtpDob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDob_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(97, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(80, 171);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 13);
            this.lblSurname.TabIndex = 54;
            this.lblSurname.Text = "Surname:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(55, 215);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(85, 13);
            this.lblDoB.TabIndex = 55;
            this.lblDoB.Text = "Date Of Birth:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(383, 128);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 64;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(343, 131);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 13);
            this.lblCity.TabIndex = 56;
            this.lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(383, 168);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 63;
            this.txtStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStreet_KeyPress);
            this.txtStreet.Validating += new System.ComponentModel.CancelEventHandler(this.txtStreet_Validating);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(332, 171);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(45, 13);
            this.lblStreet.TabIndex = 57;
            this.lblStreet.Text = "Street:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(383, 212);
            this.txtPostalCode.MaxLength = 4;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 62;
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostalCode_KeyPress);
            this.txtPostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtPostalCode_Validating);
            // 
            // lblPoBox
            // 
            this.lblPoBox.AutoSize = true;
            this.lblPoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoBox.Location = new System.Drawing.Point(298, 215);
            this.lblPoBox.Name = "lblPoBox";
            this.lblPoBox.Size = new System.Drawing.Size(79, 13);
            this.lblPoBox.TabIndex = 58;
            this.lblPoBox.Text = "Postal Code:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(146, 168);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 61;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 59;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // frmUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(579, 363);
            this.Controls.Add(this.pnlUpdateClient);
            this.Name = "frmUpdateClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Security";
            this.Load += new System.EventHandler(this.frmUpdateClient_Load);
            this.pnlUpdateClient.ResumeLayout(false);
            this.pnlUpdateClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUpdateClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlUpdateClient;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPoBox;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.TextBox txtContract;
        private System.Windows.Forms.Label lblNameHelp;
        private System.Windows.Forms.Label lblSurnameHelp;
        private System.Windows.Forms.Label lblCityHelp;
        private System.Windows.Forms.Label lblStreetHelp;
        private System.Windows.Forms.Label lblPostalCodeHelp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}