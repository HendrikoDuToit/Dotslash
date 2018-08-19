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
    public partial class frmDeleteClient : Form
    {
        private Administrator admin;

        public frmDeleteClient(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        // Sends the user back to the ClientManagement form.
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientManagement frmClientManagement = new frmClientManagement(admin);
            frmClientManagement.Show();
        }

        BindingSource bs = new BindingSource();

        // Loads the form.
        private void frmDeleteClient_Load(object sender, EventArgs e)
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

            bs.DataSource = Client.GetClientIDs();

            cmbClient.DataSource = bs.DataSource;

            if (bs.Count == 0)
            {
                btnDelete.Enabled = false;
            }
        }

        // Gets the selected client with all his / her details.
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clientID = cmbClient.SelectedValue.ToString();

            Client client = Client.GetClientFromDB(clientID);

            txtName.Text = client.Name;
            txtSurname.Text = client.Surname;
            txtDoB.Text = client.DateOfBirth.ToString();
            txtContract.Text = client.Contract;

            txtCity.Text = client.Address.City;
            txtStreet.Text = client.Address.Street;
            txtPostalCode.Text = client.Address.PostalCode;
        }

        // Deletes the selected client.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want do delete this client","Warning!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string clientID = cmbClient.SelectedValue.ToString();

                Client.DeleteClient(clientID);

                this.Hide();
                frmClientManagement frmClientManagement = new frmClientManagement(admin);
                frmClientManagement.Show();
            }


        }

        // Stops the user from changing the client combobox value.
        private void cmbClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
