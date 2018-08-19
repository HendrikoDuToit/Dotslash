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
    public partial class frmAddComponent : Form
    {
        private string description = "";
        private double price = 0;

        private Administrator admin;

        public frmAddComponent(Administrator admin, string description, double price)
        {
            InitializeComponent();
            this.admin = admin;
            this.description = description;
            this.price = price;
        }

        private void frmAddComponent_Load(object sender, EventArgs e)
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
        }

        // Sends you back to the AddProduct form.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddProduct frmAddProduct = new frmAddProduct(admin, new List<ProductComponent>(), description, price);
            frmAddProduct.Show();
        }

        // Adds the component to the database.
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string description = "";

            if (rtxDescription.Text == "")
            {
                MessageBox.Show("Component needs a description!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                description = rtxDescription.Text;

                _Component component = new _Component(0, description);

                component.AddComponent();
            }
        }

        // Validates the description richtext.
        private void rtxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetterOrDigit)))
            {
                e.Handled = true;
            }
        }
    }
}
