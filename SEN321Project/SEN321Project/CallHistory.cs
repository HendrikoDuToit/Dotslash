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
    public partial class frmCallHistory : Form
    {
        private Administrator admin;
        public frmCallHistory(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        BindingSource bs = new BindingSource();

        private void frmCallHistory_Load(object sender, EventArgs e)
        {
            dgvCallHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCallHistory.AutoResizeColumns();

            bs.DataSource = PhoneCall.GetCalls();

            dgvCallHistory.DataSource = bs.DataSource;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu(admin);
            frmMainMenu.Show();
        }
    }
}
