using Grishkova_vkr_PortApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    public partial class AddSetCategoryForm : Form
    {
        private CRUDController controller;
        private bool action = true; //true - добавление, false - изменение
        private object[] data;

        public AddSetCategoryForm(CRUDController controller, object[] data)
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
        }

        public AddSetCategoryForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (action)
                    controller.add(new object[] { name_textBox.Text});
                else controller.set(new object[] { name_textBox.Text}, data);

                this.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Данная категория уже используется в формировании прайс-листа, поэтому изменение недоступно");
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
