using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.Reports
{
    public partial class SetDatesForReport : Form
    {
        public SetDatesForReport()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < dateTimePicker2.Value.Date)
            {
                ReportClass report = null;
                if (comboBox1.SelectedIndex == 0)
                {
                    report = new CrystalReport1();
                    reportAboutShiftsTableAdapter.Fill(this.demoDataSet.ReportAboutShifts, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    report.SetDataSource((DataTable)demoDataSet.ReportAboutShifts);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    report = new CrystalReport2();
                    reportProfitTableAdapter1.Fill(this.demoDataSet.ReportProfit, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
                    report.SetDataSource((DataTable)demoDataSet.ReportProfit);

                }else if (comboBox1.SelectedIndex == 2)
                {
                    report = new CrystalReport3();
                    staffSalaryTableAdapter1.Fill(this.demoDataSet.StaffSalary, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                    report.SetDataSource((DataTable)demoDataSet.StaffSalary);
                }

                if (report != null)
                {
                    report.SetParameterValue("Period", dateTimePicker1.Value.ToShortDateString() + " - " + dateTimePicker2.Value.ToShortDateString());
                    crystalReportViewer1.ReportSource = report;
                    crystalReportViewer1.Refresh();
                }
            }
            else MessageBox.Show("Дата начала не может быть позже даты конца или совпадать с ней");

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role.menu.repaint();
            Role.menu.Show();
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Role.menu = null;
            this.Close();
            Role.authForm.repaint();
            Role.authForm.Show();
        }

        private void SetDatesForReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Role.menu != null)
            {
                Role.menu.repaint();
                Role.menu.Show();
            }
        }
    }
}
