namespace SEN321Project
{
    partial class frmDeleteClient
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
            this.lblDeleteClient = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.pnlDeleteClient = new System.Windows.Forms.Panel();
            this.txtContract = new System.Windows.Forms.TextBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDoB = new System.Windows.Forms.TextBox();
            this.pnlDeleteClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(46, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // lblDeleteClient
            // 
            this.lblDeleteClient.AutoSize = true;
            this.lblDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteClient.Location = new System.Drawing.Point(167, 23);
            this.lblDeleteClient.Name = "lblDeleteClient";
            this.lblDeleteClient.Size = new System.Drawing.Size(183, 31);
            this.lblDeleteClient.TabIndex = 11;
            this.lblDeleteClient.Text = "Delete Client";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(178, 282);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 44);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(148, 81);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 13);
            this.lblClient.TabIndex = 64;
            this.lblClient.Text = "Client:";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(197, 78);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 21);
            this.cmbClient.TabIndex = 63;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            this.cmbClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbClient_KeyPress);
            // 
            // pnlDeleteClient
            // 
            this.pnlDeleteClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteClient.Controls.Add(this.txtContract);
            this.pnlDeleteClient.Controls.Add(this.lblContract);
            this.pnlDeleteClient.Controls.Add(this.lblName);
            this.pnlDeleteClient.Controls.Add(this.lblSurname);
            this.pnlDeleteClient.Controls.Add(this.lblDoB);
            this.pnlDeleteClient.Controls.Add(this.txtCity);
            this.pnlDeleteClient.Controls.Add(this.lblCity);
            this.pnlDeleteClient.Controls.Add(this.txtStreet);
            this.pnlDeleteClient.Controls.Add(this.lblStreet);
            this.pnlDeleteClient.Controls.Add(this.txtPostalCode);
            this.pnlDeleteClient.Controls.Add(this.lblPostalCode);
            this.pnlDeleteClient.Controls.Add(this.txtSurname);
            this.pnlDeleteClient.Controls.Add(this.txtName);
            this.pnlDeleteClient.Controls.Add(this.txtDoB);
            this.pnlDeleteClient.Controls.Add(this.lblDeleteClient);
            this.pnlDeleteClient.Controls.Add(this.lblClient);
            this.pnlDeleteClient.Controls.Add(this.btnDelete);
            this.pnlDeleteClient.Controls.Add(this.btnBack);
            this.pnlDeleteClient.Controls.Add(this.cmbClient);
            this.pnlDeleteClient.Location = new System.Drawing.Point(12, 12);
            this.pnlDeleteClient.Name = "pnlDeleteClient";
            this.pnlDeleteClient.Size = new System.Drawing.Size(504, 344);
            this.pnlDeleteClient.TabIndex = 66;
            // 
            // txtContract
            // 
            this.txtContract.Location = new System.Drawing.Point(206, 240);
            this.txtContract.Name = "txtContract";
            this.txtContract.ReadOnly = true;
            this.txtContract.Size = new System.Drawing.Size(121, 20);
            this.txtContract.TabIndex = 80;
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContract.Location = new System.Drawing.Point(141, 243);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(59, 13);
            this.lblContract.TabIndex = 79;
            this.lblContract.Text = "Contract:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 13);
            this.lblName.TabIndex = 66;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(44, 157);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(60, 13);
            this.lblSurname.TabIndex = 67;
            this.lblSurname.Text = "Surname:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoB.Location = new System.Drawing.Point(19, 201);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(85, 13);
            this.lblDoB.TabIndex = 68;
            this.lblDoB.Text = "Date Of Birth:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(347, 114);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 77;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(307, 117);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 13);
            this.lblCity.TabIndex = 69;
            this.lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(347, 154);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 76;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(296, 157);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(45, 13);
            this.lblStreet.TabIndex = 70;
            this.lblStreet.Text = "Street:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(347, 198);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.ReadOnly = true;
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 75;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(262, 201);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(79, 13);
            this.lblPostalCode.TabIndex = 71;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(110, 154);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 74;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(110, 114);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 72;
            // 
            // txtDoB
            // 
            this.txtDoB.Location = new System.Drawing.Point(110, 198);
            this.txtDoB.Name = "txtDoB";
            this.txtDoB.ReadOnly = true;
            this.txtDoB.Size = new System.Drawing.Size(100, 20);
            this.txtDoB.TabIndex = 73;
            // 
            // frmDeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(528, 368);
            this.Controls.Add(this.pnlDeleteClient);
            this.Name = "frmDeleteClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Home Systems";
            this.Load += new System.EventHandler(this.frmDeleteClient_Load);
            this.pnlDeleteClient.ResumeLayout(false);
            this.pnlDeleteClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDeleteClient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Panel pnlDeleteClient;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDoB;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.TextBox txtContract;
    }
}