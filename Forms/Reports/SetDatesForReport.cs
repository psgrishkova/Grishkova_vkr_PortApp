using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                
            }

            if (report != null)
            {
                report.SetParameterValue("Period", dateTimePicker1.Value.ToShortDateString() + " - " + dateTimePicker2.Value.ToShortDateString());
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }

        }
    }
}
