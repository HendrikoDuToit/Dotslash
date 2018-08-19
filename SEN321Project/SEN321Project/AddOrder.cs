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
    public partial class frmAddOrder : Form
    {
        private Administrator admin;
        private Order order;
        private List<OrderDetail> orderDetails = new List<OrderDetail>();
        private double price = 0;

        // Constructor
        public frmAddOrder(Administrator admin, List<OrderDetail> orderDetails)
        {
            InitializeComponent();
            this.admin = admin;
            this.orderDetails = orderDetails;
        }

        // Goes back to the main menu
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientManagement frmClientManagement = new frmClientManagement(admin);
            frmClientManagement.Show();

            order = null;
            orderDetails = null;
        }

        BindingSource bs = new BindingSource();

        // Binding all datasources to their components
        private void frmPlaceOrder_Load(object sender, EventArgs e)
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

            if (clientIDs.Count == 0)
            {
                btnAddProduct.Enabled = false;
                btnConfirmOrder.Enabled = false;
            }
            else
            {
                // Binding product data to respective combo boxes and text boxes
                Dictionary<int, string> dictionaryProductIDs = Product.GetProductIDs();
                List<string> ProductIDs = new List<string>();
                foreach (KeyValuePair<int, string> item in dictionaryProductIDs)
                {
                    ProductIDs.Add(item.Key.ToString() + " - " + item.Value);
                }
                bs.DataSource = ProductIDs;
                cmbProduct.DataSource = bs.DataSource;

                // Binding client data to respective combo boxes and text boxes
                bs.DataSource = clientIDs;
                cmbClient.DataSource = bs.DataSource;

                // Binding pamynet methods to the paymentmethod combobox.
                List<Payment> paymentMethods = Payment.GetPaymentMethodsFromDB();
                bs.DataSource = paymentMethods;
                cmbPaymentMethod.DataSource = bs.DataSource;
                cmbPaymentMethod.DisplayMember = "Description";
            }
        }

        // Gets the selected client from the database and displays its properties.
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clientID = cmbClient.SelectedValue.ToString();

            Client client = Client.GetClientFromDB(clientID);

            txtName.Text = client.Name;
            txtSurname.Text = client.Surname;
            dtpDateOfBirth.Value = client.DateOfBirth;
        }

        // Gets the selected product from the database and displays its properties.
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productID = int.Parse(cmbProduct.SelectedValue.ToString().Substring(0, cmbProduct.SelectedValue.ToString().IndexOf('-') - 1));

            Product product = Product.GetProductFromDB(productID);

            txtPrice.Text = product.Price.ToString();
        }

        // Adding products to a list of order details.
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(cmbProduct.SelectedValue.ToString().Substring(0, cmbProduct.SelectedValue.ToString().IndexOf('-') - 1));

            string productDescription = cmbProduct.SelectedValue.ToString().Remove(0, cmbProduct.SelectedValue.ToString().IndexOf('-') + 2);

            bool productAlreadyExists = false;

            int index = 0;

            for (int i = 0; i < orderDetails.Count; i++)
            {
                if (orderDetails[i].Product.ProductID == productID)
                {
                    index = i;
                    productAlreadyExists = true;
                }
            }

            if (!productAlreadyExists)
            {
                orderDetails.Add(new OrderDetail(0, new Product(productID, productDescription, 0, null), (int)nudQuantity.Value));

            }
            else
            {
                orderDetails[index].Quantity += (int)nudQuantity.Value;
            }

            price += (double)(nudQuantity.Value * int.Parse(txtPrice.Text));

            nudQuantity.Value = 1;
        }

        // Adding all the details to a new order object.
        private void btnProceed_Click(object sender, EventArgs e)
        {
            int paymentMethod = ((Payment)cmbPaymentMethod.SelectedValue).PaymentID;
            string clientID = cmbClient.SelectedValue.ToString();

            if (orderDetails.Count == 0)
            {
                MessageBox.Show("No products were added to the order!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                frmConfirmOrder frmConfirmOrder = new frmConfirmOrder(admin, orderDetails, clientID, paymentMethod, price);
                frmConfirmOrder.Show();
            }
        }

        // Stops the user from changing the client's combobox value.
        private void cmbClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Stops the user from changing the product's combobox value.
        private void cmbProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Stops the user from changing the numericupdown component's value.
        private void nudQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // // Stops the user from changing the payment method's combobox value.
        private void cmbPaymentMethod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Stops the user from changing the datepickers value.
        private void dtpDateOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
