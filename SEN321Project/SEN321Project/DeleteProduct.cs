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
    public partial class frmDeleteProduct : Form
    {
        private Dictionary<int, string> dictionaryProductIDs = new Dictionary<int, string>();

        private Administrator admin;

        public frmDeleteProduct(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        // Takes the user back to the ProductManagement form.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductManagement frmProductManagement = new frmProductManagement(admin );
            frmProductManagement.Show();
        }

        BindingSource bs = new BindingSource();

        // Loads the form.
        private void frmDeleteProduct_Load(object sender, EventArgs e)
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

            cmbProductID.DataSource = bs.DataSource;
        }

        // Gets the corresponding selected product's components and details.
        private void cmbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxDescription.Text = dictionaryProductIDs[int.Parse(cmbProductID.SelectedValue.ToString())];

            int productID = int.Parse(cmbProductID.SelectedValue.ToString());

            List<_Component> components = _Component.GetComponentsWithProductID(productID);

            Dictionary<int, Control> dictionaryComponents = new Dictionary<int, Control>() { { 1, txtComponent1 }, { 2, txtComponent2 }, { 3, txtComponent3 }, { 4, txtComponent4 } };

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

        // Sets the product as not available in the database.
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Product.DeleteProduct(int.Parse(cmbProductID.SelectedValue.ToString()));
        }

        // Stops the user from changing the value of the product combobox.
        private void cmbProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
