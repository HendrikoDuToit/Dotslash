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
    public partial class frmPhone : Form
    {
        private int top;
        private int left;

        private Administrator admin;
        public frmPhone(int top, int left, Administrator admin)
        {
            InitializeComponent();
            this.top = top;
            this.left = left;
            this.admin = admin;
            this.ControlBox = false;
        }

        Timer timer = new Timer();

        // Loads the form, sets the position and starts the timer for the call.
        private void frmPhone_Load(object sender, EventArgs e)
        {
            cmbReason.SelectedIndex = 0;

            this.Top = this.top;
            this.Left = this.left;

            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        // Event for the timer ticking.
        private void timer_Tick(object sender, EventArgs e)
        {
            int hours = int.Parse(lblHours.Text);
            int minutes = int.Parse(lblMinutes.Text);
            int seconds = int.Parse(lblSeconds.Text);

            seconds++;

            if (seconds == 60)
            {
                seconds = 0;

                minutes++;

                if (minutes == 60)
                {
                    minutes = 0;

                    hours++;
                }
            }

            string strHours = hours.ToString();
            string strMinutes = minutes.ToString();
            string strSeconds = seconds.ToString();

            if (hours < 10)
            {
                strHours = "0" + strHours;
            }

            if (minutes < 10)
            {
                strMinutes = "0" + strMinutes;
            }

            if (seconds < 10)
            {
                strSeconds = "0" + strSeconds;
            }

            lblHours.Text = strHours;
            lblMinutes.Text = strMinutes;
            lblSeconds.Text = strSeconds;
        }

        // Ends the call and saves the information to the database.
        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            string duration = lblHours.Text + ":" + lblMinutes.Text + ":" + lblSeconds.Text;

            string[] arrayNotes = rtxNotes.Text.Split('\n');

            string notes = "";

            for (int i = 0; i < arrayNotes.Length; i++)
            {
                notes = notes + " " + arrayNotes[i];
            }

            string reason = cmbReason.Items[cmbReason.SelectedIndex].ToString();

            PhoneCall call = new PhoneCall();

            if (cmbReason.SelectedIndex != 0)
            {
                timer.Stop();

                call = new PhoneCall(0, duration, DateTime.Now, reason, notes, int.Parse(admin.AdministratorID.ToString()));

                call.AddCall();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please choose a reason for the call!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Stops the timer when the form is closed.
        private void frmPhone_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        // When clicking on the richtext the text disappears.
        private void rtxNotes_Enter(object sender, EventArgs e)
        {
            rtxNotes.Clear();
        }

        // Stops the user from changing the value within the reason combobox.
        private void cmbReason_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
