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
    public partial class frmAddClient : Form
    {
        bool helpMessageShow = true;
        private Administrator admin;

        public frmAddClient(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void frmAddClient_Load(object sender, EventArgs e)
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

            cmbContract.SelectedIndex = 0;
        }

        // This button calls the datahandler class's addclient method through the Client class, and adds a new client to the database
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            bool canAdd = false;

            bool nameValid = false;
            bool surnameValid = false;
            bool cityValid = false;
            bool streetValid = false;
            bool postalCodeValid = false;

            string name = txtName.Text;
            string surname = txtSurname.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string city = txtCity.Text;
            string street = txtStreet.Text;
            string postalCode = txtPostalCode.Text;
            string contractType = cmbContract.SelectedItem.ToString();

            if (name == string.Empty)
            {
                nameValid = false;
            }
            else
            {
                nameValid = true;
            }

            if (surname == string.Empty)
            {
                surnameValid = false;
            }
            else
            {
                surnameValid = true;
            }

            if (city == string.Empty)
            {
                cityValid = false;
            }
            else
            {
                cityValid = true;
            }

            if (street == string.Empty)
            {
                streetValid = false;
            }
            else
            {
                streetValid = true;
            }

            if ((postalCode == string.Empty) || (postalCode.Length < 4))
            {
                postalCodeValid = false;
            }
            else
            {
                postalCodeValid = true;
            }

            if (nameValid && surnameValid && cityValid && streetValid && postalCodeValid)
            {
                canAdd = true;
            }
            else
            {
                canAdd = false;
            }

            if (canAdd)
            {
                if (MessageBox.Show("Are you sure you want to add this person?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    Client client = new Client(Client.GenerateClientID(), name, surname, dateOfBirth, new Address(0, city, street, postalCode), Contract.GenerateContractID(contractType));
                    Client.AddClient(client);

                    frmClientManagement frmClientManagement = new frmClientManagement(admin);
                    frmClientManagement.Show();
                    this.Close();
                }
            }
            else
            {
                if (helpMessageShow)
                {
                    MessageBox.Show("Indicated fields are not correct!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    helpMessageShow = false;
                }
            }
        }

        // This button takes you back to the client management menu.
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientManagement frmClientManagement = new frmClientManagement(admin);
            frmClientManagement.Show();
        }
        
        // Hover effect for name tooltip
        private void lblNameHelp_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.IsBalloon = true;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(lblNameHelp, @"Names:
1. Cannot contain numbers.
2. Cannot be empty.
3. Cannot contain any non text characters ( e.g. !?.,;[]{} etc.).");
        }

        // Hover effect for surname tooltip
        private void lblSurnameHelp_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.IsBalloon = true;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(lblSurnameHelp, @"Surnames:
1. Cannot contain numbers.
2. Cannot be empty.
3. Cannot contain any non text characters ( e.g. !?.,;[]{} etc.).");
        }

        // Hover effect for city tooltip
        private void lblCityHelp_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.IsBalloon = true;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(lblCityHelp, @"Cities:
1. Cannot contain numbers.
2. Cannot be empty.
3. Cannot contain any non text characters ( e.g. !?.,;[]{} etc.).");
        }

        // Hover effect for street tooltip
        private void lblStreetHelp_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.IsBalloon = true;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(lblStreetHelp, @"Streets:
1. Cannot be empty.
2. Cannot contain any non text characters ( e.g. !?.,;[]{} etc.).");
        }

        // Hover effect for postalcode tooltip
        private void lblPostalCodeHelp_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.IsBalloon = true;

            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(lblPostalCodeHelp, @"Postal Codes:
1. Cannot be empty.
2. Maximum length must be 4.
3. Cannot contain any non text characters ( e.g. !?.,;[]{} etc.).");
        }

        // Validation of name text field
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.ToString()).Any(char.IsDigit) || !(e.KeyChar.ToString().All(char.IsLetterOrDigit)))
            {
                e.Handled = true;
                if (e.KeyChar.ToString().All(char.IsControl))
                {
                    e.Handled = false;
                }
            }
        }

        // Validation of surname text field
        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.ToString()).Any(char.IsDigit) || !(e.KeyChar.ToString().All(char.IsLetterOrDigit)))
            {
                e.Handled = true;
                if (e.KeyChar.ToString().All(char.IsControl))
                {
                    e.Handled = false;
                }
            }
        }

        // Validation of city text field
        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.ToString()).Any(char.IsDigit) || !(e.KeyChar.ToString().All(char.IsLetterOrDigit)))
            {
                e.Handled = true;
                if (e.KeyChar.ToString().All(char.IsControl))
                {
                    e.Handled = false;
                }
            }
        }

        // Validation of street text field
        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.ToString().All(char.IsLetterOrDigit)))
            {
                e.Handled = true;
                if (e.KeyChar.ToString().All(char.IsControl))
                {
                    e.Handled = false;
                }
            }
        }

        // Validation of postal text field
        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
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

        // Stops the user from editing the combobox
        private void cmbContract_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Stops the user from editing the datepicker
        private void dtpDateOfBirth_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        ErrorProvider errorProvider = new ErrorProvider();

        // Provides errors for invalid information.
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider.SetError(txtName, "Refer to the ?");
                lblNameHelp.Visible = true;
            }
            else
            {
                lblNameHelp.Visible = false;
                errorProvider.Clear();
            }
        }

        // Provides errors for invalid information.
        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                e.Cancel = true;
                txtSurname.Focus();
                errorProvider.SetError(txtSurname, "Refer to the ?");
                lblSurnameHelp.Visible = true;
            }
            else
            {
                lblSurnameHelp.Visible = false;
                errorProvider.Clear();
            }
        }

        // Provides errors for invalid information.
        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                e.Cancel = true;
                txtCity.Focus();
                errorProvider.SetError(txtCity, "Refer to the ?");
                lblCityHelp.Visible = true;
            }
            else
            {
                lblCityHelp.Visible = false;
                errorProvider.Clear();
            }
        }

        // Provides errors for invalid information.
        private void txtStreet_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStreet.Text))
            {
                e.Cancel = true;
                txtStreet.Focus();
                errorProvider.SetError(txtStreet, "Refer to the ?");
                lblStreetHelp.Visible = true;
            }
            else
            {
                lblStreetHelp.Visible = false;
                errorProvider.Clear();
            }
        }

        // Provides errors for invalid information.
        private void txtPostalCode_Validating(object sender, CancelEventArgs e)
        {
            if ((string.IsNullOrEmpty(txtPostalCode.Text)) || (txtPostalCode.Text.Length < 4))
            {
                e.Cancel = true;
                txtPostalCode.Focus();
                errorProvider.SetError(txtPostalCode, "Refer to the ?");
                lblPostalCodeHelp.Visible = true;
            }
            else
            {
                lblPostalCodeHelp.Visible = false;
                errorProvider.Clear();
            }
        }
    }
}
