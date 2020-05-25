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
    public partial class FormConsult : Form
    {
        public FormConsult()
        {
            InitializeComponent();
            comboBoxTypeOfCons.SelectedIndex = 0;
            ShowClientsMethod();
            ShowSotrudniksMethod();
            ShowConsultSet();
        }
        void ShowConsultSet()
        {
            listViewMobileCons.Items.Clear();
            listViewAcsessCons.Items.Clear();
            listViewOperCons.Items.Clear();
            foreach(ConsultSet cons in Program.SpDb.ConsultSet)
            {
                if(cons.TypeConsult == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        cons.IdClient.ToString(),
                        cons.ClientSet.MiddleName + " ",
                        cons.IdSotrudnik.ToString(),
                        cons.SotrudnikSet.MiddleName + " ",
                        cons.MobileConsult.ToString()
                    });
                    item.Tag = cons;
                    listViewMobileCons.Items.Add(item);
                }
                if (cons.TypeConsult == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        cons.IdClient.ToString(),
                        cons.ClientSet.MiddleName + " ",
                        cons.IdSotrudnik.ToString(),
                        cons.SotrudnikSet.MiddleName + " ",
                        cons.AcsessConsult.ToString()
                    });
                    item.Tag = cons;
                    listViewAcsessCons.Items.Add(item);
                }
                if (cons.TypeConsult == 2)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        cons.IdClient.ToString(),
                        cons.ClientSet.MiddleName + " ",
                        cons.IdSotrudnik.ToString(),
                        cons.SotrudnikSet.MiddleName + " ",
                        cons.OperConsult.ToString()
                    });
                    item.Tag = cons;
                    listViewOperCons.Items.Add(item);
                }
            }
            listViewMobileCons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewAcsessCons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewOperCons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewOperCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOperCons.SelectedItems.Count == 1)
            {
                ConsultSet cons = listViewOperCons.SelectedItems[0].Tag as ConsultSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(cons.IdClient.ToString());
                comboBoxSotr.SelectedIndex = comboBoxClient.FindString(cons.IdSotrudnik.ToString());
                textBoxPredOper.Text = cons.OperConsult.ToString();
            }
            else
            {
                comboBoxSotr.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxPredOper.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeOfCons.SelectedIndex == 0)
            {
                if (listViewMobileCons.SelectedItems.Count == 1)
                {
                    ConsultSet cons = listViewMobileCons.SelectedItems[0].Tag as ConsultSet;
                    cons.IdSotrudnik = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                    cons.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    cons.MobileConsult = Convert.ToString(textBoxPredMobile.Text);
                    Program.SpDb.SaveChanges();
                    ShowConsultSet();
                }
            }
            if (comboBoxTypeOfCons.SelectedIndex == 1)
            {
                if (listViewAcsessCons.SelectedItems.Count == 1)
                {
                    ConsultSet cons = listViewAcsessCons.SelectedItems[0].Tag as ConsultSet;
                    cons.IdSotrudnik = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                    cons.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    cons.AcsessConsult = Convert.ToString(textBoxPredAcsess.Text);
                    Program.SpDb.SaveChanges();
                    ShowConsultSet();
                }
            }
            else 
            {
                if (listViewOperCons.SelectedItems.Count == 1)
                {
                    ConsultSet cons = listViewOperCons.SelectedItems[0].Tag as ConsultSet;
                    cons.IdSotrudnik = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                    cons.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    cons.OperConsult = Convert.ToString(textBoxPredOper.Text);
                    Program.SpDb.SaveChanges();
                    ShowConsultSet();
                }
            }
        }
        void ShowClientsMethod()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientSet client in Program.SpDb.ClientSet)
            {
                string[] item = { client.Id.ToString() + ".", client.MiddleName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSotrudniksMethod()
        {
            comboBoxSotr.Items.Clear();
            foreach (SotrudnikSet sotr in Program.SpDb.SotrudnikSet)
            {
                string[] item = { sotr.Id.ToString() + ".", sotr.MiddleName };
                comboBoxSotr.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && comboBoxSotr.SelectedItem != null)
            {
                ConsultSet cons = new ConsultSet();
                cons.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                cons.IdSotrudnik = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                if (comboBoxTypeOfCons.SelectedIndex == 0)
                {
                    cons.TypeConsult = 0;
                    cons.MobileConsult = Convert.ToString(textBoxPredMobile.Text);
                }
                else if (comboBoxTypeOfCons.SelectedIndex == 1)
                {
                    cons.TypeConsult = 1;
                    cons.AcsessConsult = Convert.ToString(textBoxPredAcsess.Text);
                }
                else
                {
                    cons.TypeConsult = 2;
                    cons.OperConsult = Convert.ToString(textBoxPredOper);
                }
                Program.SpDb.ConsultSet.Add(cons);
                Program.SpDb.SaveChanges();
                ShowConsultSet();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypeOfCons.SelectedIndex == 0)
                {
                    if (listViewMobileCons.SelectedItems.Count == 1)
                    {
                        ConsultSet cons = listViewMobileCons.SelectedItems[0].Tag as ConsultSet;
                        Program.SpDb.ConsultSet.Remove(cons);
                        Program.SpDb.SaveChanges();
                        ShowConsultSet();
                    }
                    comboBoxSotr.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxPredMobile.Text = "";
                }
                else if (comboBoxTypeOfCons.SelectedIndex == 1)
                {
                    if (listViewAcsessCons.SelectedItems.Count == 1)
                    {
                        ConsultSet cons = listViewAcsessCons.SelectedItems[0].Tag as ConsultSet;
                        Program.SpDb.ConsultSet.Remove(cons);
                        Program.SpDb.SaveChanges();
                        ShowConsultSet();
                    }
                    comboBoxSotr.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxPredAcsess.Text = "";
                }
                else
                {
                    if (listViewOperCons.SelectedItems.Count == 1)
                    {
                        ConsultSet cons = listViewOperCons.SelectedItems[0].Tag as ConsultSet;
                        Program.SpDb.ConsultSet.Remove(cons);
                        Program.SpDb.SaveChanges();
                        ShowConsultSet();
                    }
                    comboBoxSotr.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxPredOper.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewMobileCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMobileCons.SelectedItems.Count == 1)
            {
                ConsultSet cons = listViewMobileCons.SelectedItems[0].Tag as ConsultSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(cons.IdClient.ToString());
                comboBoxSotr.SelectedIndex = comboBoxClient.FindString(cons.IdSotrudnik.ToString());
                textBoxPredMobile.Text = cons.MobileConsult.ToString();
            }
            else
            {
                comboBoxSotr.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxPredMobile.Text = "";
            }
        }

        private void listViewAcsessCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAcsessCons.SelectedItems.Count == 1)
            {
                ConsultSet cons = listViewAcsessCons.SelectedItems[0].Tag as ConsultSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(cons.IdClient.ToString());
                comboBoxSotr.SelectedIndex = comboBoxClient.FindString(cons.IdSotrudnik.ToString());
                textBoxPredAcsess.Text = cons.AcsessConsult.ToString();
            }
            else
            {
                comboBoxSotr.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxPredAcsess.Text = "";
            }
        }

        private void comboBoxTypeOfCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeOfCons.SelectedIndex == 0)
            {
                listViewMobileCons.Visible = true;
                labelPredMobile.Visible = true;
                textBoxPredMobile.Visible = true;

                listViewAcsessCons.Visible = false;
                listViewOperCons.Visible = false;
                labelPredAcsess.Visible = false;
                textBoxPredAcsess.Visible = false;
                labelPredOper.Visible = false;
                textBoxPredOper.Visible = false;

                comboBoxClient.Text = null;
                comboBoxSotr.Text = null;
                textBoxPredMobile.Text = "";
            }
            else if (comboBoxTypeOfCons.SelectedIndex == 1)
            {
                listViewAcsessCons.Visible = true;
                labelPredAcsess.Visible = true;
                textBoxPredAcsess.Visible = true;

                listViewMobileCons.Visible = false;
                listViewOperCons.Visible = false;
                labelPredMobile.Visible = false;
                textBoxPredMobile.Visible = false;
                labelPredOper.Visible = false;
                textBoxPredOper.Visible = false;

                comboBoxClient.Text = null;
                comboBoxSotr.Text = null;
                textBoxPredAcsess.Text = "";
            }
            else if (comboBoxTypeOfCons.SelectedIndex == 2)
            {
                listViewOperCons.Visible = true;
                labelPredOper.Visible = true;
                textBoxPredOper.Visible = true;

                listViewAcsessCons.Visible = false;
                listViewMobileCons.Visible = false;
                labelPredAcsess.Visible = false;
                textBoxPredAcsess.Visible = false;
                labelPredMobile.Visible = false;
                textBoxPredMobile.Visible = false;

                comboBoxClient.Text = null;
                comboBoxSotr.Text = null;
                textBoxPredOper.Text = "";
            }
        }
    }
}
