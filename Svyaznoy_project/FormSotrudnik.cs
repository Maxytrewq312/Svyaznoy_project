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
    public partial class FormSotrudnik : Form
    {
        public FormSotrudnik()
        {
            InitializeComponent(); 
            ShowSotrMethod();
        }
        void ShowSotrMethod()
        {
            listViewSotr.Items.Clear();
            foreach (SotrudnikSet sotrs in Program.SpDb.SotrudnikSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    sotrs.Id.ToString(), sotrs.FirstName, sotrs.MiddleName,
                    sotrs.LastName, sotrs.Phone
                });
                item.Tag = sotrs;
                listViewSotr.Items.Add(item);
            }
            listViewSotr.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SotrudnikSet sotr = new SotrudnikSet();
            sotr.FirstName = textBoxFirstName.Text;
            sotr.MiddleName = textBoxMiddleName.Text;
            sotr.LastName = textBoxLastName.Text;
            sotr.Phone = textBoxPhone.Text;
            Program.SpDb.SotrudnikSet.Add(sotr);
            Program.SpDb.SaveChanges();
            ShowSotrMethod();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSotr.SelectedItems.Count == 1)
            {
                SotrudnikSet sotr = listViewSotr.SelectedItems[0].Tag as SotrudnikSet;
                sotr.FirstName = textBoxFirstName.Text;
                sotr.MiddleName = textBoxMiddleName.Text;
                sotr.LastName = textBoxLastName.Text;
                sotr.Phone = textBoxPhone.Text;
                Program.SpDb.SaveChanges();
                ShowSotrMethod();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSotr.SelectedItems.Count == 1)
                {
                    SotrudnikSet sotr = listViewSotr.SelectedItems[0].Tag as SotrudnikSet;
                    Program.SpDb.SotrudnikSet.Remove(sotr);
                    Program.SpDb.SaveChanges();
                    ShowSotrMethod();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Удаление записи невозможно", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewSotr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSotr.SelectedItems.Count == 1)
            {
                SotrudnikSet sotr = listViewSotr.SelectedItems[0].Tag as SotrudnikSet;
                textBoxFirstName.Text = sotr.FirstName;
                textBoxMiddleName.Text = sotr.MiddleName;
                textBoxLastName.Text = sotr.LastName;
                textBoxPhone.Text = sotr.Phone;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
            }
        }
    }
}
