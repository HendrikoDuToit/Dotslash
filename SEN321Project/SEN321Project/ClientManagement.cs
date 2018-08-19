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
    public partial class frmClientManagement : Form
    {
        private Administrator admin;

        public frmClientManagement(Administrator admin)
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

        // Takes the user to the add client form.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddClient frmAddClient = new frmAddClient(admin);
            frmAddClient.Show();
        }

        // Takes the user to the update client form.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateClient frmUpdateClient = new frmUpdateClient(admin);
            frmUpdateClient.Show();
        }

        // Takes the user to the delete client form.
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteClient frmDeleteClient = new frmDeleteClient(admin);
            frmDeleteClient.Show();
        }

        // Takes the user to the add order form.
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddOrder frmAddOrder = new frmAddOrder(admin, new List<OrderDetail>());
            frmAddOrder.Show();
        }

        // Takes the user to the update order form.
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateOrder frmUpdateOrder = new frmUpdateOrder(admin);
            frmUpdateOrder.Show();
        }

        // Takes the user to the view orders form.
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewOrders frmViewOrders = new frmViewOrders(admin);
            frmViewOrders.Show();
        }

        // Loads the form.
        private void frmClientManagement_Load(object sender, EventArgs e)
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
