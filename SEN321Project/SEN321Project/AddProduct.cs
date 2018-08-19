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
    public partial class frmAddProduct : Form
    {
        bool priceEntered = false;

        List<_Component> _components = new List<_Component>();
        List<ProductComponent> productComponents = new List<ProductComponent>();
        private string description = "";
        private double price = 0;

        private Administrator admin;

        public frmAddProduct(Administrator admin, List<ProductComponent> productComponents, string description, double price)
        {
            InitializeComponent();
            this.admin = admin;
            this.productComponents = productComponents;
            this.description = description;
            this.price = price;
        }

        //  Sends the user back to the ProductManagement form.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductManagement frmProductManagement = new frmProductManagement(admin);
            frmProductManagement.Show();
        }

        // Sends the user to the AddComponent form.
        private void label10_Click(object sender, EventArgs e)
        {
            description = rtxDescription.Text;
            price = double.Parse(txtPrice.Text);

            this.Hide();
            frmAddComponent frmAddComponent = new frmAddComponent(admin, description, price);
            frmAddComponent.Show();
        }

        BindingSource bs = new BindingSource();

        // Loads all necessary data into the form.
        private void frmAddProduct_Load(object sender, EventArgs e)
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

            txtPrice.Text = price.ToString();
            rtxDescription.Text = description;

            Dictionary<int, string> dictionairyComponentIDs = ClassLibrary._Component.GetComponentIDs();
            List<string> listComponentIDs = new List<string>();

            foreach (KeyValuePair<int, string> item in dictionairyComponentIDs)
            {
                listComponentIDs.Add(item.Key.ToString() + " - " + item.Value);
            }

            bs.DataSource = listComponentIDs;

            cmbComponent.DataSource = bs.DataSource;

        }

        // Adds components to the product.
        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            nudAmount.Value = 1;

            int componentID = int.Parse(cmbComponent.SelectedValue.ToString().Substring(0, cmbComponent.SelectedValue.ToString().IndexOf('-') - 1));

            string componentDescription = cmbComponent.SelectedValue.ToString().Remove(0, cmbComponent.SelectedValue.ToString().IndexOf('-') + 2);

            int quantity = int.Parse(nudAmount.Value.ToString());

            bool alreadyExist = false;

            for (int i = 0; i < productComponents.Count; i++)
            {
                if (productComponents[i].Component.ComponentID == componentID)
                {
                    alreadyExist = true;

                    if (alreadyExist)
                    {
                        productComponents[i].Quantity += quantity;
                    }
                }
            }

            if (!alreadyExist)
            {
                _components.Add(new _Component(componentID, componentDescription));

                productComponents.Add(new ProductComponent(new _Component(componentID, componentDescription), quantity));
            }
        }

        // Takes the user to the ConfirmProduct form where he / she can confirm the product and then add it to the database.
        private void btnConfirmProduct_Click(object sender, EventArgs e)
        {
            description = rtxDescription.Text;

            if ((productComponents.Count != 0) && (description != "") && (productComponents.Count != 0) && (txtPrice.Text != ""))
            {
                price = double.Parse(txtPrice.Text);

                this.Hide();
                frmConfirmProduct frmConfirmProduct = new frmConfirmProduct(admin, productComponents, description, price);
                frmConfirmProduct.Show();
            }
            else if (description == "")
            {
                MessageBox.Show("Product needs a description!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (productComponents.Count == 0)
            {
                MessageBox.Show("No components were added to the product!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("No price for the product was given!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPrice.Text == "0")
            {
                MessageBox.Show("The price for the product cannot be 0!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validates the input for the price text box.
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsDigit)))
            {
                e.Handled = true;
                if (e.KeyChar.ToString().All(char.IsControl))
                {
                    e.Handled = false;
                }
            }
        }

        // Clears the price text box when the user enters it.
        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (!priceEntered)
            {
                txtPrice.Clear();
            }

            priceEntered = true;
        }

        // Stops the user from changing the value of the component combobox.
        private void cmbComponent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Validates the richedit text.
        private void rtxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetterOrDigit)))
            {
                e.Handled = true;
            }
        }

        // Stops the user from entering values into the nud.
        private void nudAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
