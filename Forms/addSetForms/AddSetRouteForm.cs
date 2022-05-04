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
    public partial class AddSetRouteForm : Form
    {
        private CRUDController controller;
        private bool action = true; //true - добавление, false - изменение
        private object[] data;
        public AddSetRouteForm(CRUDController controller, object[] data)
        {
            InitializeComponent();
            this.controller = controller;
            
            if (data != null)
            {
                this.data = data;
                action = false;
                
                setData();
            }
            num_textBox.Enabled = action;
        }

        private void setData()
        {
            num_textBox.Text = data[1].ToString();
            name_textBox.Text =  (string)data[0];
            start_textBox.Text = (string)data[2];
            end_textBox.Text = (string)data[3];
            desc_textBox.Text = (string)data[4];
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (action)
                    controller.add(new object[] { name_textBox.Text, num_textBox.Text, start_textBox.Text, end_textBox.Text, desc_textBox.Text });
                else controller.set(new object[] { name_textBox.Text, num_textBox.Text, start_textBox.Text, end_textBox.Text, desc_textBox.Text }, data);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (!action)
                    setData();

            }
        }
    }
}
