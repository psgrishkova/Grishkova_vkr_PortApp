using Grishkova_vkr_PortApp.Controllers.OperationalData;
using Grishkova_vkr_PortApp.Models;
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
    public partial class WorkingDay : Form
    {
        public WorkingDay()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!WorkingDayController.checkPeriod(навигацияTableAdapter1, dateTimePicker.Value.Date.ToString()))
                MessageBox.Show("Введенная дата не входит ни в один навигационный период. Проверьте правильность введенных данных");
            else
            {
                MessageBox.Show("Кассир сохранен");
            }
        }

        private void WorkingDay_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoDataSet.Кассир". При необходимости она может быть перемещена или удалена.
            this.кассирTableAdapter.Fill(this.demoDataSet.Кассир);

        }
    }
}
