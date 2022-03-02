using Grishkova_vkr_PortApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    public partial class AddSetAccount : Form
    {

        private CRUDController controller;
        private bool action = true; //true - добавление, false - изменение
        private object[] data;


        public AddSetAccount(CRUDController controller, object[] data)
        {
            InitializeComponent();
            this.controller = controller;
            role_comboBox.SelectedIndex = 0;
            if (data != null)
            {
                this.data = data;
                action = false;
                setData();
            }
        }

        private void setData()
        {
            login_textBox.Text = (string)data[0];
            pass_textBox.Text = (string)data[1];
            if (((string)data[2]).Equals("Менеджер"))
                role_comboBox.SelectedIndex = 0;
            else role_comboBox.SelectedIndex = 1;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (action)
                    controller.add(new object[] { login_textBox.Text, pass_textBox.Text, role_comboBox.SelectedItem });
                else controller.set(new object[] { login_textBox.Text, pass_textBox.Text, role_comboBox.SelectedItem }, data);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                this.Controls.Clear();
                this.InitializeComponent();
                if (!action)
                    setData();

            }
        }
    }
}
