using Grishkova_vkr_PortApp.Controllers.OperationalData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    public partial class Vessels : Form
    {
        private bool date = false;
        public Vessels()
        {
            InitializeComponent();

        }

        private void Vessels_Load(object sender, EventArgs e) { }

        private void setDateButton_Click(object sender, EventArgs e)
        {
            if (dateTimePicker.Value.Date <= DateTime.Today.Date)
            {
                if (CashController.isWorkingDay(dateTimePicker.Value.ToString(), вахтенный_журналTableAdapter1))
                {
                    date = true;
                    CashController.fill(this.vesselsTableAdapter, this.demoDataSet1.Vessels, dateTimePicker.Value.Date.ToString());
                    if (vesselsDataGridView.Rows.Count == 0)
                    {
                        MessageBox.Show("В этот день еще не было ни одного рейса. Добавьте новый рейс");
                        addButton_Click(sender, e);
                    }else
                    {
                        MessageBox.Show("Дата валидная. Доступен просмотр и редактирование.");
                    }
                }
                else MessageBox.Show("Для добавления рейсов в заданный день необходимо заполнить вахтенных журнал");
            }
            else MessageBox.Show("Доступно добавление только прошедших рейсов");
        }

        }


    }
}
