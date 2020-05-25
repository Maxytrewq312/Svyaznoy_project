using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Svyaznoy_project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            labelprivet.Text = "Здравствуй, " + FormAutorization.autom.login + "!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonSotr_Click(object sender, EventArgs e)
        {
            Form formSotr = new FormSotrudnik();
            formSotr.Show();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            Form formSell = new FormSell();
            formSell.Show();
        }

        private void buttonConsult_Click(object sender, EventArgs e)
        {
            Form formConsult = new FormConsult();
            formConsult.Show();
        }
    }
}
