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
    public partial class frmAddTicket : Form
    {
        private Administrator admin;

        public frmAddTicket(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        // Takes the user back to the main menu.
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
            frmTechnicalSupport.Show();
        }
        
        BindingSource bs = new BindingSource();

        // Loads the form.
        private void frmAddTicket_Load(object sender, EventArgs e)
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

            List<string> clientIDs = Client.GetClientIDs();

            if (clientIDs.Count != 0)
            {
                bs.DataSource = clientIDs;

                cmbClient.DataSource = bs.DataSource;

                Dictionary<int, string> typesOfServices = Service.GetTypesOfServices();
                List<string> listTypesOfServices = new List<string>();

                foreach (KeyValuePair<int, string> item in typesOfServices)
                {
                    listTypesOfServices.Add(item.Key.ToString() + " - " + item.Value);
                }

                bs.DataSource = listTypesOfServices;

                cmbTypeOfService.DataSource = bs.DataSource;

                List<int> technicianIDs = Technician.GetAvailableTechnicianIDs();

                if (cmbProduct.Items.Count == 0)
                {
                    cmbProduct.Enabled = false;
                    btnSubmitTicket.Enabled = false;
                }

                if (technicianIDs.Count == 0)
                {
                    cmbTechnician.Enabled = false;
                    lblTechniciansUnavailable.Visible = true;
                }

                bs.DataSource = technicianIDs;

                cmbTechnician.DataSource = bs.DataSource;
            }
            else
            {
                btnSubmitTicket.Enabled = false;
            }

        }

        BindingSource bs2 = new BindingSource();

        // Executes everything that has to do with the index of the combobox.
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clientID = cmbClient.SelectedValue.ToString();
            bool delivered = true;
            bool installed = true;

            List<int> orderIDs = Order.GetOrderIDs(delivered, clientID, installed);

            cmbOrder.DataSource = null;
            bs2.DataSource = orderIDs;
            cmbOrder.DataSource = bs2.DataSource;

            if (cmbProduct.Items.Count != 0)
            {
                cmbProduct.Enabled = true;
                btnSubmitTicket.Enabled = true;
            }
        }

        // Executes everything that has to do with the index of the combobox.
        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrder.DataSource != null)
            {
                bs.DataSource = Product.GetProductIDs(int.Parse(cmbOrder.SelectedValue.ToString()));
                cmbProduct.DataSource = bs.DataSource;
            }
            else
            {
                cmbProduct.DataSource = null;
                cmbProduct.Enabled = false;
            }

        }

        // Submits the ticket to the database.
        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            if (rtxFaultDescription.Text == "")
            {
                MessageBox.Show("No description for the problem was provided!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string clientID = cmbClient.SelectedValue.ToString();

                string fault = rtxFaultDescription.Text;

                int typeOfServiceID = int.Parse(cmbTypeOfService.SelectedValue.ToString().Substring(0, cmbTypeOfService.SelectedValue.ToString().IndexOf('-')));

                int technicianID = 0;

                if (cmbTechnician.Items.Count != 0)
                {
                    technicianID = int.Parse(cmbTechnician.SelectedValue.ToString());
                }

                int productID = int.Parse(cmbProduct.SelectedValue.ToString().Substring(0, cmbProduct.SelectedValue.ToString().IndexOf('-')));

                Ticket ticket = new Ticket(0, clientID, fault, new Service(0, productID, typeOfServiceID, technicianID), DateTime.Now, true);

                ticket.AddTicket();

                this.Hide();
                frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
                frmTechnicalSupport.Show();
            }

        }

        // Validates the product combobox.
        private void cmbProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Validates the client combobox.
        private void cmbClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Validates the order combobox.
        private void cmbOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Validates the typeofservice combobox.
        private void cmbTypeOfService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Validates the technician combobox.
        private void cmbTechnician_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
