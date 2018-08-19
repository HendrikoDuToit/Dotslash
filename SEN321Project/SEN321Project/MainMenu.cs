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
using System.Threading;
using System.Resources;

namespace SEN321Project
{
    public partial class frmMainMenu : Form
    {
        private bool callAnswerred = false;
        private Administrator admin;

        public frmMainMenu(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        // This button is used to go back to the login screen and reset the currently logged in employee.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form frmOpenPhone = new Form();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == "frmPhone")
                {
                    frmOpenPhone = form;
                }
            }

            if (frmOpenPhone.Name != "")
            {
                MessageBox.Show("You cannot log out while still being on a call!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();

                admin = null;
            }

        }

        // Loads the form.
        private void frmMenu_Load(object sender, EventArgs e)
        {
            Form frmOpenPhone = new Form();

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == "frmPhone")
                {
                    frmOpenPhone = form;
                    frmOpenPhone.Top = this.Top;
                    frmOpenPhone.Left = this.Right;
                }
            }

            Thread thread = new Thread(() =>
            {
                Random ran = new Random();

                int random = 0;

                while (random != 5)
                {
                    random = ran.Next(0, 7);
                    Thread.Sleep(500);
                }

                do
                {
                    btnAnswerCall.BackgroundImage = Properties.Resources.Answer;
                    btnAnswerCall.BackgroundImage = Properties.Resources.Answer1;
                } while (!callAnswerred);

                btnAnswerCall.BackgroundImage = Properties.Resources.Answer;

            });
            thread.Start();
        }

        // This button takes the user to the client management menu
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmClientManagement frmClientManagement = new frmClientManagement(admin);
            frmClientManagement.Show();
        }

        // This button takes the user to the product management menu
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductManagement frmProductManagement = new frmProductManagement(admin);
            frmProductManagement.Show();
        }

        // This button takes the user to the technical support menu
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
            frmTechnicalSupport.Show();
        }

        // Answers the phone.
        private void button1_Click(object sender, EventArgs e)
        {
            callAnswerred = true;
            frmPhone frmPhone = new frmPhone(this.Top, this.Right, admin);
            frmPhone.StartPosition = FormStartPosition.Manual;
            frmPhone.Show();
        }

        private void btnViewCalls_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCallHistory frmCallHistory = new frmCallHistory(admin);
            frmCallHistory.Show();
        }
    }
}
