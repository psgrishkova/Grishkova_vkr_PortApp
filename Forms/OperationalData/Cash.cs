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
            this.date = date;
            this.b = b;
        }

        private void setCash()
        {
            if (b)
            {
                string[] cash = CashController.getCash(this.кассаTableAdapter1, date.Date.ToString());
                cashierComboBox.Items.Add(cash[0]);
                cashierComboBox.SelectedItem = cash[0];
                priceComboBox.Items.Add(cash[1]);
                priceComboBox.SelectedItem = cash[1];
            }
            else
            {
                cashiers = WorkingDayController.GetStaff(персоналTableAdapter1.GetCashiers());
                foreach (Staff cashier in cashiers)
                    cashierComboBox.Items.Add(cashier.getName());
                if (cashierComboBox.Items.Count != 0)
                    cashierComboBox.SelectedItem = cashierComboBox.Items[0];

                priceList = CashController.getPriceList(прайс_листTableAdapter1);
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
            foreach (Ship ship in ships)
                shipsComboBox.Items.Add(ship.getName());
            if (shipsComboBox.Items.Count != 0)
                shipsComboBox.SelectedItem = shipsComboBox.Items[0];

            routes = CashController.getRoutes(маршрутTableAdapter1);
            foreach (Route route in routes)
                routeComboBox.Items.Add(route.Name);
            if (routeComboBox.Items.Count != 0)
                routeComboBox.SelectedItem = routeComboBox.Items[0];
        }

        private void setGrid()
        {
            passDataGridView.Rows.Clear();
            foreach (Price item in priceList)
            {
                if(item.Route == routes.Find(x=>x.Name.Equals(routeComboBox.SelectedItem.ToString())).Id)
                    passDataGridView.Rows.Add(item.Category, 0);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Ship ship = ships.Find(x => x.getName().Equals(shipsComboBox.SelectedItem.ToString()));
            long cap = long.Parse(вахтенный_журналTableAdapter1.GetDataByDateShip(date.Date.ToString(), ship.getNum()).Rows[0].ItemArray[3].ToString());

            long cashier = cashiers.Find(x => x.getName().Equals(cashierComboBox.SelectedItem.ToString())).getId();
            Vessel v = new Vessel(date, TimeSpan.Parse(timePicker.Value.TimeOfDay.ToString()), long.Parse(рейсTableAdapter1.GetCountVesselsByDay(date.Date.ToString()).ToString()) + 1,
                cap, ship.getNum(), routes.Find(x => x.Name.Equals(routeComboBox.SelectedItem.ToString())).Id, getProfit());

            List<TicketOffice> tickets = new List<TicketOffice>();
            foreach (DataGridViewRow row in passDataGridView.Rows)
            {
                if (priceList.Find(x => x.Category.Equals(row.Cells[0].Value.ToString())) != null)
                    tickets.Add(new TicketOffice(v.Date, v.Time, v.Cap, v.Ship, v.Route, v.Id, long.Parse(priceComboBox.SelectedItem.ToString()),
                        row.Cells[0].Value.ToString(), int.Parse(row.Cells[1].Value.ToString()), cashier));
            }

            MessageBox.Show(getProfit().ToString());
            CashController.add(рейсTableAdapter1, this.demoDataSet1.Рейс, demoDataSet1.Касса, кассаTableAdapter1, v, tickets);
        }

        private decimal getProfit()
        {
            decimal res = 0;
            List<Price> currentPrice = priceList.FindAll(x=>x.Id==long.Parse(priceComboBox.SelectedItem.ToString()));

            if (passDataGridView.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in passDataGridView.Rows)
                {
                    double cost=0;
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
            
            setGrid();
        }
    }
}

