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
    public partial class frmViewTickets : Form
    {
        private Administrator admin;

        public frmViewTickets(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        // Takes the user back to the TechnicalSupport form.
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
            frmTechnicalSupport.Show();
        }

        BindingSource bs = new BindingSource();

        // Loads the form.
        private void frmViewOpenTickets_Load(object sender, EventArgs e)
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

            cmbStatus.SelectedIndex = 0;

            dgvTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTickets.AutoResizeColumns();
        }

        // Assigns the selected technician.
        private void btnAssignTechnician_Click(object sender, EventArgs e)
        {
            int ticketID = int.Parse(dgvTickets.SelectedRows[0].Cells[0].Value.ToString());

            Ticket.CloseTicket(ticketID);

            this.Hide();
            frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
            frmTechnicalSupport.Show();
        }

        // Removes the ticket from the database.
        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            int ticketID = int.Parse(dgvTickets.SelectedRows[0].Cells[0].Value.ToString());

            Ticket.CancelTicket(ticketID);
        }

        // Changes the dgv according to the status.
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDgv();
        }

        // Changes the dgv and disables the status combobox.
        private void chkOpen_CheckedChanged(object sender, EventArgs e)
        {
            ChangeDgv();

            if (chkOpen.Checked)
            {
                cmbStatus.Enabled = true;
            }
            else if (!chkOpen.Checked)
            {
                cmbStatus.Enabled = false;
            }
        }


        private void btnCancelTicket_Click_1(object sender, EventArgs e)
        {
            int ticketID = int.Parse(dgvTickets.SelectedRows[0].Cells[0].Value.ToString());

            Ticket.CancelTicket(ticketID);

            this.Hide();
            frmTechnicalSupport frmTechnicalSupport = new frmTechnicalSupport(admin);
            frmTechnicalSupport.Show();
        }

        // Stops the user from changing the status combobox values.
        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Changes the dgv.
        private void ChangeDgv()
        {
            dgvTickets.DataSource = null;

            List<Ticket> tickets = new List<Ticket>();

            bool assigned = false;
            bool open = false;

            if ((cmbStatus.SelectedIndex == 0) && (chkOpen.Checked))
            {
                assigned = true;
                open = true;
                btnCloseTicket.Enabled = true;
                btnCancelTicket.Enabled = true;
            }
            else if ((cmbStatus.SelectedIndex == 0) && (!chkOpen.Checked))
            {
                assigned = true;
                open = false;
                btnCloseTicket.Enabled = false;
                btnCancelTicket.Enabled = false;
            }
            else if ((cmbStatus.SelectedIndex == 1) && (chkOpen.Checked))
            {
                assigned = false;
                open = true;
                btnCloseTicket.Enabled = false;
                btnCancelTicket.Enabled = true;
            }

            tickets = Ticket.GetTickets(assigned, open);

            if (tickets.Count != 0)
            {
                bs.DataSource = tickets;

                dgvTickets.DataSource = bs.DataSource;

                dgvTickets.Columns[0].DataPropertyName = "TicketID";
                dgvTickets.Columns[0].HeaderText = "Ticket Number";
                dgvTickets.Columns[1].DataPropertyName = "ClientID";
                dgvTickets.Columns[1].HeaderText = "Client Number";
                dgvTickets.Columns[2].DataPropertyName = "FaultDescription";
                dgvTickets.Columns[2].HeaderText = "Fault Description";
                dgvTickets.Columns[2].Width = 200;
                dgvTickets.Columns[3].DataPropertyName = "TicketOpenDate";
                dgvTickets.Columns[3].HeaderText = "Ticket Open Date";
                dgvTickets.Columns[4].HeaderText = "Open?";
                dgvTickets.Columns[4].DataPropertyName = "Open";
                dgvTickets.Columns[5].Visible = false;
            }
        }
    }
}
