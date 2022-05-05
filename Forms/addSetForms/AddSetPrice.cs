using Grishkova_vkr_PortApp.Controllers;
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

namespace Grishkova_vkr_PortApp.Forms.addSetForms
{
    public partial class AddSetPrice : Form
    {

        private List<Route> routes;
        private List<String> categories;
        private List<Price> prices;

        private PriceListController controller;
        private bool action = true; //true - добавление, false - изменение
        private object[] data;
        public AddSetPrice(CRUDController controller, object[] data)
        {
            InitializeComponent();
            setData();
            this.controller = (PriceListController)controller;
            this.data = data;
        }

        private void setData()
        {
            routes = CashController.getRoutes(маршрутTableAdapter1);
            routeComboBox.Items.AddRange(routes.Select(x => x.Id.ToString()).ToArray());
            if (routeComboBox.Items.Count != 0)
                routeComboBox.SelectedItem = routeComboBox.Items[0];

            categories = CashController.getCategories(категория_гражданTableAdapter1);
            categoryComboBox.Items.AddRange(categories.ToArray());
            if (categoryComboBox.Items.Count != 0)
                categoryComboBox.SelectedItem = categoryComboBox.Items[0];

            prices = CashController.getPriceList(прайс_листTableAdapter1);
            priceNumComboBox.Items.AddRange(prices.Select(x => x.Id.ToString()).Distinct().ToArray());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Price price = new Price(long.Parse(priceNumComboBox.Text), categoryComboBox.SelectedItem.ToString(), long.Parse(routeComboBox.SelectedItem.ToString()), double.Parse(costTextBox.Text));

                controller.add(new object[] { price.Id, price.Route, price.Cost, price.Category });

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Введены повторяющиеся данные. Попробуйте еще раз.");
                if (!action)
                    setData();
            }
        }
    }
}
