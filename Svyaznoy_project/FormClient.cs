using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Svyaznoy_project
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClientMethod();
        }
        void ShowClientMethod()
        {
            listViewClient.Items.Clear();
            foreach (ClientSet clients in Program.SpDb.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clients.Id.ToString(), clients.FirstName, clients.MiddleName,
                    clients.LastName, clients.Phone, clients.Address
                });
                item.Tag = clients;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientSet client = new ClientSet();
            client.FirstName = textBoxFirstName.Text;
            client.MiddleName = textBoxMiddleName.Text;
            client.LastName = textBoxLastName.Text;
            client.Phone = textBoxPhone.Text;
            client.Address = textBoxAddress.Text;
            Program.SpDb.ClientSet.Add(client);
            Program.SpDb.SaveChanges();
            ShowClientMethod();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet client = listViewClient.SelectedItems[0].Tag as ClientSet;
                client.FirstName = textBoxFirstName.Text;
                client.MiddleName = textBoxMiddleName.Text;
                client.LastName = textBoxLastName.Text;
                client.Phone = textBoxPhone.Text;
                client.Address = textBoxAddress.Text;
                Program.SpDb.SaveChanges();
                ShowClientMethod();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    ClientSet client = listViewClient.SelectedItems[0].Tag as ClientSet;
                    Program.SpDb.ClientSet.Remove(client);
                    Program.SpDb.SaveChanges();
                    ShowClientMethod();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxAddress.Text = "";
            }
            catch
            {
                MessageBox.Show("Удаление записи невозможно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet client = listViewClient.SelectedItems[0].Tag as ClientSet;
                textBoxFirstName.Text = client.FirstName;
                textBoxMiddleName.Text = client.MiddleName;
                textBoxLastName.Text = client.LastName;
                textBoxPhone.Text = client.Phone;
                textBoxAddress.Text = client.Address;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxAddress.Text = "";
            }
        }
    }
}
