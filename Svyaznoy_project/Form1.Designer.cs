namespace Svyaznoy_project
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonSotr = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonConsult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelprivet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.Silver;
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClient.Location = new System.Drawing.Point(12, 171);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(399, 48);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Клиент";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonSotr
            // 
            this.buttonSotr.BackColor = System.Drawing.Color.Silver;
            this.buttonSotr.FlatAppearance.BorderSize = 0;
            this.buttonSotr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSotr.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSotr.Location = new System.Drawing.Point(12, 259);
            this.buttonSotr.Name = "buttonSotr";
            this.buttonSotr.Size = new System.Drawing.Size(399, 48);
            this.buttonSotr.TabIndex = 1;
            this.buttonSotr.Text = "Сотрудник";
            this.buttonSotr.UseVisualStyleBackColor = false;
            this.buttonSotr.Click += new System.EventHandler(this.buttonSotr_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.Silver;
            this.buttonSell.FlatAppearance.BorderSize = 0;
            this.buttonSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSell.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSell.Location = new System.Drawing.Point(12, 352);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(399, 48);
            this.buttonSell.TabIndex = 2;
            this.buttonSell.Text = "Покупка товаров";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonConsult
            // 
            this.buttonConsult.BackColor = System.Drawing.Color.Silver;
            this.buttonConsult.FlatAppearance.BorderSize = 0;
            this.buttonConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsult.Font = new System.Drawing.Font("Roboto", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConsult.Location = new System.Drawing.Point(12, 437);
            this.buttonConsult.Name = "buttonConsult";
            this.buttonConsult.Size = new System.Drawing.Size(399, 48);
            this.buttonConsult.TabIndex = 3;
            this.buttonConsult.Text = "Консультация специалиста";
            this.buttonConsult.UseVisualStyleBackColor = false;
            this.buttonConsult.Click += new System.EventHandler(this.buttonConsult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Svyaznoy_project.Properties.Resources.kisspng_logo_brand_font_product_clip_art_svyaznoy_list_apps_5bf007bc2a6019_5261498615424572761736;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelprivet
            // 
            this.labelprivet.AutoSize = true;
            this.labelprivet.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelprivet.Location = new System.Drawing.Point(160, 9);
            this.labelprivet.Name = "labelprivet";
            this.labelprivet.Size = new System.Drawing.Size(54, 14);
            this.labelprivet.TabIndex = 5;
            this.labelprivet.Text = "Здарова";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(423, 527);
            this.Controls.Add(this.labelprivet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonConsult);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonSotr);
            this.Controls.Add(this.buttonClient);
            this.Name = "Main";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonSotr;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonConsult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelprivet;
    }
}

