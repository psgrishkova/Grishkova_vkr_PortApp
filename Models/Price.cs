using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Models
{
    public class Price
    {
        private long id;
        private string category;
        private long route;
        private double cost;

        public Price(long id, string category, long route, double cost)
        {
            this.id = id;
            this.category = category;
            this.route = route;
            this.cost = cost;
        }

        public long Id { get => id; set => id = value; }
        public string Category { get => category; set => category = value; }
        public long Route { get => route; set => route = value; }
        public double Cost { get => cost; set => cost = value; }
    }
}
