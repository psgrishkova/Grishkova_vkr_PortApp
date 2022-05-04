using Grishkova_vkr_PortApp.Controllers;
using System;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    public partial class AddSetCompanyForm : Form
    {
        private CRUDController controller;
        private bool action = true; //true - добавление, false - изменение
        private object[] data;
        public AddSetCompanyForm(CRUDController controller, object[] data)
        {
            InitializeComponent();
            this.controller = controller;

            if (data != null)
            {
                this.data = data;
                action = false;
                setData();
            }
        }

        private void setData()
        {
            name_textBox.Text = (string)data[0];
            inn_textBox.Text = (string)data[1];
            tel_textBox.Text =  data[2].ToString();
            legalAdress_textBox.Text = (string)data[3];
            physicalAddress_textBox.Text = (string)data[4];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (action)
                    controller.add(new object[] { name_textBox.Text, inn_textBox.Text, tel_textBox.Text, legalAdress_textBox.Text, physicalAddress_textBox.Text });
                else controller.set(new object[] { name_textBox.Text, inn_textBox.Text, tel_textBox.Text, legalAdress_textBox.Text, physicalAddress_textBox.Text }, data);

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
