using Grishkova_vkr_PortApp.Controllers;
using Grishkova_vkr_PortApp.Controllers.OperationalData;
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
            if (Role.role.Equals("Директор"))
            {
                add_button.Enabled = false;
                set_button.Enabled = false;
                delete_button.Enabled = false;
            }
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
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Выбранные данные уже используются в формировании рейса. Прежде, удалите данные о рейсе.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void set_button_Click(object sender, EventArgs e)
        {
            if (referenceData_tabControl.SelectedIndex != 7)
            {
                if (grid.SelectedRows.Count == 0)
                    MessageBox.Show("Выберите строку для изменения");
                else
                {
                    openAddSetForm(referenceData_tabControl.SelectedIndex, grid.SelectedRows[0].Cells.Cast<DataGridViewCell>().ToList().Select(x => x.Value).ToArray());
                }
            }
            else MessageBox.Show("Прайс-листы редактировать нельзя.");
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
                case 3:
                    controller = new AccountController(this.аккаунтTableAdapter, this.demoDataSet.Аккаунт);
                    break;
                case 4:
                    controller = new CompanyController(this.компанияTableAdapter, this.demoDataSet.Компания);
                    break;
                case 5:
                    controller = new CategoryController(this.категория_гражданTableAdapter, this.demoDataSet.Категория_граждан);
                    break;
                case 6:
                    controller = new StaffController(this.персоналTableAdapter, this.demoDataSet.Персонал);
                    break;
                case 7:
                    controller = new PriceListController(this.прайс_листTableAdapter, this.demoDataSet.Прайс_лист);
                    break;
            }
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
                    addSetForm = new AddSetAccount(controller, data);
                    break;
                case 4:
                    addSetForm = new AddSetCompanyForm(controller, data);
                    break;
                case 5:
                    addSetForm = new AddSetCategoryForm(controller, data);
                    break;
                case 6:
                    addSetForm = new AddSetStaffForm(controller, data);
                    break;
                case 7:
                    addSetForm = new AddSetPrice(controller, data);
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
            string filter = "[" + getBy_comboBox.SelectedItem.ToString() + "] = '" + getBy_textBox.Text + "'";
            if (!string.IsNullOrEmpty(getBy_textBox.Text))
            {
                switch (referenceData_tabControl.SelectedIndex)
                {
                    case 0:
                        судноBindingSource.Filter = filter;
                        break;
                    case 1:
                        навигацияBindingSource.Filter = filter;
                        break;
                    case 2:
                        маршрутBindingSource.Filter = filter;
                        break;
                    case 3:
                        аккаунтBindingSource.Filter = filter;
                        break;
                    case 4:
                        компанияBindingSource.Filter = filter;
                        break;
                    case 5:
                        категориягражданBindingSource.Filter = filter;
                        break;
                    case 6:
                        персоналBindingSource.Filter = filter;
                        break;
                    case 7:
                        прайслистBindingSource1.Filter = filter;
                        break;
                }
            }
            else MessageBox.Show("Введите данные для поиска");
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            судноBindingSource.RemoveFilter();
            switch (referenceData_tabControl.SelectedIndex)
            {
                case 0:
                    судноBindingSource.RemoveFilter();
                    break;
                case 1:
                    навигацияBindingSource.RemoveFilter();
                    break;
                case 2:
                    маршрутBindingSource.RemoveFilter();
                    break;
                case 3:
                    аккаунтBindingSource.RemoveFilter();
                    break;
                case 4:
                    компанияBindingSource.RemoveFilter();
                    break;
                case 5:
                    категориягражданBindingSource.RemoveFilter();
                    break;
                case 6:
                    персоналBindingSource.RemoveFilter();
                    break;
                case 7:
                    прайслистBindingSource1.RemoveFilter();
                    break;
            }
        }

        private void ReferenceDataForm_Load_2(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoDataSet.Прайс_лист". При необходимости она может быть перемещена или удалена.
            this.прайс_листTableAdapter.Fill(this.demoDataSet.Прайс_лист);
            setDataBySelectedPage(0);
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role.menu.repaint();
            Role.menu.Show();
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Role.authForm.repaint();
            Role.authForm.Show();
        }

        private void ReferenceDataForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Role.menu.repaint();
            Role.menu.Show();
        }
    }
}
