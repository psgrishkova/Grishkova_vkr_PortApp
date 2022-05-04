using Grishkova_vkr_PortApp.Controllers;
using System;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    public partial class AddSetNavForm : Form
    {
        private CRUDController controller;
        private bool action = true; //true - добавление, false - изменение
        private object[] data;
        public AddSetNavForm(CRUDController controller, object[] data)
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
            num_textBox.Text = data[0].ToString();
            startDateTimePicker.Value = (DateTime)data[1];
            if (!data[2].GetType().Name.Equals("DBNull"))
                endDateTimePicker.Value = (DateTime)data[2];
        }

        private void NullCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            endDateTimePicker.Enabled = !endDateTimePicker.Enabled;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Object end = null;
            if (endDateTimePicker.Enabled)
                end = endDateTimePicker.Value;

            try
            {
                if (action)
                    controller.add(new object[] { num_textBox.Text, startDateTimePicker.Value, end });
                else controller.set(new object[] { num_textBox.Text, startDateTimePicker.Value, end }, data);

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
