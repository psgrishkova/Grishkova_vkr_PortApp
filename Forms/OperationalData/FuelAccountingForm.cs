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
    public partial class FuelAccountingForm : Form
    {
        
        public FuelAccountingForm()
        {
            InitializeComponent();
            foreach(DateTime date in FuelController.getDates(this.вахтенный_журналTableAdapter1))
            {
                monthCalendar.AddBoldedDate(date);
            }

        }

        private void FuelAccountingForm_Load(object sender, EventArgs e)
        {
            

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            date_label.Text = monthCalendar.SelectionStart.Date.ToLongDateString()+monthCalendar.BoldedDates.Contains(monthCalendar.SelectionStart.Date);
            if (!monthCalendar.BoldedDates.Contains(monthCalendar.SelectionStart.Date)) MessageBox.Show("В этот день нет смены. Жирным выделены даты, в которые есть смена");
            else
            {
                Fuel f = new Fuel(monthCalendar.SelectionStart.Date, this);
                this.Hide();
                f.Show();
            }
        }
    }
}
