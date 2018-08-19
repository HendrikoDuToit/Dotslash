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
    public partial class frmViewOrders : Form
    {
        private Administrator admin;

        public frmViewOrders(Administrator admin)
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

        // loads the form.
        private void frmViewOrders_Load(object sender, EventArgs e)
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

            bs.DataSource = clientIDs;

            cmbClient.DataSource = bs.DataSource;

            dgvClientOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        BindingSource bs2 = new BindingSource();

        // Gets orders from the database based on the client ID.
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clientID = cmbClient.SelectedValue.ToString();

            List<Order> orders = Order.GetOrderFromDB(clientID);

            bs2.DataSource = orders;

            dgvClientOrders.DataSource = bs2.DataSource;
        }

        BindingSource bs3 = new BindingSource();

        // Gets the order id from the dgv and then gets that order's order details from the database. 
        private void dgvClientOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID = int.Parse(dgvClientOrders.SelectedRows[0].Cells[0].Value.ToString());

            List<OrderDetail> orderDetails = OrderDetail.GetOrderDetailsFromDB(orderID);

            bs3.DataSource = orderDetails;

            dgvClientOrderDetails.DataSource = bs3.DataSource;
        }

        // Stops the user from changing the client's combobox values.
        private void cmbClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
