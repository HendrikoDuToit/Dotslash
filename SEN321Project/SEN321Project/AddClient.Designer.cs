namespace SEN321Project
{
    partial class frmAddClient
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
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPoBox = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddClient = new System.Windows.Forms.Label();
            this.pnlAddClient = new System.Windows.Forms.Panel();
            this.lblPostalCodeHelp = new System.Windows.Forms.Label();
            this.lblStreetHelp = new System.Windows.Forms.Label();
            this.lblCityHelp = new System.Windows.Forms.Label();
            this.lblSurnameHelp = new System.Windows.Forms.Label();
            this.lblNameHelp = new System.Windows.Forms.Label();
            this.lblContract = new System.Windows.Forms.Label();
            this.cmbContract = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(189, 263);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(149, 44);
            this.btnAddClient.TabIndex = 35;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(361, 95);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 34;
            this.txtCity.Text = "Pretoria";
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(361, 135);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 33;
            this.txtStreet.Text = "Sunbird";
            this.txtStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStreet_KeyPress);
            this.txtStreet.Validating += new System.ComponentModel.CancelEventHandler(this.txtStreet_Validating);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(361, 179);
            this.txtPostalCode.MaxLength = 4;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 32;
            this.txtPostalCode.Text = "0156";
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostalCode_KeyPress);
            this.txtPostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtPostalCode_Validating);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(102, 135);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 31;
            this.txtSurname.Text = "du Toit";
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(102, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 29;
            this.txtName.Text = "Hendriko";
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblPoBox
            // 
            this.lblPoBox.AutoSize = true;
            this.lblPoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoBox.Location = new System.Drawing.Point(276, 183);
            this.lblPoBox.Name = "lblPoBox";
            this.lblPoBox.Size = new System.Drawing.Size(79, 13);
            this.lblPoBox.TabIndex = 28;
            this.lblPoBox.Text = "Postal Code:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(310, 138);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(45, 13);
            this.lblStreet.TabIndex = 27;
            this.lblStreet.Text = "Street:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(321, 98);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 13);
            this.lblCity.TabIndex = 26;
            this.lblCity.Text = "City:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(11, 182);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(85, 13);
            this.lblDoB.TabIndex = 25;
            this.lblDoB.Text = "Date Of Birth:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(36, 138);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 13);
            this.lblSurname.TabIndex = 24;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(53, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name:";
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClient.Location = new System.Drawing.Point(153, 37);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(215, 31);
            this.lblAddClient.TabIndex = 36;
            this.lblAddClient.Text = "Add New Client";
            // 
            // pnlAddClient
            // 
            this.pnlAddClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddClient.Controls.Add(this.lblPostalCodeHelp);
            this.pnlAddClient.Controls.Add(this.lblStreetHelp);
            this.pnlAddClient.Controls.Add(this.lblCityHelp);
            this.pnlAddClient.Controls.Add(this.lblSurnameHelp);
            this.pnlAddClient.Controls.Add(this.lblNameHelp);
            this.pnlAddClient.Controls.Add(this.lblContract);
            this.pnlAddClient.Controls.Add(this.cmbContract);
            this.pnlAddClient.Controls.Add(this.dtpDateOfBirth);
            this.pnlAddClient.Controls.Add(this.btnBack);
            this.pnlAddClient.Controls.Add(this.lblAddClient);
            this.pnlAddClient.Controls.Add(this.lblName);
            this.pnlAddClient.Controls.Add(this.lblSurname);
            this.pnlAddClient.Controls.Add(this.btnAddClient);
            this.pnlAddClient.Controls.Add(this.lblDoB);
            this.pnlAddClient.Controls.Add(this.txtCity);
            this.pnlAddClient.Controls.Add(this.lblCity);
            this.pnlAddClient.Controls.Add(this.txtStreet);
            this.pnlAddClient.Controls.Add(this.lblStreet);
            this.pnlAddClient.Controls.Add(this.txtPostalCode);
            this.pnlAddClient.Controls.Add(this.lblPoBox);
            this.pnlAddClient.Controls.Add(this.txtSurname);
            this.pnlAddClient.Controls.Add(this.txtName);
            this.pnlAddClient.Location = new System.Drawing.Point(12, 12);
            this.pnlAddClient.Name = "pnlAddClient";
            this.pnlAddClient.Size = new System.Drawing.Size(504, 344);
            this.pnlAddClient.TabIndex = 38;
            // 
            // lblPostalCodeHelp
            // 
            this.lblPostalCodeHelp.AutoSize = true;
            this.lblPostalCodeHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPostalCodeHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCodeHelp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPostalCodeHelp.Location = new System.Drawing.Point(485, 183);
            this.lblPostalCodeHelp.Name = "lblPostalCodeHelp";
            this.lblPostalCodeHelp.Size = new System.Drawing.Size(14, 13);
            this.lblPostalCodeHelp.TabIndex = 45;
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
            this.lblStreetHelp.Location = new System.Drawing.Point(485, 138);
            this.lblStreetHelp.Name = "lblStreetHelp";
            this.lblStreetHelp.Size = new System.Drawing.Size(14, 13);
            this.lblStreetHelp.TabIndex = 44;
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
            this.lblCityHelp.Location = new System.Drawing.Point(485, 98);
            this.lblCityHelp.Name = "lblCityHelp";
            this.lblCityHelp.Size = new System.Drawing.Size(14, 13);
            this.lblCityHelp.TabIndex = 43;
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
            this.lblSurnameHelp.Location = new System.Drawing.Point(224, 138);
            this.lblSurnameHelp.Name = "lblSurnameHelp";
            this.lblSurnameHelp.Size = new System.Drawing.Size(14, 13);
            this.lblSurnameHelp.TabIndex = 42;
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
            this.lblNameHelp.Location = new System.Drawing.Point(224, 98);
            this.lblNameHelp.Name = "lblNameHelp";
            this.lblNameHelp.Size = new System.Drawing.Size(14, 13);
            this.lblNameHelp.TabIndex = 41;
            this.lblNameHelp.Text = "?";
            this.lblNameHelp.Visible = false;
            this.lblNameHelp.MouseHover += new System.EventHandler(this.lblNameHelp_MouseHover);
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.Location = new System.Drawing.Point(152, 228);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(59, 13);
            this.lblContract.TabIndex = 40;
            this.lblContract.Text = "Contract:";
            // 
            // cmbContract
            // 
            this.cmbContract.FormattingEnabled = true;
            this.cmbContract.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbContract.Location = new System.Drawing.Point(217, 225);
            this.cmbContract.Name = "cmbContract";
            this.cmbContract.Size = new System.Drawing.Size(121, 21);
            this.cmbContract.TabIndex = 39;
            this.cmbContract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbContract_KeyPress);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(102, 176);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1910, 2, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.dtpDateOfBirth.TabIndex = 38;
            this.dtpDateOfBirth.Value = new System.DateTime(1910, 2, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpDateOfBirth_KeyUp);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlAddClient);
            this.Name = "frmAddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Security";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.pnlAddClient.ResumeLayout(false);
            this.pnlAddClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPoBox;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddClient;
        private System.Windows.Forms.Panel pnlAddClient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.ComboBox cmbContract;
        private System.Windows.Forms.Label lblNameHelp;
        private System.Windows.Forms.Label lblSurnameHelp;
        private System.Windows.Forms.Label lblPostalCodeHelp;
        private System.Windows.Forms.Label lblStreetHelp;
        private System.Windows.Forms.Label lblCityHelp;
    }
}