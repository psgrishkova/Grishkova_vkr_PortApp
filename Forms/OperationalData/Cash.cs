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
    public partial class Cash : Form
    {
        private DateTime date;
        private bool b;
        private List<Staff> cashiers;
        private List<Price> priceList;
        private List<Ship> ships;
        private List<Route> routes;

        public Cash(DateTime date, bool b)
        {
            InitializeComponent();
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.CustomFormat = "HH:mm";
            this.date = date;
            this.b = b;
        }

        private void setCash()
        {
            cashiers = WorkingDayController.GetStaff(персоналTableAdapter1.GetCashiers());
            priceList = CashController.getPriceList(прайс_листTableAdapter1);

            if (b)
            {
                string[] cash = CashController.getCash(this.кассаTableAdapter1, date.Date.ToString());
                cashierComboBox.Items.Add(cashiers.Find(x => x.getId() == long.Parse(cash[1])).getName());
                cashierComboBox.SelectedItem = cashierComboBox.Items[0];
                priceComboBox.Items.Add(cash[0]);
                priceComboBox.SelectedItem = cash[0];
            }
            else
            {
                
                cashierComboBox.Items.AddRange(cashiers.Select(x => x.getName()).ToArray());
                if (cashierComboBox.Items.Count != 0)
                    cashierComboBox.SelectedItem = cashierComboBox.Items[0];

                
                foreach (Price price in priceList)
                {
                    if (!priceComboBox.Items.Contains(price.Id))
                        priceComboBox.Items.Add(price.Id);
                }
                if (priceComboBox.Items.Count != 0)
                    priceComboBox.SelectedItem = priceComboBox.Items[0];
            }
        }
        private void setVessel()
        {
            ships = WorkingDayController.GetShips(судноTableAdapter1.GetShipsByLogbook(date.Date.ToString()));
            shipsComboBox.Items.AddRange(ships.Select(x => x.getName()).ToArray());
            if (shipsComboBox.Items.Count != 0)
                shipsComboBox.SelectedItem = shipsComboBox.Items[0];

            routes = CashController.getRoutes(маршрутTableAdapter1);
            routeComboBox.Items.AddRange(routes.Select(x => x.Name).ToArray());
            if (routeComboBox.Items.Count != 0)
                routeComboBox.SelectedItem = routeComboBox.Items[0];
        }

        private void setGrid()
        {
            if (routeComboBox.SelectedItem != null && priceList != null)
            {
                passDataGridView.Rows.Clear();
                foreach (Price item in priceList)
                {
                    if (item.Route == routes.Find(x => x.Name.Equals(routeComboBox.SelectedItem.ToString())).Id)
                        if (item.Id == long.Parse(priceComboBox.SelectedItem.ToString()))
                            passDataGridView.Rows.Add(item.Category, 0);
                }
                if (passDataGridView.Rows.Count == 0) MessageBox.Show("Для данного маршрута не заполнен выбранный прайс-лист. Заполните прайс-лист или выберите другой.");
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Ship ship = ships.Find(x => x.getName().Equals(shipsComboBox.SelectedItem.ToString()));
            long cap = long.Parse(вахтенный_журналTableAdapter1.GetDataByDateShip(date.Date.ToString(), ship.getNum()).Rows[0].ItemArray[3].ToString());

            long cashier = cashiers.Find(x => x.getName().Equals(cashierComboBox.SelectedItem.ToString())).getId();
            Vessel v = new Vessel(date, TimeSpan.Parse(timePicker.Value.ToShortTimeString()), long.Parse(рейсTableAdapter1.GetCountVesselsByDay(date.Date.ToString()).ToString()) + 1,
                cap, ship.getNum(), routes.Find(x => x.Name.Equals(routeComboBox.SelectedItem.ToString())).Id, getProfit());

            List<TicketOffice> tickets = new List<TicketOffice>();
            foreach (DataGridViewRow row in passDataGridView.Rows)
            {
                if (priceList.Find(x => x.Category.Equals(row.Cells[0].Value.ToString())) != null)
                    tickets.Add(new TicketOffice(v.Date, v.Time, v.Cap, v.Ship, v.Route, v.Id, long.Parse(priceComboBox.SelectedItem.ToString()),
                        row.Cells[0].Value.ToString(), int.Parse(row.Cells[1].Value.ToString()), cashier));
            }

            try
            {
                CashController.add(рейсTableAdapter1, this.demoDataSet1.Рейс, demoDataSet1.Касса, кассаTableAdapter1, v, tickets);
                MessageBox.Show("Рейс сохранен");
            }
            catch (System.Data.SqlClient.SqlException) { MessageBox.Show("Выбранное судно уже совершает рейс в этой время"); }
        }

        private decimal getProfit()
        {
            decimal res = 0;
            List<Price> currentPrice = priceList.FindAll(x => x.Id == long.Parse(priceComboBox.SelectedItem.ToString()));

            if (passDataGridView.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in passDataGridView.Rows)
                {
                    double cost = 0;
                    Price p = currentPrice.Find(x => x.Category.Equals(row.Cells[0].Value.ToString()));
                    if (p != null) cost = p.Cost;
                    int count = int.Parse(row.Cells[1].Value.ToString());
                    res += decimal.Parse((cost * count).ToString());
                }
            }
            return res;
        }

        private void priceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setGrid();
        }

        private void Cash_Load(object sender, EventArgs e)
        {
            cashGroupBox.Enabled = !b;
            setVessel();
            setCash();
        }

        private void routeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setGrid();
        }
    }
}

