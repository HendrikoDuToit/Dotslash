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
    public partial class frmAddInstallation : Form
    {
        private Administrator admin;
        private bool updateOrder;
        private int orderID = 0;

        public frmAddInstallation(Administrator admin, bool updateOrder, int orderID)
        {
            InitializeComponent();
            this.admin = admin;
            this.updateOrder = updateOrder;
            this.orderID = orderID;
        }

        // Gets all orders and technicians from the database.
        private void frmAssignTechnicians_Load(object sender, EventArgs e)
        {
            // Searches for the phone form. If it's open, the phone's form's position is adjusted.
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == "frmPhone")
                {
                    Form frmOpenPhone = form;
                    frmOpenPhone.Top = this.Top;
                    frmOpenPhone.Left = this.Right;
                }
            }

            bool delivered = true;
            bool installed = false;
            bool assigned = false;

            List<int> orderIDs = Order.GetOrderIDs(delivered, installed, assigned);

            if (orderIDs.Count != 0)
            {
                bs.DataSource = orderIDs;
                cmbOrder.DataSource = bs.DataSource;

                if (orderID != 0)
                {
                    for (int i = 0; i < orderIDs.Count; i++)
                    {
                        if (int.Parse(cmbOrder.Items[i].ToString()) == orderID)
                        {
                            cmbOrder.SelectedIndex = i;
                        }
                    }
                }

                List<int> technicianIDs = Technician.GetAvailableTechnicianIDs();

                if (technicianIDs.Count == 0)
                {
                    btnAddInstallation.Enabled = false;
                    cmbTechnician.Enabled = false;
                    lblTechniciansUnavailable.Visible = true;
                }

                bs.DataSource = technicianIDs;
                cmbTechnician.DataSource = bs.DataSource;
            }
            else
            {
                btnAddInstallation.Enabled = false;
            }
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            if (updateOrder)
            {
                this.Hide();
                frmClientManagement frmClientManagement = new frmClientManagement(admin);
                frmClientManagement.Show();
            }
            else
            {
                this.Hide();
                frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
                frmTechnicalSupport.Show();
            }

        }

        BindingSource bs = new BindingSource();

        // Takes the selected order and populates the text fields with that order's details.
        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderID = int.Parse(cmbOrder.SelectedValue.ToString());

            List<Order> orders = Order.GetOrderFromDB(orderID);

            txtClientID.Text = orders[0].ClientID;
            txtOrderDate.Text = orders[0].OrderDate.ToString();
            txtPrice.Text = orders[0].Price.ToString();
            txtPaymentMethod.Text = orders[0].PaymentMethod.ToString();
        }
        
        // Adds a new installation to the database.
        private void btnAddInstallation_Click(object sender, EventArgs e)
        {
            Installation installation = new Installation(0, false, new Technician(int.Parse(cmbTechnician.SelectedValue.ToString())));

            Installation.AddInstallation(installation, int.Parse(cmbOrder.SelectedValue.ToString()));

            this.Hide();
            frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
            frmTechnicalSupport.Show();
        }

        // Stops the user from changing the combobox value for the order.
        private void cmbOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Stops the user from changing the combobox value for the technician.
        private void cmbTechnician_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
