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
    public partial class frmConfirmProduct : Form
    {
        private Administrator admin;
        private List<ProductComponent> productComponents = new List<ProductComponent>();
        private string description = "";
        private double price = 0;

        public frmConfirmProduct(Administrator admin, List<ProductComponent> productComponents, string description, double price)
        {
            InitializeComponent();
            this.admin = admin;
            this.productComponents = productComponents;
            this.description = description;
            this.price = price;
        }

        // Sends the user back to the AddProduct form.
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddProduct frmAddProduct = new frmAddProduct(admin, productComponents, description, price);
            frmAddProduct.Show();
        }

        // Loads the form.
        private void frmConfirmProduct_Load(object sender, EventArgs e)
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

            List<_Component> _components = new List<_Component>();

            for (int i = 0; i < productComponents.Count; i++)
            {
                _components.Add(productComponents[i].Component);
            }

            dgvProductDetails.RowCount = _components.Count;

            for (int i = 0; i < _components.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        dgvProductDetails.Rows[i].Cells[j].Value = _components[i].ComponentID.ToString();
                    }
                    if (j == 1)
                    {
                        
                        dgvProductDetails.Rows[i].Cells[j].Value = _components[i].Description;
                    }
                    if (j == 2)
                    {
                        dgvProductDetails.Rows[i].Cells[j].Value = productComponents[i].Quantity;
                    }
                }
            }
        }

        // Confirms the product and adds it to the database.
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Product product = new Product(0, description, price, productComponents);

            product.AddProduct();

            this.Hide();
            frmProductManagement frmProductManagement = new frmProductManagement(admin);
            frmProductManagement.Show();
        }
    }
}
