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
    public partial class frmUpdateClient : Form
    {
        private bool helpMessageShow = true;
        private Administrator admin;

        public frmUpdateClient(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientManagement frmClientManagement = new frmClientManagement(admin);
            frmClientManagement.Show();
        }

        BindingSource bs = new BindingSource();
        private void frmUpdateClient_Load(object sender, EventArgs e)
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

            List<string> clientIDs = Client.GetClientIDs();
            bs.DataSource = clientIDs;
            cmbClient.DataSource = bs.DataSource;

            if (clientIDs.Count == 0)
            {
                btnUpdate.Enabled = false;
            }
        }

        private int addressID = 0;

        // Gets client details based on the client ID chosen from the combobox.
        private void cmbClient_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string clientID = cmbClient.SelectedValue.ToString();

            Client client = Client.GetClientFromDB(clientID);

            txtName.Text = client.Name;
            txtSurname.Text = client.Surname;
            dtpDob.Text = client.DateOfBirth.ToString();
            txtContract.Text = client.Contract;

            txtCity.Text = client.Address.City;
            txtStreet.Text = client.Address.Street;
            txtPostalCode.Text = client.Address.PostalCode;

            addressID = client.Address.AddressID;
        }

        // Updates the client with the new values.
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            bool canAdd = false;

            bool nameValid = false;
            bool surnameValid = false;
            bool cityValid = false;
            bool streetValid = false;
            bool postalCodeValid = false;

            string name = txtName.Text;
            string surname = txtSurname.Text;
            DateTime dateOfBirth = dtpDob.Value;
            string city = txtCity.Text;
            string street = txtStreet.Text;
            string postalCode = txtPostalCode.Text;

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
                if (MessageBox.Show("Are you sure you want to update this person?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    Client client = new Client(cmbClient.SelectedValue.ToString(), txtName.Text, txtSurname.Text, dtpDob.Value, new Address(addressID, txtCity.Text, txtStreet.Text, txtPostalCode.Text), txtContract.Text);
                    client.UpdateClient();

                    frmClientManagement frmClientManagement = new frmClientManagement(admin);
                    frmClientManagement.Show();
                    this.Hide();
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

        // Validates the name textbox.
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

        // Validates the surname textbox.
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

        // Validates the city textbox.
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

        // Validates the street textbox.
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

        // Validates the postalcode textbox.
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

        // Displays a tooltip to help the user when hovering over the label
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

        // Displays a tooltip to help the user when hovering over the label
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

        // Displays a tooltip to help the user when hovering over the label
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

        // Displays a tooltip to help the user when hovering over the label
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

        // Displays a tooltip to help the user when hovering over the label
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

        // Stops the user from changing the client's combobox value.
        private void cmbClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Stops the user from changing the datepicker component.
        private void dtpDob_KeyPress(object sender, KeyPressEventArgs e)
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
