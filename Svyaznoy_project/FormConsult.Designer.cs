namespace Svyaznoy_project
{
    partial class FormConsult
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
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxSotr = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelSotr = new System.Windows.Forms.Label();
            this.labelTypeOfCons = new System.Windows.Forms.Label();
            this.listViewMobileCons = new System.Windows.Forms.ListView();
            this.comboBoxTypeOfCons = new System.Windows.Forms.ComboBox();
            this.listViewAcsessCons = new System.Windows.Forms.ListView();
            this.listViewOperCons = new System.Windows.Forms.ListView();
            this.Idcl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ids = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Предпочт = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Idclient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdSotr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Предпочтение = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Idclient1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Idsotrud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Предп = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ФамилияКл = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ФамилияС = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фамкл = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фамсотр = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фамклиента = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ФамСотрудника = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxPredMobile = new System.Windows.Forms.TextBox();
            this.textBoxPredAcsess = new System.Windows.Forms.TextBox();
            this.textBoxPredOper = new System.Windows.Forms.TextBox();
            this.labelPredMobile = new System.Windows.Forms.Label();
            this.labelPredAcsess = new System.Windows.Forms.Label();
            this.labelPredOper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(36, 56);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(174, 21);
            this.comboBoxClient.TabIndex = 0;
            // 
            // comboBoxSotr
            // 
            this.comboBoxSotr.FormattingEnabled = true;
            this.comboBoxSotr.Location = new System.Drawing.Point(36, 131);
            this.comboBoxSotr.Name = "comboBoxSotr";
            this.comboBoxSotr.Size = new System.Drawing.Size(174, 21);
            this.comboBoxSotr.TabIndex = 1;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(33, 40);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 13);
            this.labelClient.TabIndex = 3;
            this.labelClient.Text = "Клиент";
            // 
            // labelSotr
            // 
            this.labelSotr.AutoSize = true;
            this.labelSotr.Location = new System.Drawing.Point(33, 115);
            this.labelSotr.Name = "labelSotr";
            this.labelSotr.Size = new System.Drawing.Size(60, 13);
            this.labelSotr.TabIndex = 4;
            this.labelSotr.Text = "Сотрудник";
            // 
            // labelTypeOfCons
            // 
            this.labelTypeOfCons.AutoSize = true;
            this.labelTypeOfCons.Location = new System.Drawing.Point(33, 196);
            this.labelTypeOfCons.Name = "labelTypeOfCons";
            this.labelTypeOfCons.Size = new System.Drawing.Size(99, 13);
            this.labelTypeOfCons.TabIndex = 5;
            this.labelTypeOfCons.Text = "Тип консультации";
            // 
            // listViewMobileCons
            // 
            this.listViewMobileCons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Idcl,
            this.ФамилияКл,
            this.Ids,
            this.ФамилияС,
            this.Предпочт});
            this.listViewMobileCons.FullRowSelect = true;
            this.listViewMobileCons.GridLines = true;
            this.listViewMobileCons.HideSelection = false;
            this.listViewMobileCons.Location = new System.Drawing.Point(280, 40);
            this.listViewMobileCons.MultiSelect = false;
            this.listViewMobileCons.Name = "listViewMobileCons";
            this.listViewMobileCons.Size = new System.Drawing.Size(719, 303);
            this.listViewMobileCons.TabIndex = 6;
            this.listViewMobileCons.UseCompatibleStateImageBehavior = false;
            this.listViewMobileCons.View = System.Windows.Forms.View.Details;
            // 
            // comboBoxTypeOfCons
            // 
            this.comboBoxTypeOfCons.FormattingEnabled = true;
            this.comboBoxTypeOfCons.Items.AddRange(new object[] {
            "По покупке телефона",
            "По покупке аксессуара",
            "По выбору оператора"});
            this.comboBoxTypeOfCons.Location = new System.Drawing.Point(36, 212);
            this.comboBoxTypeOfCons.Name = "comboBoxTypeOfCons";
            this.comboBoxTypeOfCons.Size = new System.Drawing.Size(174, 21);
            this.comboBoxTypeOfCons.TabIndex = 7;
            // 
            // listViewAcsessCons
            // 
            this.listViewAcsessCons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Idclient,
            this.Фамкл,
            this.IdSotr,
            this.Фамсотр,
            this.Предпочтение});
            this.listViewAcsessCons.FullRowSelect = true;
            this.listViewAcsessCons.GridLines = true;
            this.listViewAcsessCons.HideSelection = false;
            this.listViewAcsessCons.Location = new System.Drawing.Point(280, 40);
            this.listViewAcsessCons.MultiSelect = false;
            this.listViewAcsessCons.Name = "listViewAcsessCons";
            this.listViewAcsessCons.Size = new System.Drawing.Size(719, 303);
            this.listViewAcsessCons.TabIndex = 8;
            this.listViewAcsessCons.UseCompatibleStateImageBehavior = false;
            this.listViewAcsessCons.View = System.Windows.Forms.View.Details;
            this.listViewAcsessCons.Visible = false;
            // 
            // listViewOperCons
            // 
            this.listViewOperCons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Idclient1,
            this.Фамклиента,
            this.Idsotrud,
            this.ФамСотрудника,
            this.Предп});
            this.listViewOperCons.FullRowSelect = true;
            this.listViewOperCons.GridLines = true;
            this.listViewOperCons.HideSelection = false;
            this.listViewOperCons.Location = new System.Drawing.Point(280, 40);
            this.listViewOperCons.MultiSelect = false;
            this.listViewOperCons.Name = "listViewOperCons";
            this.listViewOperCons.Size = new System.Drawing.Size(719, 303);
            this.listViewOperCons.TabIndex = 9;
            this.listViewOperCons.UseCompatibleStateImageBehavior = false;
            this.listViewOperCons.View = System.Windows.Forms.View.Details;
            this.listViewOperCons.Visible = false;
            this.listViewOperCons.SelectedIndexChanged += new System.EventHandler(this.listViewOperCons_SelectedIndexChanged);
            // 
            // Idcl
            // 
            this.Idcl.Text = "IdClient";
            this.Idcl.Width = 89;
            // 
            // Ids
            // 
            this.Ids.Text = "IdSotrudnik";
            this.Ids.Width = 88;
            // 
            // Предпочт
            // 
            this.Предпочт.Text = "Предпочтения в телефоне";
            this.Предпочт.Width = 258;
            // 
            // Idclient
            // 
            this.Idclient.Text = "IdClient";
            this.Idclient.Width = 93;
            // 
            // IdSotr
            // 
            this.IdSotr.Text = "IdSotrudnik";
            this.IdSotr.Width = 88;
            // 
            // Предпочтение
            // 
            this.Предпочтение.Text = "Предпочтение в аксессуаре";
            this.Предпочтение.Width = 259;
            // 
            // Idclient1
            // 
            this.Idclient1.Text = "IdClient";
            this.Idclient1.Width = 95;
            // 
            // Idsotrud
            // 
            this.Idsotrud.Text = "IdSotrudnik";
            this.Idsotrud.Width = 88;
            // 
            // Предп
            // 
            this.Предп.Text = "Предпочтение в выборе оператора";
            this.Предп.Width = 255;
            // 
            // ФамилияКл
            // 
            this.ФамилияКл.Text = "Фамилия клиента";
            this.ФамилияКл.Width = 127;
            // 
            // ФамилияС
            // 
            this.ФамилияС.Text = "Фамилия сотрудника";
            this.ФамилияС.Width = 151;
            // 
            // Фамкл
            // 
            this.Фамкл.Text = "Фамилия клиента";
            this.Фамкл.Width = 123;
            // 
            // Фамсотр
            // 
            this.Фамсотр.Text = "Фамилия сотрудника";
            this.Фамсотр.Width = 152;
            // 
            // Фамклиента
            // 
            this.Фамклиента.Text = "Фамилия клиента";
            this.Фамклиента.Width = 123;
            // 
            // ФамСотрудника
            // 
            this.ФамСотрудника.Text = "Фамилия сотрудника";
            this.ФамСотрудника.Width = 153;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(627, 390);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 48);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(753, 390);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 48);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(879, 390);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(120, 48);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // textBoxPredMobile
            // 
            this.textBoxPredMobile.Location = new System.Drawing.Point(36, 293);
            this.textBoxPredMobile.Name = "textBoxPredMobile";
            this.textBoxPredMobile.Size = new System.Drawing.Size(174, 20);
            this.textBoxPredMobile.TabIndex = 13;
            // 
            // textBoxPredAcsess
            // 
            this.textBoxPredAcsess.Location = new System.Drawing.Point(36, 293);
            this.textBoxPredAcsess.Name = "textBoxPredAcsess";
            this.textBoxPredAcsess.Size = new System.Drawing.Size(174, 20);
            this.textBoxPredAcsess.TabIndex = 14;
            this.textBoxPredAcsess.Visible = false;
            // 
            // textBoxPredOper
            // 
            this.textBoxPredOper.Location = new System.Drawing.Point(36, 293);
            this.textBoxPredOper.Name = "textBoxPredOper";
            this.textBoxPredOper.Size = new System.Drawing.Size(174, 20);
            this.textBoxPredOper.TabIndex = 15;
            this.textBoxPredOper.Visible = false;
            // 
            // labelPredMobile
            // 
            this.labelPredMobile.AutoSize = true;
            this.labelPredMobile.Location = new System.Drawing.Point(33, 277);
            this.labelPredMobile.Name = "labelPredMobile";
            this.labelPredMobile.Size = new System.Drawing.Size(140, 13);
            this.labelPredMobile.TabIndex = 16;
            this.labelPredMobile.Text = "Предпочтение в телефоне";
            // 
            // labelPredAcsess
            // 
            this.labelPredAcsess.AutoSize = true;
            this.labelPredAcsess.Location = new System.Drawing.Point(33, 277);
            this.labelPredAcsess.Name = "labelPredAcsess";
            this.labelPredAcsess.Size = new System.Drawing.Size(150, 13);
            this.labelPredAcsess.TabIndex = 17;
            this.labelPredAcsess.Text = "Предпочтение в аксессуаре";
            this.labelPredAcsess.Visible = false;
            // 
            // labelPredOper
            // 
            this.labelPredOper.AutoSize = true;
            this.labelPredOper.Location = new System.Drawing.Point(33, 277);
            this.labelPredOper.Name = "labelPredOper";
            this.labelPredOper.Size = new System.Drawing.Size(185, 13);
            this.labelPredOper.TabIndex = 18;
            this.labelPredOper.Text = "Предпочтение в выборе оператора";
            this.labelPredOper.Visible = false;
            // 
            // FormConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.labelPredMobile);
            this.Controls.Add(this.textBoxPredMobile);
            this.Controls.Add(this.listViewMobileCons);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewAcsessCons);
            this.Controls.Add(this.comboBoxTypeOfCons);
            this.Controls.Add(this.labelTypeOfCons);
            this.Controls.Add(this.labelSotr);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxSotr);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.listViewOperCons);
            this.Controls.Add(this.textBoxPredAcsess);
            this.Controls.Add(this.textBoxPredOper);
            this.Controls.Add(this.labelPredAcsess);
            this.Controls.Add(this.labelPredOper);
            this.Name = "FormConsult";
            this.Text = "FormConsult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxSotr;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelSotr;
        private System.Windows.Forms.Label labelTypeOfCons;
        private System.Windows.Forms.ListView listViewMobileCons;
        private System.Windows.Forms.ComboBox comboBoxTypeOfCons;
        private System.Windows.Forms.ListView listViewAcsessCons;
        private System.Windows.Forms.ListView listViewOperCons;
        private System.Windows.Forms.ColumnHeader Idcl;
        private System.Windows.Forms.ColumnHeader ФамилияКл;
        private System.Windows.Forms.ColumnHeader Ids;
        private System.Windows.Forms.ColumnHeader ФамилияС;
        private System.Windows.Forms.ColumnHeader Предпочт;
        private System.Windows.Forms.ColumnHeader Idclient;
        private System.Windows.Forms.ColumnHeader Фамкл;
        private System.Windows.Forms.ColumnHeader IdSotr;
        private System.Windows.Forms.ColumnHeader Фамсотр;
        private System.Windows.Forms.ColumnHeader Предпочтение;
        private System.Windows.Forms.ColumnHeader Idclient1;
        private System.Windows.Forms.ColumnHeader Фамклиента;
        private System.Windows.Forms.ColumnHeader Idsotrud;
        private System.Windows.Forms.ColumnHeader ФамСотрудника;
        private System.Windows.Forms.ColumnHeader Предп;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxPredMobile;
        private System.Windows.Forms.TextBox textBoxPredAcsess;
        private System.Windows.Forms.TextBox textBoxPredOper;
        private System.Windows.Forms.Label labelPredMobile;
        private System.Windows.Forms.Label labelPredAcsess;
        private System.Windows.Forms.Label labelPredOper;
    }
}