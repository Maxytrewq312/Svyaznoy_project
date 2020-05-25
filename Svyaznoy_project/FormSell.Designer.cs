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
            this.Idc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамкл = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdSotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамсотр = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Тип = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Стоимость = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Гарантия = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAcsess = new System.Windows.Forms.ListView();
            this.Idcl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамклиент = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамс = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Наименование = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Стоимость1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Гарант = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewOper = new System.Windows.Forms.ListView();
            this.IdCli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамк = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdSotrud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.фамсотруд = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Silver;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(780, 421);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(140, 52);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Silver;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(926, 421);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(140, 52);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Silver;
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(1072, 421);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(140, 52);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(14, 47);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(233, 22);
            this.comboBoxClient.TabIndex = 3;
            // 
            // comboBoxSotr
            // 
            this.comboBoxSotr.FormattingEnabled = true;
            this.comboBoxSotr.Location = new System.Drawing.Point(254, 47);
            this.comboBoxSotr.Name = "comboBoxSotr";
            this.comboBoxSotr.Size = new System.Drawing.Size(233, 22);
            this.comboBoxSotr.TabIndex = 4;
            // 
            // comboBoxVidTovar
            // 
            this.comboBoxVidTovar.FormattingEnabled = true;
            this.comboBoxVidTovar.Items.AddRange(new object[] {
            "Мобильный телефон",
            "Аксессуар",
            "Оператор"});
            this.comboBoxVidTovar.Location = new System.Drawing.Point(133, 131);
            this.comboBoxVidTovar.Name = "comboBoxVidTovar";
            this.comboBoxVidTovar.Size = new System.Drawing.Size(233, 22);
            this.comboBoxVidTovar.TabIndex = 5;
            this.comboBoxVidTovar.SelectedIndexChanged += new System.EventHandler(this.comboBoxVidTovar_SelectedIndexChanged);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(14, 30);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "Клиент";
            // 
            // labelSotr
            // 
            this.labelSotr.AutoSize = true;
            this.labelSotr.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSotr.Location = new System.Drawing.Point(251, 30);
            this.labelSotr.Name = "labelSotr";
            this.labelSotr.Size = new System.Drawing.Size(61, 13);
            this.labelSotr.TabIndex = 7;
            this.labelSotr.Text = "Сотрудник";
            // 
            // label3VidTovar
            // 
            this.label3VidTovar.AutoSize = true;
            this.label3VidTovar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3VidTovar.Location = new System.Drawing.Point(212, 114);
            this.label3VidTovar.Name = "label3VidTovar";
            this.label3VidTovar.Size = new System.Drawing.Size(65, 13);
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
            this.listViewMobile.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMobile.FullRowSelect = true;
            this.listViewMobile.GridLines = true;
            this.listViewMobile.HideSelection = false;
            this.listViewMobile.Location = new System.Drawing.Point(522, 12);
            this.listViewMobile.MultiSelect = false;
            this.listViewMobile.Name = "listViewMobile";
            this.listViewMobile.Size = new System.Drawing.Size(699, 356);
            this.listViewMobile.TabIndex = 9;
            this.listViewMobile.UseCompatibleStateImageBehavior = false;
            this.listViewMobile.View = System.Windows.Forms.View.Details;
            this.listViewMobile.SelectedIndexChanged += new System.EventHandler(this.listViewMobile_SelectedIndexChanged);
            // 
            // Idc
            // 
            this.Idc.Text = "IdClient";
            this.Idc.Width = 52;
            // 
            // фамкл
            // 
            this.фамкл.Text = "Фамилия клиента";
            this.фамкл.Width = 112;
            // 
            // IdSotr
            // 
            this.IdSotr.Text = "IdSotrudnik";
            this.IdSotr.Width = 70;
            // 
            // фамсотр
            // 
            this.фамсотр.Text = "Фамилия сотрудника";
            this.фамсотр.Width = 126;
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
            this.listViewAcsess.Location = new System.Drawing.Point(522, 12);
            this.listViewAcsess.MultiSelect = false;
            this.listViewAcsess.Name = "listViewAcsess";
            this.listViewAcsess.Size = new System.Drawing.Size(699, 356);
            this.listViewAcsess.TabIndex = 10;
            this.listViewAcsess.UseCompatibleStateImageBehavior = false;
            this.listViewAcsess.View = System.Windows.Forms.View.Details;
            this.listViewAcsess.Visible = false;
            this.listViewAcsess.SelectedIndexChanged += new System.EventHandler(this.listViewAcsess_SelectedIndexChanged);
            // 
            // Idcl
            // 
            this.Idcl.Text = "IdClient";
            this.Idcl.Width = 49;
            // 
            // фамклиент
            // 
            this.фамклиент.Text = "Фамилия клиента";
            this.фамклиент.Width = 109;
            // 
            // IdS
            // 
            this.IdS.Text = "IdSotrudnik";
            this.IdS.Width = 66;
            // 
            // фамс
            // 
            this.фамс.Text = "Фамилия сотрудника";
            this.фамс.Width = 122;
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
            this.listViewOper.Location = new System.Drawing.Point(522, 12);
            this.listViewOper.MultiSelect = false;
            this.listViewOper.Name = "listViewOper";
            this.listViewOper.Size = new System.Drawing.Size(699, 356);
            this.listViewOper.TabIndex = 11;
            this.listViewOper.UseCompatibleStateImageBehavior = false;
            this.listViewOper.View = System.Windows.Forms.View.Details;
            this.listViewOper.Visible = false;
            this.listViewOper.SelectedIndexChanged += new System.EventHandler(this.listViewOper_SelectedIndexChanged);
            // 
            // IdCli
            // 
            this.IdCli.Text = "IdClient";
            this.IdCli.Width = 64;
            // 
            // фамк
            // 
            this.фамк.Text = "Фамилия клиента";
            this.фамк.Width = 117;
            // 
            // IdSotrud
            // 
            this.IdSotrud.Text = "IdSotrudnik";
            this.IdSotrud.Width = 72;
            // 
            // фамсотруд
            // 
            this.фамсотруд.Text = "Фамилия сотрудника";
            this.фамсотруд.Width = 144;
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
            this.textBoxPrice.Location = new System.Drawing.Point(14, 216);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(233, 21);
            this.textBoxPrice.TabIndex = 12;
            // 
            // textBoxGarant
            // 
            this.textBoxGarant.Location = new System.Drawing.Point(254, 216);
            this.textBoxGarant.Multiline = true;
            this.textBoxGarant.Name = "textBoxGarant";
            this.textBoxGarant.Size = new System.Drawing.Size(233, 21);
            this.textBoxGarant.TabIndex = 13;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(14, 199);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 13);
            this.labelPrice.TabIndex = 14;
            this.labelPrice.Text = "Стоимость";
            // 
            // labelGarant
            // 
            this.labelGarant.AutoSize = true;
            this.labelGarant.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGarant.Location = new System.Drawing.Point(251, 199);
            this.labelGarant.Name = "labelGarant";
            this.labelGarant.Size = new System.Drawing.Size(53, 13);
            this.labelGarant.TabIndex = 15;
            this.labelGarant.Text = "Гарантия";
            // 
            // textBoxModelMobile
            // 
            this.textBoxModelMobile.Location = new System.Drawing.Point(133, 311);
            this.textBoxModelMobile.Name = "textBoxModelMobile";
            this.textBoxModelMobile.Size = new System.Drawing.Size(233, 22);
            this.textBoxModelMobile.TabIndex = 16;
            // 
            // textBoxNameAcsess
            // 
            this.textBoxNameAcsess.Location = new System.Drawing.Point(133, 311);
            this.textBoxNameAcsess.Name = "textBoxNameAcsess";
            this.textBoxNameAcsess.Size = new System.Drawing.Size(233, 22);
            this.textBoxNameAcsess.TabIndex = 17;
            this.textBoxNameAcsess.Visible = false;
            // 
            // textBoxNameOper
            // 
            this.textBoxNameOper.Location = new System.Drawing.Point(133, 311);
            this.textBoxNameOper.Name = "textBoxNameOper";
            this.textBoxNameOper.Size = new System.Drawing.Size(233, 22);
            this.textBoxNameOper.TabIndex = 18;
            this.textBoxNameOper.Visible = false;
            // 
            // labelModelMobile
            // 
            this.labelModelMobile.AutoSize = true;
            this.labelModelMobile.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModelMobile.Location = new System.Drawing.Point(197, 294);
            this.labelModelMobile.Name = "labelModelMobile";
            this.labelModelMobile.Size = new System.Drawing.Size(99, 13);
            this.labelModelMobile.TabIndex = 19;
            this.labelModelMobile.Text = "Модель телефона";
            // 
            // labelNameAcsess
            // 
            this.labelNameAcsess.AutoSize = true;
            this.labelNameAcsess.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameAcsess.Location = new System.Drawing.Point(166, 294);
            this.labelNameAcsess.Name = "labelNameAcsess";
            this.labelNameAcsess.Size = new System.Drawing.Size(145, 13);
            this.labelNameAcsess.TabIndex = 20;
            this.labelNameAcsess.Text = "Наименование аксессуара";
            this.labelNameAcsess.Visible = false;
            // 
            // labelNameOper
            // 
            this.labelNameOper.AutoSize = true;
            this.labelNameOper.Location = new System.Drawing.Point(166, 294);
            this.labelNameOper.Name = "labelNameOper";
            this.labelNameOper.Size = new System.Drawing.Size(152, 14);
            this.labelNameOper.TabIndex = 21;
            this.labelNameOper.Text = "Наименование оператора";
            this.labelNameOper.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Svyaznoy_project.Properties.Resources.связной_лого;
            this.pictureBox1.Location = new System.Drawing.Point(12, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FormSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 485);
            this.Controls.Add(this.pictureBox1);
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
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупка товаров";
            this.Load += new System.EventHandler(this.FormSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}