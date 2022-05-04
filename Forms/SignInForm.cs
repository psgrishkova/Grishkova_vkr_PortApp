using Grishkova_vkr_PortApp.Controllers;
using Grishkova_vkr_PortApp.Forms;
using System;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp
{
    public partial class SignIn_Form : Form
    {
        public SignIn_Form()
        {
            InitializeComponent();
            Role.authForm = this;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (login_textBox.TextLength != 0 && pass_textBox.TextLength != 0)
            {
                string role = AuthController.authorization(this.аккаунтTableAdapter1, login_textBox.Text, pass_textBox.Text);
                if (!string.IsNullOrEmpty(role))
                {
                    Role.role = role;
                    Role.menu = new MenuForm();
                    Role.menu.repaint();
                    Role.menu.Show();
                    this.Hide();
                }
                else MessageBox.Show("Введены неверные учетные данные. Попробуйте еще раз");
            }
            else MessageBox.Show("Введите учетные данные");
        }

        public void repaint()
        {
            login_textBox.Clear();
            pass_textBox.Clear();
        }
    }
}
