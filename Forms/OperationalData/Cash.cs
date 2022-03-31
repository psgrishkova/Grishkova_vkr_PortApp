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
        }
    }
}
