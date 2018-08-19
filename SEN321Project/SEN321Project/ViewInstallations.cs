using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace SEN321Project
{
    public partial class frmViewInstallations : Form
    {
        private Administrator admin;

        public frmViewInstallations(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
            frmTechnicalSupport.Show();
        }

        // Loads the form.
        private void frmViewInstallations_Load(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == "frmPhone")
                {
                    Form frmOpenPhone = form;
                    frmOpenPhone.Top = this.Top;
                    frmOpenPhone.Left = this.Right;
                }
            }

            dgvInstallations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cmbStatus.SelectedIndex = 0;

            chkInstalled.Checked = false;
        }

        BindingSource bs = new BindingSource();

        // Changes the dgv based on the combobox selection.
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDgv();
        }

        // Changes the dgv and the status of the status combobox.
        private void chkInstalled_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDgv();

            if (chkInstalled.Checked)
            {
                cmbStatus.Enabled = false;
            }
            else if (!chkInstalled.Checked)
            {
                cmbStatus.Enabled = true;
            }
        }

        // Cancels the installation.
        private void btnCancelInstallation_Click(object sender, EventArgs e)
        {
            int installationID = int.Parse(dgvInstallations.SelectedRows[0].Cells[0].Value.ToString());

            Installation.CancelInstallation(installationID);

            this.Hide();
            frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
            frmTechnicalSupport.Show();
        }

        // Finished the installation.
        private void btnFinishInstallation_Click(object sender, EventArgs e)
        {
            int installationID = int.Parse(dgvInstallations.SelectedRows[0].Cells[0].Value.ToString());

            Installation.FinishInstallation(installationID);

            this.Hide();
            frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
            frmTechnicalSupport.Show();
        }

        // Stops the user from changing the status combobox values.
        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Method for changing the dgv.
        private void ChangeDgv()
        {
            dgvInstallations.DataSource = null;
            bool assigned = false;
            bool installed = false;

            List<Installation> installations = new List<Installation>();

            if ((cmbStatus.SelectedIndex == 0) && (chkInstalled.Checked)) // 0 = assigned, 1 = unassigned
            {
                assigned = true;
                installed = true;
                btnFinishInstallation.Enabled = false;
                btnCancelInstallation.Enabled = false;
            }
            else if ((cmbStatus.SelectedIndex == 0) && (!chkInstalled.Checked))
            {
                assigned = true;
                installed = false;
                btnFinishInstallation.Enabled = true;
                btnCancelInstallation.Enabled = true;
            }
            else if ((cmbStatus.SelectedIndex == 1) && (!chkInstalled.Checked))
            {
                assigned = false;
                installed = false;
                btnFinishInstallation.Enabled = false;
                btnCancelInstallation.Enabled = false;
            }

            installations = Installation.GetInstallations(assigned, installed);

            if (installations.Count != 0)
            {
                bs.DataSource = installations;

                dgvInstallations.DataSource = bs.DataSource;

                dgvInstallations.Columns[0].HeaderText = "InstallationID";
                dgvInstallations.Columns[0].DataPropertyName = "InstallationID";
                dgvInstallations.Columns[1].HeaderText = "Installed";
                dgvInstallations.Columns[1].DataPropertyName = "Installed";
                dgvInstallations.Columns[2].Visible = false;
            }
        }
    }
}
