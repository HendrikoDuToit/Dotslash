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
    public partial class frmLogin : Form
    {
        private Administrator admin;

        public frmLogin()
        {
            InitializeComponent();
        }

        // Loads the form.
        private void Form1_Load(object sender, EventArgs e)
        {
            helpProvider1.SetShowHelp(this.txtPassword, true);
            helpProvider1.SetShowHelp(this.txtUsername, true);
        }

        // Logging into the system. This is where the login validation happens
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            admin = Login.VerifyLogin(username, password);

            if (admin != null)
            {
                this.Hide();
                frmMainMenu frmMenu = new frmMainMenu(admin);
                frmMenu.Show();
            }
        }

    }
}
