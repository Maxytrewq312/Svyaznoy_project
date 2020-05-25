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
    public partial class FormSell : Form
    {
        public FormSell()
        {
            InitializeComponent();
            comboBoxVidTovar.SelectedIndex = 0;
            ShowClientsMethod();
            ShowSotrudniksMethod();
            ShowSellsSet();
        }

        private void FormSell_Load(object sender, EventArgs e)
        {

        }
        void ShowClientsMethod()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientSet client in Program.SpDb.ClientSet)
            {
                string[] item = {client.Id.ToString() + ".", client.MiddleName};
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSotrudniksMethod()
        {
            comboBoxSotr.Items.Clear();
            foreach (SotrudnikSet sotr in Program.SpDb.SotrudnikSet)
            {
                string[] item = {sotr.Id.ToString() + ".", sotr.MiddleName};
                comboBoxSotr.Items.Add(string.Join(" ", item));
            }
        }

        private void comboBoxVidTovar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVidTovar.SelectedIndex == 0)
            {
                listViewMobile.Visible = true;
                labelModelMobile.Visible = true;
                textBoxModelMobile.Visible = true;

                listViewAcsess.Visible = false;
                listViewOper.Visible = false;
                labelNameAcsess.Visible = false;
                textBoxNameAcsess.Visible = false;
                labelNameOper.Visible = false;
                textBoxNameOper.Visible = false;

                comboBoxClient.Text = null;
                comboBoxSotr.Text = null;
                textBoxPrice.Text = "";
                textBoxGarant.Text = "";
                textBoxModelMobile.Text = "";
            }
            else if (comboBoxVidTovar.SelectedIndex == 1)
            {
                listViewAcsess.Visible = true;
                labelNameAcsess.Visible = true;
                textBoxNameAcsess.Visible = true;

                listViewMobile.Visible = false;
                listViewOper.Visible = false;
                labelModelMobile.Visible = false;
                textBoxModelMobile.Visible = false;
                labelNameOper.Visible = false;
                textBoxNameOper.Visible = false;

                comboBoxClient.Text = null;
                comboBoxSotr.Text = null;
                textBoxPrice.Text = "";
                textBoxGarant.Text = "";
                textBoxNameAcsess.Text = "";
            }
            else if (comboBoxVidTovar.SelectedIndex == 2)
            {
                listViewOper.Visible = true;
                labelNameOper.Visible = true;
                textBoxNameOper.Visible = true;

                listViewAcsess.Visible = false;
                listViewMobile.Visible = false;
                labelNameAcsess.Visible = false;
                textBoxNameAcsess.Visible = false;
                labelModelMobile.Visible = false;
                textBoxModelMobile.Visible = false;

                comboBoxClient.Text = null;
                comboBoxSotr.Text = null;
                textBoxPrice.Text = "";
                textBoxNameOper.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (comboBoxClient.SelectedItem != null && comboBoxSotr.SelectedItem != null && textBoxPrice.Text != "")
            {
                SellsSet sell = new SellsSet();
                sell.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                sell.IdSotrudnik = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                sell.Price = Convert.ToInt32(textBoxPrice.Text);
                if (comboBoxVidTovar.SelectedIndex == 0)
                {
                    sell.TypeTovar = 0;
                    sell.Garant = Convert.ToInt32(textBoxGarant.Text);
                    sell.ModelMobile = Convert.ToString(textBoxModelMobile.Text);
                }
                else if (comboBoxVidTovar.SelectedIndex == 1)
                {
                    sell.TypeTovar = 1;
                    sell.Garant = Convert.ToInt32(textBoxGarant.Text);
                    sell.NameAcsess = Convert.ToString(textBoxNameAcsess.Text);
                }
                else
                {
                    sell.TypeTovar = 2;
                    sell.NameOper = Convert.ToString(textBoxNameOper);
                }
                Program.SpDb.SellsSet.Add(sell);
                Program.SpDb.SaveChanges();
                ShowSellsSet();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxVidTovar.SelectedIndex == 0)
            {
                if (listViewMobile.SelectedItems.Count == 1)
                {
                    SellsSet sell = listViewMobile.SelectedItems[0].Tag as SellsSet;
                    sell.IdSotrudnik = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                    sell.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    sell.Price = Convert.ToInt32(textBoxPrice.Text);
                    sell.Garant = Convert.ToInt32(textBoxGarant.Text);
                    sell.ModelMobile = Convert.ToString(textBoxModelMobile.Text);
                    Program.SpDb.SaveChanges();
                    ShowSellsSet();
                }
            }
            if (comboBoxVidTovar.SelectedIndex == 1)
            {
                if (listViewMobile.SelectedItems.Count == 1)
                {
                    SellsSet sell = listViewMobile.SelectedItems[0].Tag as SellsSet;
                    sell.IdSotrudnik = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                    sell.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    sell.Price = Convert.ToInt32(textBoxPrice.Text);
                    sell.Garant = Convert.ToInt32(textBoxGarant.Text);
                    sell.NameAcsess = Convert.ToString(textBoxNameAcsess.Text);
                    Program.SpDb.SaveChanges();
                    ShowSellsSet();
                }
            }
            else 
            {
                if (listViewMobile.SelectedItems.Count == 1)
                {
                    SellsSet sell = listViewMobile.SelectedItems[0].Tag as SellsSet;
                    sell.IdSotrudnik = Convert.ToInt32(comboBoxSotr.SelectedItem.ToString().Split('.')[0]);
                    sell.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    sell.Price = Convert.ToInt32(textBoxPrice.Text);
                    sell.NameOper = Convert.ToString(textBoxNameOper.Text);
                    Program.SpDb.SaveChanges();
                    ShowSellsSet();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxVidTovar.SelectedIndex == 0)
                {
                    if (listViewMobile.SelectedItems.Count == 1)
                    {
                        SellsSet sell = listViewMobile.SelectedItems[0].Tag as SellsSet;
                        Program.SpDb.SellsSet.Remove(sell);
                        Program.SpDb.SaveChanges();
                        ShowSellsSet();
                    }
                    comboBoxSotr.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxPrice.Text = "";
                    textBoxGarant.Text = "";
                    textBoxModelMobile.Text = "";
                }
                else if (comboBoxVidTovar.SelectedIndex == 1)
                {
                    if (listViewAcsess.SelectedItems.Count == 1)
                    {
                        SellsSet sell = listViewAcsess.SelectedItems[0].Tag as SellsSet;
                        Program.SpDb.SellsSet.Remove(sell);
                        Program.SpDb.SaveChanges();
                        ShowSellsSet();
                    }
                    comboBoxSotr.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxPrice.Text = "";
                    textBoxGarant.Text = "";
                    textBoxNameAcsess.Text = "";
                }
                else
                {
                    if (listViewOper.SelectedItems.Count == 1)
                    {
                        SellsSet sell = listViewOper.SelectedItems[0].Tag as SellsSet;
                        Program.SpDb.SellsSet.Remove(sell);
                        Program.SpDb.SaveChanges();
                        ShowSellsSet();
                    }
                    comboBoxSotr.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                    textBoxPrice.Text = "";
                    textBoxNameOper.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewMobile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMobile.SelectedItems.Count == 1)
            {
                SellsSet sell = listViewMobile.SelectedItems[0].Tag as SellsSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(sell.IdClient.ToString());
                comboBoxSotr.SelectedIndex = comboBoxClient.FindString(sell.IdSotrudnik.ToString());
                textBoxPrice.Text = sell.Price.ToString();
                textBoxGarant.Text = sell.Garant.ToString();
                textBoxModelMobile.Text = sell.ModelMobile.ToString();
            }
            else
            {
                comboBoxSotr.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxPrice.Text = "";
                textBoxGarant.Text = "";
                textBoxModelMobile.Text = "";
            }
        }

        private void listViewAcsess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAcsess.SelectedItems.Count == 1)
            {
                SellsSet sell = listViewAcsess.SelectedItems[0].Tag as SellsSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(sell.IdClient.ToString());
                comboBoxSotr.SelectedIndex = comboBoxClient.FindString(sell.IdSotrudnik.ToString());
                textBoxPrice.Text = sell.Price.ToString();
                textBoxGarant.Text = sell.Garant.ToString();
                textBoxNameAcsess.Text = sell.NameAcsess.ToString();
            }
            else
            {
                comboBoxSotr.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxPrice.Text = "";
                textBoxGarant.Text = "";
                textBoxNameAcsess.Text = "";
            }
        }

        private void listViewOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOper.SelectedItems.Count == 1)
            {
                SellsSet sell = listViewOper.SelectedItems[0].Tag as SellsSet;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(sell.IdClient.ToString());
                comboBoxSotr.SelectedIndex = comboBoxClient.FindString(sell.IdSotrudnik.ToString());
                textBoxPrice.Text = sell.Price.ToString();
                textBoxGarant.Text = sell.Garant.ToString();
                textBoxNameOper.Text = sell.NameOper.ToString();
            }
            else
            {
                comboBoxSotr.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                textBoxPrice.Text = "";
                textBoxGarant.Text = "";
                textBoxNameOper.Text = "";
            }
        }
        void ShowSellsSet()
        {
            listViewMobile.Items.Clear();
            listViewAcsess.Items.Clear();
            listViewOper.Items.Clear();
            foreach (SellsSet sell in Program.SpDb.SellsSet)
            {
                if (sell.TypeTovar == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    sell.IdClient.ToString(),
                    sell.ClientSet.MiddleName + " ",
                    sell.IdSotrudnik.ToString(),
                    sell.SotrudnikSet.MiddleName + " ",
                    sell.Price.ToString(),
                    sell.Garant.ToString(),
                    sell.ModelMobile.ToString()
                    });
                    item.Tag = sell;
                    listViewMobile.Items.Add(item);
                }
                else if (sell.TypeTovar == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    sell.IdClient.ToString(),
                    sell.ClientSet.MiddleName + " ",
                    sell.IdSotrudnik.ToString(),
                    sell.SotrudnikSet.MiddleName + " ",
                    sell.Price.ToString(),
                    sell.Garant.ToString(),
                    sell.NameAcsess.ToString()
                    });
                    item.Tag = sell;
                    listViewAcsess.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    sell.IdClient.ToString(),
                    sell.ClientSet.MiddleName + " ",
                    sell.IdSotrudnik.ToString(),
                    sell.SotrudnikSet.MiddleName + " ",
                    sell.Price.ToString(),
                    sell.NameOper.ToString()
                    });
                    item.Tag = sell;
                    listViewOper.Items.Add(item);
                }
            }
            listViewMobile.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewAcsess.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewOper.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
