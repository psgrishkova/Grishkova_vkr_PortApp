using Grishkova_vkr_PortApp.Controllers;
using System;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.addForms
{
    public partial class addSetVesselForm : Form
    {
        private CRUDController controller;
        private bool action = true; //true - добавление, false - изменение
        private object[] data;
        public addSetVesselForm(CRUDController controller, object[] data)
        {
            InitializeComponent();
            type_comboBox.SelectedIndex = 0;
            this.controller = controller;
            dateTimePicker.MaxDate = DateTime.Now;

            if (data != null)
            {
                this.data = data;
                action = false;
                setData();
            }
            else dateTimePicker.Value = DateTime.Now;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (action)
                    controller.add(new object[] { number_textBox.Text, dateTimePicker.Value, name_textBox.Text, type_comboBox.SelectedItem, places_numericUpDown.Value });
                else controller.set(new object[] { number_textBox.Text, dateTimePicker.Value, name_textBox.Text, type_comboBox.SelectedItem, places_numericUpDown.Value }, data);

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

        private void setData()
        {
            number_textBox.Text = (string)data[0];
            dateTimePicker.Value = (DateTime)data[1];
            name_textBox.Text = (string)data[2];
            type_comboBox.SelectedItem = (string)data[3];
            places_numericUpDown.Value = Convert.ToInt32(data[4]);
        }

        private void addSetVesselForm_Load(object sender, EventArgs e)
        {

        }
    }
}
