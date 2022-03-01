using Grishkova_vkr_PortApp.Controllers;
using Grishkova_vkr_PortApp.Controllers.ReferenceData;
using Grishkova_vkr_PortApp.Forms.addForms;
using Grishkova_vkr_PortApp.Forms.addSetForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms
{
    public partial class ReferenceDataForm : Form
    {
        CRUDController controller;
        Form addSetForm;
        DataGridView grid;
        public ReferenceDataForm()
        {
            InitializeComponent();
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            openAddSetForm(referenceData_tabControl.SelectedIndex, null);
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid.SelectedRows.Count == 0)
                    MessageBox.Show("Выберите строку для удаления");
                else
                {
                    controller.remove(grid.SelectedRows[0].Cells.Cast<DataGridViewCell>().ToList().Select(x => x.Value).ToArray());
                }
            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Выбранные данные уже используются в формировании рейса. Прежде, удалите данные о рейсе.");
            }
        }

        private void set_button_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count == 0)
                MessageBox.Show("Выберите строку для изменения");
            else
            {
                openAddSetForm(referenceData_tabControl.SelectedIndex, grid.SelectedRows[0].Cells.Cast<DataGridViewCell>().ToList().Select(x => x.Value).ToArray());
            }
        }

        private void referenceData_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDataBySelectedPage(referenceData_tabControl.SelectedIndex);
        }

        private void setDataBySelectedPage(int pageIndex)
        {
            switch (pageIndex)
            {
                case 0:
                    controller = new VesselController(this.судноTableAdapter, this.demoDataSet.Судно);
                    break;
                case 1:
                    controller = new NavController(this.навигацияTableAdapter, this.demoDataSet.Навигация);
                    break;
                case 2:
                    controller = new RouteController(this.маршрутTableAdapter, this.demoDataSet.Маршрут);
                    break;
            }
            //
            grid = (DataGridView)referenceData_tabControl.SelectedTab.Controls[0];
            setComboBoxValues(grid);
        }

        private void setComboBoxValues(DataGridView grid)
        {
            getBy_comboBox.Items.Clear();
            foreach (DataGridViewTextBoxColumn s in grid.Columns)
                getBy_comboBox.Items.Add(s.DataPropertyName);
            if (getBy_comboBox.Items.Count != 0)
            {
                getBy_comboBox.SelectedItem = getBy_comboBox.Items[0];
            }
        }

        private void openAddSetForm(int pageIndex, object[] data)
        {
            switch (pageIndex)
            {
                case 0:
                    addSetForm = new addSetVesselForm(controller, data);
                    break;
                case 1:
                    addSetForm = new AddSetNavForm(controller, data);
                    break;
                case 2:
                    addSetForm = new AddSetRouteForm(controller, data);
                    break;
                case 3:

                    break;
            }
            addSetForm.Show();
            if (addSetForm != null)
            {
                this.Enabled = false;
                addSetForm.FormClosed += (obj, args) =>
                {
                    this.Enabled = true;
                    addSetForm = null;
                };
            }
        }

        private void getBy_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getBy_textBox.Text))
                судноBindingSource.Filter = "[" + getBy_comboBox.SelectedItem.ToString() + "] = '" + getBy_textBox.Text + "'";
            else MessageBox.Show("Введите данные для поиска");
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            судноBindingSource.RemoveFilter();
        }

        private void ReferenceDataForm_Load_2(object sender, EventArgs e)
        {
            setDataBySelectedPage(0);
        }
    }
}
