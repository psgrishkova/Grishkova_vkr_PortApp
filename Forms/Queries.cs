using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms
{
    public partial class Queries : Form
    {
        byte b = 0;
        DateTime start;
        DateTime end;
        public Queries()
        {
            InitializeComponent();
            queryComboBox.SelectedItem = queryComboBox.Items[0];
            calendarToolTip.SetToolTip(monthCalendar1, "Для выбора периода, \nнажмите сначала на дату начала периода, \nа затем на дату окончания периода.");
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (b == 0)
            {
                monthCalendar1.RemoveAllBoldedDates();
                b++;
                start = monthCalendar1.SelectionStart.Date;
                monthCalendar1.AddBoldedDate(start);
            }
            else if (b == 1)
            {
                b--;
                end = monthCalendar1.SelectionRange.Start;
                for (int i = 0; i <= (end - start).Days; i++)
                {
                    monthCalendar1.AddBoldedDate(start.AddDays(i));
                }

            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (end > start && monthCalendar1.BoldedDates.Length != 0)
            {
                switch (queryComboBox.SelectedIndex)
                {
                    case 0:
                        dataGridView.DataSource = demoDataSet.GetCountRoutes;
                        this.getCountRoutesTableAdapter.FillCountRoutes(this.demoDataSet.GetCountRoutes, start.Date.ToString(), end.Date.ToString());
                        break;
                    case 1:
                        dataGridView.DataSource = demoDataSet.SumFuel;
                        this.sumFuelTableAdapter.FillSumFuelShip(this.demoDataSet.SumFuel, start.Date.ToString(), end.Date.ToString());
                        break;
                    case 2:
                        dataGridView.DataSource = demoDataSet.INcomeAndExpenses;
                        this.iNcomeAndExpensesTableAdapter.FillINcomeAndExpenses(this.demoDataSet.INcomeAndExpenses, start.Date.ToString(), end.Date.ToString());
                        break;
                    case 3:
                        dataGridView.DataSource = demoDataSet.CountPassByDay;
                        this.countPassByDayTableAdapter.FillCountPassByDay(demoDataSet.CountPassByDay,start.Date.ToString(), end.Date.ToString());
                        break;
                }

            }
            else
            {
                MessageBox.Show("Выберите период. Для выбора нужно сначала нажать на дату, соответствующую началу периода, а зачтем, на дату конца периода.");
            }
        }

        private void Queries_Load(object sender, EventArgs e)
        {

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
    }
}
