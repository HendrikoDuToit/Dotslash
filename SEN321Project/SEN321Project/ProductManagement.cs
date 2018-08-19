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
    public partial class frmProductManagement : Form
    {
        private Administrator admin;
        public frmProductManagement(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        // Takes the user back to the main menu.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu(admin);
            frmMainMenu.Show();
        }

        //Takes the user to the AddProduct form.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddProduct frmAddProduct = new frmAddProduct(admin, new List<ProductComponent>(), "", 0 );
            frmAddProduct.Show();
        }

        // Takes the user to the UpdateProduct form.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateProduct frmUpdateProduct = new frmUpdateProduct(admin);
            frmUpdateProduct.Show();
        }

        // Takes the user to the DeleteProduct form.
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteProduct frmDeleteProduct = new frmDeleteProduct(admin);
            frmDeleteProduct.Show();
        }

        // Loads the form.
        private void frmProductManagement_Load(object sender, EventArgs e)
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
        }

        // Answers the call.
        private void btnAnswerCall_Click(object sender, EventArgs e)
        {
            frmPhone frmPhone = new frmPhone(this.Top, this.Right, admin);
            frmPhone.StartPosition = FormStartPosition.Manual;
            frmPhone.Show();
        }
    }
}
