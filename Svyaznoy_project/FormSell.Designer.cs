namespace Svyaznoy_project
{
    partial class FormSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxSotr = new System.Windows.Forms.ComboBox();
            this.comboBoxVidTovar = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelSotr = new System.Windows.Forms.Label();
            this.label3VidTovar = new System.Windows.Forms.Label();
            this.listViewMobile = new System.Windows.Forms.ListView();
            this.listViewAcsess = new System.Windows.Forms.ListView();
            this.listViewOper = new System.Windows.Forms.ListView();
            this.Idc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdSotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Тип = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Стоимость = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Гарантия = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Idcl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Наименование = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Стоимость1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Гарант = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdSotrud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Опер = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Стоимость2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxGarant = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelGarant = new System.Windows.Forms.Label();
            this.textBoxModelMobile = new System.Windows.Forms.TextBox();
            this.textBoxNameAcsess = new System.Windows.Forms.TextBox();
            this.textBoxNameOper = new System.Windows.Forms.TextBox();
            this.labelModelMobile = new System.Windows.Forms.Label();
            this.labelNameAcsess = new System.Windows.Forms.Label();
            this.labelNameOper = new System.Windows.Forms.Label();
            this.фамкл = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамсотр = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамклиент = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамс = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамк = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамсотруд = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(765, 390);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 48);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(891, 390);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 48);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(1017, 390);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(120, 48);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(12, 44);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(200, 21);
            this.comboBoxClient.TabIndex = 3;
            // 
            // comboBoxSotr
            // 
            this.comboBoxSotr.FormattingEnabled = true;
            this.comboBoxSotr.Location = new System.Drawing.Point(218, 44);
            this.comboBoxSotr.Name = "comboBoxSotr";
            this.comboBoxSotr.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSotr.TabIndex = 4;
            // 
            // comboBoxVidTovar
            // 
            this.comboBoxVidTovar.FormattingEnabled = true;
            this.comboBoxVidTovar.Items.AddRange(new object[] {
            "Мобильный телефон",
            "Аксессуар",
            "Оператор"});
            this.comboBoxVidTovar.Location = new System.Drawing.Point(114, 122);
            this.comboBoxVidTovar.Name = "comboBoxVidTovar";
            this.comboBoxVidTovar.Size = new System.Drawing.Size(200, 21);
            this.comboBoxVidTovar.TabIndex = 5;
            this.comboBoxVidTovar.SelectedIndexChanged += new System.EventHandler(this.comboBoxVidTovar_SelectedIndexChanged);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 28);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "Клиент";
            // 
            // labelSotr
            // 
            this.labelSotr.AutoSize = true;
            this.labelSotr.Location = new System.Drawing.Point(215, 28);
            this.labelSotr.Name = "labelSotr";
            this.labelSotr.Size = new System.Drawing.Size(60, 13);
            this.labelSotr.TabIndex = 7;
            this.labelSotr.Text = "Сотрудник";
            // 
            // label3VidTovar
            // 
            this.label3VidTovar.AutoSize = true;
            this.label3VidTovar.Location = new System.Drawing.Point(182, 106);
            this.label3VidTovar.Name = "label3VidTovar";
            this.label3VidTovar.Size = new System.Drawing.Size(64, 13);
            this.label3VidTovar.TabIndex = 8;
            this.label3VidTovar.Text = "Вид товара";
            // 
            // listViewMobile
            // 
            this.listViewMobile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Idc,
            this.фамкл,
            this.IdSotr,
            this.фамсотр,
            this.Тип,
            this.Стоимость,
            this.Гарантия});
            this.listViewMobile.FullRowSelect = true;
            this.listViewMobile.GridLines = true;
            this.listViewMobile.HideSelection = false;
            this.listViewMobile.Location = new System.Drawing.Point(440, 12);
            this.listViewMobile.MultiSelect = false;
            this.listViewMobile.Name = "listViewMobile";
            this.listViewMobile.Size = new System.Drawing.Size(697, 331);
            this.listViewMobile.TabIndex = 9;
            this.listViewMobile.UseCompatibleStateImageBehavior = false;
            this.listViewMobile.View = System.Windows.Forms.View.Details;
            this.listViewMobile.SelectedIndexChanged += new System.EventHandler(this.listViewMobile_SelectedIndexChanged);
            // 
            // listViewAcsess
            // 
            this.listViewAcsess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Idcl,
            this.фамклиент,
            this.IdS,
            this.фамс,
            this.Наименование,
            this.Стоимость1,
            this.Гарант});
            this.listViewAcsess.FullRowSelect = true;
            this.listViewAcsess.GridLines = true;
            this.listViewAcsess.HideSelection = false;
            this.listViewAcsess.Location = new System.Drawing.Point(440, 12);
            this.listViewAcsess.MultiSelect = false;
            this.listViewAcsess.Name = "listViewAcsess";
            this.listViewAcsess.Size = new System.Drawing.Size(697, 331);
            this.listViewAcsess.TabIndex = 10;
            this.listViewAcsess.UseCompatibleStateImageBehavior = false;
            this.listViewAcsess.View = System.Windows.Forms.View.Details;
            this.listViewAcsess.Visible = false;
            this.listViewAcsess.SelectedIndexChanged += new System.EventHandler(this.listViewAcsess_SelectedIndexChanged);
            // 
            // listViewOper
            // 
            this.listViewOper.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCli,
            this.фамк,
            this.IdSotrud,
            this.фамсотруд,
            this.Опер,
            this.Стоимость2});
            this.listViewOper.FullRowSelect = true;
            this.listViewOper.GridLines = true;
            this.listViewOper.HideSelection = false;
            this.listViewOper.Location = new System.Drawing.Point(440, 12);
            this.listViewOper.MultiSelect = false;
            this.listViewOper.Name = "listViewOper";
            this.listViewOper.Size = new System.Drawing.Size(697, 331);
            this.listViewOper.TabIndex = 11;
            this.listViewOper.UseCompatibleStateImageBehavior = false;
            this.listViewOper.View = System.Windows.Forms.View.Details;
            this.listViewOper.Visible = false;
            this.listViewOper.SelectedIndexChanged += new System.EventHandler(this.listViewOper_SelectedIndexChanged);
            // 
            // Idc
            // 
            this.Idc.Text = "IdClient";
            this.Idc.Width = 52;
            // 
            // IdSotr
            // 
            this.IdSotr.Text = "IdSotrudnik";
            this.IdSotr.Width = 70;
            // 
            // Тип
            // 
            this.Тип.Text = "Модель телефона";
            this.Тип.Width = 146;
            // 
            // Стоимость
            // 
            this.Стоимость.Text = "Стоимость";
            this.Стоимость.Width = 114;
            // 
            // Гарантия
            // 
            this.Гарантия.Text = "Гарантия";
            this.Гарантия.Width = 73;
            // 
            // Idcl
            // 
            this.Idcl.Text = "IdClient";
            this.Idcl.Width = 49;
            // 
            // IdS
            // 
            this.IdS.Text = "IdSotrudnik";
            this.IdS.Width = 66;
            // 
            // Наименование
            // 
            this.Наименование.Text = "Наименование аксессуара";
            this.Наименование.Width = 160;
            // 
            // Стоимость1
            // 
            this.Стоимость1.Text = "Стоимость";
            this.Стоимость1.Width = 115;
            // 
            // Гарант
            // 
            this.Гарант.Text = "Гарантия";
            this.Гарант.Width = 71;
            // 
            // IdCli
            // 
            this.IdCli.Text = "IdClient";
            this.IdCli.Width = 64;
            // 
            // IdSotrud
            // 
            this.IdSotrud.Text = "IdSotrudnik";
            this.IdSotrud.Width = 72;
            // 
            // Опер
            // 
            this.Опер.Text = "Наименование оператора";
            this.Опер.Width = 184;
            // 
            // Стоимость2
            // 
            this.Стоимость2.Text = "Стоимость";
            this.Стоимость2.Width = 112;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 201);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 20);
            this.textBoxPrice.TabIndex = 12;
            // 
            // textBoxGarant
            // 
            this.textBoxGarant.Location = new System.Drawing.Point(218, 201);
            this.textBoxGarant.Multiline = true;
            this.textBoxGarant.Name = "textBoxGarant";
            this.textBoxGarant.Size = new System.Drawing.Size(200, 20);
            this.textBoxGarant.TabIndex = 13;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 185);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 13);
            this.labelPrice.TabIndex = 14;
            this.labelPrice.Text = "Стоимость";
            // 
            // labelGarant
            // 
            this.labelGarant.AutoSize = true;
            this.labelGarant.Location = new System.Drawing.Point(215, 185);
            this.labelGarant.Name = "labelGarant";
            this.labelGarant.Size = new System.Drawing.Size(54, 13);
            this.labelGarant.TabIndex = 15;
            this.labelGarant.Text = "Гарантия";
            // 
            // textBoxModelMobile
            // 
            this.textBoxModelMobile.Location = new System.Drawing.Point(114, 289);
            this.textBoxModelMobile.Name = "textBoxModelMobile";
            this.textBoxModelMobile.Size = new System.Drawing.Size(200, 20);
            this.textBoxModelMobile.TabIndex = 16;
            // 
            // textBoxNameAcsess
            // 
            this.textBoxNameAcsess.Location = new System.Drawing.Point(114, 289);
            this.textBoxNameAcsess.Name = "textBoxNameAcsess";
            this.textBoxNameAcsess.Size = new System.Drawing.Size(200, 20);
            this.textBoxNameAcsess.TabIndex = 17;
            this.textBoxNameAcsess.Visible = false;
            // 
            // textBoxNameOper
            // 
            this.textBoxNameOper.Location = new System.Drawing.Point(114, 289);
            this.textBoxNameOper.Name = "textBoxNameOper";
            this.textBoxNameOper.Size = new System.Drawing.Size(200, 20);
            this.textBoxNameOper.TabIndex = 18;
            this.textBoxNameOper.Visible = false;
            // 
            // labelModelMobile
            // 
            this.labelModelMobile.AutoSize = true;
            this.labelModelMobile.Location = new System.Drawing.Point(161, 273);
            this.labelModelMobile.Name = "labelModelMobile";
            this.labelModelMobile.Size = new System.Drawing.Size(98, 13);
            this.labelModelMobile.TabIndex = 19;
            this.labelModelMobile.Text = "Модель телефона";
            // 
            // labelNameAcsess
            // 
            this.labelNameAcsess.AutoSize = true;
            this.labelNameAcsess.Location = new System.Drawing.Point(136, 273);
            this.labelNameAcsess.Name = "labelNameAcsess";
            this.labelNameAcsess.Size = new System.Drawing.Size(145, 13);
            this.labelNameAcsess.TabIndex = 20;
            this.labelNameAcsess.Text = "Наименование аксессуара";
            this.labelNameAcsess.Visible = false;
            // 
            // labelNameOper
            // 
            this.labelNameOper.AutoSize = true;
            this.labelNameOper.Location = new System.Drawing.Point(142, 273);
            this.labelNameOper.Name = "labelNameOper";
            this.labelNameOper.Size = new System.Drawing.Size(139, 13);
            this.labelNameOper.TabIndex = 21;
            this.labelNameOper.Text = "Наименование оператора";
            this.labelNameOper.Visible = false;
            // 
            // фамкл
            // 
            this.фамкл.Text = "Фамилия клиента";
            this.фамкл.Width = 112;
            // 
            // фамсотр
            // 
            this.фамсотр.Text = "Фамилия сотрудника";
            this.фамсотр.Width = 126;
            // 
            // фамклиент
            // 
            this.фамклиент.Text = "Фамилия клиента";
            this.фамклиент.Width = 109;
            // 
            // фамс
            // 
            this.фамс.Text = "Фамилия сотрудника";
            this.фамс.Width = 122;
            // 
            // фамк
            // 
            this.фамк.Text = "Фамилия клиента";
            this.фамк.Width = 117;
            // 
            // фамсотруд
            // 
            this.фамсотруд.Text = "Фамилия сотрудника";
            this.фамсотруд.Width = 144;
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.labelModelMobile);
            this.Controls.Add(this.textBoxModelMobile);
            this.Controls.Add(this.labelGarant);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxGarant);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.listViewMobile);
            this.Controls.Add(this.listViewAcsess);
            this.Controls.Add(this.label3VidTovar);
            this.Controls.Add(this.labelSotr);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxVidTovar);
            this.Controls.Add(this.comboBoxSotr);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewOper);
            this.Controls.Add(this.textBoxNameAcsess);
            this.Controls.Add(this.textBoxNameOper);
            this.Controls.Add(this.labelNameAcsess);
            this.Controls.Add(this.labelNameOper);
            this.Name = "FormSell";
            this.Text = "FormSell";
            this.Load += new System.EventHandler(this.FormSell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxSotr;
        private System.Windows.Forms.ComboBox comboBoxVidTovar;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelSotr;
        private System.Windows.Forms.Label label3VidTovar;
        private System.Windows.Forms.ListView listViewMobile;
        private System.Windows.Forms.ListView listViewAcsess;
        private System.Windows.Forms.ListView listViewOper;
        private System.Windows.Forms.ColumnHeader Idc;
        private System.Windows.Forms.ColumnHeader IdSotr;
        private System.Windows.Forms.ColumnHeader Тип;
        private System.Windows.Forms.ColumnHeader Стоимость;
        private System.Windows.Forms.ColumnHeader Гарантия;
        private System.Windows.Forms.ColumnHeader Idcl;
        private System.Windows.Forms.ColumnHeader IdS;
        private System.Windows.Forms.ColumnHeader Наименование;
        private System.Windows.Forms.ColumnHeader Стоимость1;
        private System.Windows.Forms.ColumnHeader Гарант;
        private System.Windows.Forms.ColumnHeader IdCli;
        private System.Windows.Forms.ColumnHeader IdSotrud;
        private System.Windows.Forms.ColumnHeader Опер;
        private System.Windows.Forms.ColumnHeader Стоимость2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxGarant;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelGarant;
        private System.Windows.Forms.TextBox textBoxModelMobile;
        private System.Windows.Forms.TextBox textBoxNameAcsess;
        private System.Windows.Forms.TextBox textBoxNameOper;
        private System.Windows.Forms.Label labelModelMobile;
        private System.Windows.Forms.Label labelNameAcsess;
        private System.Windows.Forms.Label labelNameOper;
        private System.Windows.Forms.ColumnHeader фамкл;
        private System.Windows.Forms.ColumnHeader фамсотр;
        private System.Windows.Forms.ColumnHeader фамклиент;
        private System.Windows.Forms.ColumnHeader фамс;
        private System.Windows.Forms.ColumnHeader фамк;
        private System.Windows.Forms.ColumnHeader фамсотруд;
    }
}