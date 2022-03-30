using Grishkova_vkr_PortApp.Controllers.OperationalData;
using Grishkova_vkr_PortApp.Forms.addSetForms;
using Grishkova_vkr_PortApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    public partial class WorkingDayCaps : Form
    {
        private List<Staff> caps;
        private List<Ship> ships;

        public WorkingDayCaps()
        {
            InitializeComponent();
            dataGroupBox.Enabled = false;
        }

        private void checkDate_button_Click(object sender, EventArgs e)
        {
            if (!WorkingDayController.checkPeriod(навигацияTableAdapter1, dateTimePicker.Value.Date.ToString()))
            {
                MessageBox.Show("Введенная дата не входит ни в один навигационный период. Проверьте правильность введенных данных");
                dataGroupBox.Enabled = false;
            }
            else
            {
                if (dateTimePicker.Value >= DateTime.Now)
                {

                    dataGroupBox.Enabled = true;
                    setCapsShips();
                    fill();
                    removeCapShip();
                    if (WorkingDayController.GetLogbookByDate(вахтенный_журналTableAdapter1, dateTimePicker.Value.Date.ToString()) > 0)
                    {
                        MessageBox.Show("Смена существует. Доступно редактирование");
                    }
                    else
                    {

                    }
                }
                else if (WorkingDayController.GetLogbookByDate(вахтенный_журналTableAdapter1, dateTimePicker.Value.Date.ToString()) > 0)
                    MessageBox.Show("Заданная смена уже прошла, редактирование недоступно");
                else MessageBox.Show("Указанный день уже прошел, смену составить нельзя");

            }
        }

        private void setCapsShips()
        {
            nameComboBox.Items.Clear();
            vesselComboBox.Items.Clear();

            caps = WorkingDayController.GetStaff(персоналTableAdapter1.GetCaps());
            foreach (Staff cap in caps)
                nameComboBox.Items.Add(cap.getName());
            if (nameComboBox.Items.Count != 0)
                nameComboBox.SelectedItem = nameComboBox.Items[0];

            ships = WorkingDayController.GetShips(судноTableAdapter1.GetData());
            foreach (Ship ship in ships)
                vesselComboBox.Items.Add(ship.getName());
            if (vesselComboBox.Items.Count != 0)
                vesselComboBox.SelectedItem = vesselComboBox.Items[0];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NavPeriod nav = WorkingDayController.getNavPeriod(навигацияTableAdapter1, dateTimePicker.Value.Date.ToString());
            if (nav != null)
            {
                string ship = ships.Find(x => x.getName().Equals(vesselComboBox.SelectedItem.ToString())).getNum();
                DateTime date = dateTimePicker.Value;
                long capId = caps.Find(x => x.getName().Equals(nameComboBox.SelectedItem.ToString())).getId();
                WorkingDayController.addLogbook(вахтенный_журналTableAdapter1, this.demoDataSet.Вахтенный_журнал, навигацияTableAdapter1, ship, date, capId);
                fill();
                removeCapShip();
            }
        }

        private void fill()
        {
            this.dataTable1TableAdapter.FillBy(this.demoDataSet1.DataTable1, dateTimePicker.Value.Date.ToString());
        }

        private void removeCapShip()
        {
            int idx = LogbookGridView.Columns["ФИО_сотрудника"].Index;
            foreach (DataGridViewRow r in LogbookGridView.Rows)
                nameComboBox.Items.Remove(r.Cells[idx].Value.ToString());

            if (nameComboBox.Items.Count == 0)
            {
                MessageBox.Show("Смена заполнена.");
            }
            else
            {
                nameComboBox.SelectedItem = nameComboBox.Items[0];
            }
            idx = LogbookGridView.Columns["Название_судна"].Index;
            foreach (DataGridViewRow r in LogbookGridView.Rows)
                vesselComboBox.Items.Remove(r.Cells[idx].Value.ToString());

            if (vesselComboBox.Items.Count != 0) vesselComboBox.SelectedItem = vesselComboBox.Items[0];
            else MessageBox.Show("Смена заполнена.");
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (LogbookGridView.SelectedRows.Count != 0)
            {
                UpdateLogbook update = new UpdateLogbook(caps.Find(x => x.getName().Equals(LogbookGridView.SelectedRows[0].Cells["ФИО_сотрудника"].Value.ToString())),
                    ships.Find(x => x.getName().Equals(LogbookGridView.SelectedRows[0].Cells["Название_судна"].Value.ToString())),
                     nameComboBox.Items, vesselComboBox.Items, вахтенный_журналTableAdapter1, this.demoDataSet.Вахтенный_журнал,
                   Convert.ToInt64(вахтенный_журналTableAdapter1.GetLogbookByDate(dateTimePicker.Value.Date.ToString()).Rows[0].ItemArray[2]), caps, ships);
                update.Show();
                this.Enabled = false;
                update.FormClosed += (obj, args) =>
                {
                    this.Enabled = true;
                    update = null;
                    checkDate_button_Click(sender, e);
                };
            }
            else MessageBox.Show("Выберите строку для изменения");
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (LogbookGridView.SelectedRows.Count != 0)
            {
                WorkingDayController.delete(вахтенный_журналTableAdapter1, this.demoDataSet.Вахтенный_журнал, Convert.ToInt64(LogbookGridView.SelectedRows[0].Cells[4].Value));
                checkDate_button_Click(sender, e);
            }
            else MessageBox.Show("Выберите строку для удаления");
        }
    }
}
