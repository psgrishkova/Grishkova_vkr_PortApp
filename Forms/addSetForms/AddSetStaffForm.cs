using Grishkova_vkr_PortApp.Controllers;
using Grishkova_vkr_PortApp.Controllers.ReferenceData;
using System;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    public partial class AddSetStaffForm : Form
    {
        private StaffController controller;
        private bool action = true; //true - добавление, false - изменение
        private object[] data;
        public AddSetStaffForm(CRUDController controller, object[] data)
        {
            InitializeComponent();
            role_comboBox.SelectedIndex = 0;
            this.controller = (StaffController)controller;

            if (data != null)
            {
                this.data = data;
                action = false;
                setData();
                role_comboBox.Enabled = false;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                string tel = tel_maskedTextBox.Text.Replace("(", String.Empty).Replace(")", String.Empty);
                if (action)
                    controller.add(new object[] { name_textBox.Text, tel, bday_dateTimePicker.Value, role_comboBox.SelectedItem });
                else controller.set(new object[] { name_textBox.Text, tel, bday_dateTimePicker.Value.ToShortDateString().Replace('.','-') }, data);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (!action)
                    setData();
            }
        }

        private void setData()
        {
            name_textBox.Text = data[0].ToString();
            tel_maskedTextBox.Text = data[1].ToString();
            bday_dateTimePicker.Value = (DateTime)data[2];
            role_comboBox.SelectedItem = controller.getRole(data);
        }
    }
}
