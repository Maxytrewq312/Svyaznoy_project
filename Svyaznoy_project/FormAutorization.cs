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
    public struct Autoriz
    {
        public string login;
        public string password;
        public string typeuser;
    }
    public partial class FormAutorization : Form
    {
        public static Autoriz autom = new Autoriz();
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool cluch = false;
                foreach (Autorization auto in Program.SpDb.Autorization)
                {
                    if (textBoxLogin.Text == auto.Login && textBoxPassword.Text == auto.Password)
                    {
                        cluch = true;
                        autom.login = auto.Login;
                        autom.password = auto.Password;
                        autom.typeuser = auto.TypeUser;
                    }
                }
                if (!cluch)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
            }
        }
    }
}
