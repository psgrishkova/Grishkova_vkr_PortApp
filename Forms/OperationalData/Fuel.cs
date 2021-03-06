using Grishkova_vkr_PortApp.Controllers.OperationalData;
using Grishkova_vkr_PortApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    public partial class Fuel : Form
    {
        private DateTime date;
        private FuelAccountingForm fuelAccountingForm;
        private List<Staff> drivers;
        private List<Staff> caps;
        private List<Logbook> logbook;
        private double cost;
        private double remains;
        public Fuel(DateTime date, FuelAccountingForm fuelAccountingForm)
        {
            InitializeComponent();
            this.date = date;
            this.fuelAccountingForm = fuelAccountingForm;

            setData();

            dataTable2TableAdapter.FillFuelByDay(this.demoDataSet.DataTable2, date.Date.ToString());

            if (Role.role.Equals("Директор"))
            {
                FuelGroupBox.Enabled = false;
            }
        }

        private void setData()
        {
            dateLabel.Text += date.ToShortDateString();

            logbook = FuelController.getLogbook(вахтенный_журналTableAdapter1.GetByDate(date.Date.ToString()));

            drivers = WorkingDayController.GetStaff(персоналTableAdapter1.GetDrivers());
            foreach (Staff driver in drivers)
                driversComboBox.Items.Add(driver.getName());
            if (driversComboBox.Items.Count != 0)
                driversComboBox.SelectedItem = driversComboBox.Items[0];


            caps = WorkingDayController.GetStaff(персоналTableAdapter1.GetCaps());
            caps.RemoveAll(x => logbook.Any(y => x.getId() == y.getCap()) == false);
            foreach (Staff cap in caps)
                capsComboBox.Items.Add(cap.getName());
            if (capsComboBox.Items.Count != 0)
                capsComboBox.SelectedItem = capsComboBox.Items[0];

        }

        private void saveReceiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                cost = double.Parse(receiptSumTextBox.Text) / double.Parse(receiptVolumeTextBox.Text);
                remains = double.Parse(receiptVolumeTextBox.Text);

                receiptGroupBox.Enabled = false;

                givedVolumetextBox.Text = (double.Parse(receiptVolumeTextBox.Text) - remains).ToString();
                remainsVolumeTextBox.Text = remains.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void giveFuelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((remains - double.Parse(VolumeTextBox.Text)) < 0) MessageBox.Show("Такое количество топлива недоступно. Проверьте данные");
                else
                {
                    remains -= double.Parse(VolumeTextBox.Text);
                    Staff cap = caps.Find(x => x.getName().Equals(capsComboBox.SelectedItem.ToString())); //после удаления список не пополнился
                    FuelController.giveFuel(учет_топливаTableAdapter, this.demoDataSet.Учет_топлива, new FuelAccounting(double.Parse(VolumeTextBox.Text), decimal.Parse((cost * double.Parse(VolumeTextBox.Text)).ToString()),
                        drivers.Find(x => x.getName().Equals(driversComboBox.SelectedItem.ToString())).getId(),
                        cap.getId(), logbook.Find(x => x.getCap() == cap.getId()).getShip(), date));

                    capsComboBox.Items.Remove(capsComboBox.SelectedItem);
                    if (capsComboBox.Items.Count != 0)
                        capsComboBox.SelectedItem = capsComboBox.Items[0];
                    dataTable2TableAdapter.FillFuelByDay(this.demoDataSet.DataTable2, date.Date.ToString());

                    givedVolumetextBox.Text = (double.Parse(receiptVolumeTextBox.Text) - remains).ToString();
                    remainsVolumeTextBox.Text = remains.ToString();


                    if (remains == 0 && capsComboBox.Items.Count != 0) MessageBox.Show("Топливо закончилось, но не все капитаны получили топливо на смену. Проверьте данные.");
                    if (capsComboBox.Items.Count == 0 && remains != 0) MessageBox.Show("Все капитаны получили топливо, но оно израсходовано не до конца. Возможна недосдача или неверно введены данные");
                    if (capsComboBox.Items.Count == 0 && remains == 0) MessageBox.Show("Топливо успешно выдно");

                    VolumeTextBox.Text = String.Empty;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException)
            {
                MessageBox.Show("Указанному капитану уже выдано топливо на смену.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                FuelController.deleteFuel(учет_топливаTableAdapter, this.demoDataSet.Учет_топлива,
                    caps.Find(x => x.getName().Equals(fuelDataGridView.SelectedRows[0].Cells[0].Value.ToString())).getId(),
                    date.Date.ToString());


                remains += double.Parse(fuelDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                capsComboBox.Items.Add(fuelDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                if (capsComboBox.Items.Count != 0)
                    capsComboBox.SelectedItem = capsComboBox.Items[0];
                dataTable2TableAdapter.FillFuelByDay(this.demoDataSet.DataTable2, date.Date.ToString());

                givedVolumetextBox.Text = (double.Parse(receiptVolumeTextBox.Text) - remains).ToString();
                remainsVolumeTextBox.Text = remains.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }

        private void Fuel_Load(object sender, EventArgs e)
        {
            if (fuelDataGridView.Rows.Count != 0)
            {
                MessageBox.Show("В этот день учет топлива проведен. Достпен только просмотр данных.");
                FuelGroupBox.Enabled = false;
            }
            else if (Role.role.Equals("Директор"))
            {
                MessageBox.Show("Учет топлива в этот день не проведен.");
                button2_Click(sender, e);
            }

        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fuelAccountingForm.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите закончить выдачу? После выхода нельзя будет внести изменения.",
                "Информация",
                MessageBoxButtons.YesNo
                );
            if (result == DialogResult.Yes)
            {
                this.Close();
                fuelAccountingForm.Show();
            }
        }

        private void Fuel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Role.menu != null)
            {
                Role.menu.repaint();
                Role.menu.Show();
            }
        }
    }
}
