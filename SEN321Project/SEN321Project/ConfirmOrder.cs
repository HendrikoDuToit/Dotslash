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
    public partial class frmConfirmOrder : Form
    {
        private Administrator admin;

        public Administrator Admin
        {
            get { return this.admin; }
            set { this.admin = value; }
        }

        private List<OrderDetail> orderDetails = new List<OrderDetail>();
        private string clientID = "";
        private int paymentMethod = 0;
        private double price = 0;

        public frmConfirmOrder(Administrator admin, List<OrderDetail> orderDetails, string clientID, int paymentMethod, double price)
        {
            InitializeComponent();
            this.admin = admin;
            this.orderDetails = orderDetails;
            this.clientID = clientID;
            this.paymentMethod = paymentMethod;
            this.price = price;
        }

        BindingSource bs = new BindingSource();

        // Loads the form.
        private void frmConfirmOrder_Load(object sender, EventArgs e)
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

            dgvOrderDetails.RowCount = orderDetails.Count;

            for (int i = 0; i < orderDetails.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        dgvOrderDetails.Rows[i].Cells[j].Value = orderDetails[i].Product.ProductID;
                    }
                    if (j == 1)
                    {
                        dgvOrderDetails.Rows[i].Cells[j].Value = orderDetails[i].Product.Description;
                    }
                    if (j == 2)
                    {
                        dgvOrderDetails.Rows[i].Cells[j].Value = orderDetails[i].Quantity;
                    }
                }
            }
        }

        // Sends user back to the AddOrder form.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddOrder frmAddOrder = new frmAddOrder(admin, this.orderDetails);
            frmAddOrder.Show();
        }

        // Sends order data to the database.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add this order?","Warning!",MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Order order = new Order(0, clientID, paymentMethod, DateTime.Now, false, price, admin, new Installation(), orderDetails);

                order.AddOrder();

                this.Hide();
                frmClientManagement frmClientManagement = new frmClientManagement(admin);
                frmClientManagement.Show();
            }
        }
    }
}
