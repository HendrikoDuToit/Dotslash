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
    public partial class frmTechnicalSupport : Form
    {
        private Administrator admin;

        public frmTechnicalSupport(Administrator admin)
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

        // Takes the user to the LogTicket form.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddTicket frmLogTicket = new frmAddTicket(admin);
            frmLogTicket.Show();
        }

        // Takes the user to the ViewTickets form.
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmViewTickets frmViewTickets = new frmViewTickets(admin);
            frmViewTickets.Show();
        }

        // Takes the user to the AssignTechnicians form.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddInstallation frmAssignTechnicians = new frmAddInstallation(admin, false, 0);
            frmAssignTechnicians.Show();
        }

        // Takes the user to the FinishInstallations form.
        private void btnFinishInstallation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewInstallations frmFinishInstallations = new frmViewInstallations(admin);
            frmFinishInstallations.Show();
        }

        // Answers the call.
        private void btnAnswerCall_Click(object sender, EventArgs e)
        {
            frmPhone frmPhone = new frmPhone(this.Top, this.Right, admin);
            frmPhone.StartPosition = FormStartPosition.Manual;
            frmPhone.Show();
        }

        // Loads the form.
        private void frmTechnicalSupport_Load(object sender, EventArgs e)
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
    }
}
