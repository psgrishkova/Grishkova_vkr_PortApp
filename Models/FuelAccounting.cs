using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Models
{
    public class FuelAccounting
    {
        private double volume;
        private decimal sum;
        private long driver;
        private long cap;
        private string ship;
        private DateTime date;

        public FuelAccounting(double volume, decimal sum, long driver, long cap, string ship, DateTime date)
        {
            this.volume = volume;
            this.sum = sum;
            this.driver = driver;
            this.cap = cap;
            this.ship = ship;
            this.date = date;
        }

        public double Volume { get => volume; set => volume = value; }
        public decimal Sum { get => sum; set => sum = value; }
        public long Driver { get => driver; set => driver = value; }
        public long Cap { get => cap; set => cap = value; }
        public string Ship { get => ship; set => ship = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
