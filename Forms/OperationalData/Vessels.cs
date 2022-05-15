using Grishkova_vkr_PortApp.Controllers.OperationalData;
using System;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp.Forms.OperationalData
{
    public partial class Vessels : Form
    {
        private bool date = false;
        public Vessels()
        {
            InitializeComponent();

            if (Role.role.Equals("Директор"))
            {
                addButton.Enabled = false;
            }

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
                        if (Role.role.Equals("Директор")) MessageBox.Show("В этот день не было ни одного рейса. Выберите другую дату.");
                        else
                        {
                            MessageBox.Show("В этот день еще не было ни одного рейса. Добавьте новый рейс.");
                            addButton_Click(sender, e);
                        }
                    }
                    else if (!Role.role.Equals("Директор"))
                    {
                        MessageBox.Show("Дата валидная. Доступен просмотр и редактирование.");
                    }
                }
                else if (!Role.role.Equals("Директор")) MessageBox.Show("Для добавления рейсов в заданный день необходимо создать смену.");
                else MessageBox.Show("В этот день не было ни одного рейса. Выберите другую дату.");
            }
            else
            {
                try { vesselsDataGridView.Rows.Clear(); } catch (System.ArgumentException) { }
                
                if (!Role.role.Equals("Директор")) MessageBox.Show("Доступно добавление только прошедших рейсов.");
                else MessageBox.Show("Дата некорректная. Попробуйте выбрать другую дату.");
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Cash cash = new Cash(dateTimePicker.Value, vesselsDataGridView.Rows.Count != 0);
            cash.Show();
            cash.FormClosed += (obj, args) =>
            {
                this.Enabled = true;
                cash = null;
                CashController.fill(this.vesselsTableAdapter, this.demoDataSet1.Vessels, dateTimePicker.Value.Date.ToString());
            };
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

        private void Vessels_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Role.menu != null)
            {
                Role.menu.repaint();
                Role.menu.Show();
            }
        }
    }
}
