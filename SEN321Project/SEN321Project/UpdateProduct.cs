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
    public partial class frmUpdateProduct : Form
    {
        private Dictionary<int, string> dictionaryProductIDs = new Dictionary<int, string>();

        private Administrator admin;

        public frmUpdateProduct(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        // Takes the user back to the ClientManagement form.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductManagement frmProductManagement = new frmProductManagement(admin);
            frmProductManagement.Show();
        }

        // Updates the product in the database.
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(cmdProductID.SelectedValue.ToString()), rtxDescription.Text, double.Parse(txtPrice.Text), null);

            product.UpdateProduct();

            this.Hide();
            frmProductManagement frmProductManagement = new frmProductManagement(admin);
            frmProductManagement.Show();
        }

        BindingSource bs = new BindingSource();

        // Loads the form.
        private void frmUpdateProduct_Load(object sender, EventArgs e)
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

            dictionaryProductIDs = Product.GetProductIDs();
            List<string> listProductIDs = new List<string>();

            foreach (KeyValuePair<int, string> item in dictionaryProductIDs)
            {
                listProductIDs.Add(item.Key.ToString());
            }

            bs.DataSource = listProductIDs;

            cmdProductID.DataSource = bs.DataSource;
        }

        // Gets the product that is being chosen from within the combobox.
        private void cmdProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxDescription.Text = dictionaryProductIDs[int.Parse(cmdProductID.SelectedValue.ToString())];

            int productID = int.Parse(cmdProductID.SelectedValue.ToString());

            List<_Component> components = _Component.GetComponentsWithProductID(productID);

            Dictionary<int, Control> dictionaryComponents = new Dictionary<int, Control>() { {1, txtComponent1}, {2, txtComponent2}, {3, txtComponent3}, {4, txtComponent4}};

            for (int j = 1; j <= dictionaryComponents.Keys.Count; j++)
            {
                dictionaryComponents[j].Text = "";
            }

            if (components.Count != 0)
            {
                for (int i = 1; i < components.Count + 1; i++)
                {
                    if (components.Count <= dictionaryComponents.Keys.Count)
                    {
                        dictionaryComponents[i].Text = components[i - 1].Description;
                    }
                }
            }

            Product product = Product.GetProductFromDB(productID);

            txtPrice.Text = product.Price.ToString();
        }

        // Stops the user from changing the product's combobox values.
        private void cmdProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
