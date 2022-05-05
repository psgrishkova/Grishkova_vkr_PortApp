using Grishkova_vkr_PortApp.Forms.OperationalData;
using Grishkova_vkr_PortApp.Forms.Reports;
using System;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            operationalDataComboBox.SelectedIndex = 0;
        }

        private void referenceData_button_Click(object sender, EventArgs e)
        {
            new ReferenceDataForm().Show();
            this.Hide();
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            new SetDatesForReport().Show();
            this.Hide();
        }

        private void queries_button_Click(object sender, EventArgs e)
        {
            new Queries().Show();
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Role.authForm.repaint();
            Role.authForm.Show();
        }

        private void operationalDataComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (operationalDataComboBox.SelectedIndex != 0)
            {
                switch (operationalDataComboBox.SelectedIndex)
                {
                    case 1:
                        new FuelAccountingForm().Show();
                        break;
                    case 2:
                        new Vessels().Show();
                        break;
                    case 3:
                        new WorkingDayCaps().Show();
                        break;
                }

                this.Hide();
            }
        }

        public void repaint()
        {
            operationalDataComboBox.SelectedIndex = 0;
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Role.authForm.repaint();
            Role.authForm.Show();
        }
    }
}
