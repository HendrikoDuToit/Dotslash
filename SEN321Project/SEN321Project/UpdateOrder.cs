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
    public partial class frmUpdateOrder : Form
    {
        private Administrator admin;

        public frmUpdateOrder(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        // Sends the user back to the ClientManagement form.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientManagement frmClientManagement = new frmClientManagement(admin);
            frmClientManagement.Show();
        }

        BindingSource bs = new BindingSource();

        // Loads the form.
        private void frmUpdateOrder_Load(object sender, EventArgs e)
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

            List<int> orderIDs = Order.GetOrderIDs(false);

            bs.DataSource = orderIDs;

            cmbOrder.DataSource = bs.DataSource;

            if (orderIDs.Count == 0)
            {
                btnFinishOrder.Enabled = false;
                btnCancelOrder.Enabled = false;
            }
        }

        // Gets the details of the selected order in the combobox.
        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderID = int.Parse(cmbOrder.SelectedValue.ToString());

            List<Order> orders = Order.GetOrderFromDB(orderID, false);

            txtClientID.Text = orders[0].ClientID;
            txtPaymentMethod.Text = orders[0].PaymentMethod.ToString();
            txtPrice.Text = orders[0].Price.ToString();
            txtOrderDate.Text = orders[0].OrderDate.ToString();
            chkDelivered.Checked = orders[0].Delivered;
        }

        // Finished the order. Setting it to delivered in the database.
        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(cmbOrder.SelectedValue.ToString());

            frmUpdateOrder frmUpdateOrder = new frmUpdateOrder(admin);
            frmAddInstallation frmAssignTechnicians = new frmAddInstallation(admin, true, orderID);

            if (MessageBox.Show("Mark Order Number: " + orderID + " as Delivered? ", "Confirm",  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Order.FinishOrder(orderID);

                if (MessageBox.Show("Assign a technician to install the ordered products for Order: " + orderID + "? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Hide();
                    frmAssignTechnicians.Show();
                }
                else
                {
                    this.Hide();
                    frmUpdateOrder.Show();
                }
            }
            else
            {
                this.Hide();
                frmUpdateOrder.Show();
            }
        }

        // Removes the order fro mthe database.
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(cmbOrder.SelectedValue.ToString());

            Order.CancelOrder(orderID);

            frmUpdateOrder frmUpdateOrder = new frmUpdateOrder(admin);
            this.Hide();
            frmUpdateOrder.Show();
        }

        // Stops the user from changing the order combobox values.
        private void cmbOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
