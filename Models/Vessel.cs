using System;

namespace Grishkova_vkr_PortApp.Models
{
    public class Vessel
    {
        private DateTime date;
        private TimeSpan time;
        private long id;
        private long cap;
        private string ship;
        private long route;
        private decimal profit;

        public Vessel(DateTime date, TimeSpan time, long id, long cap, string ship, long route, decimal profit)
        {
            this.date = date;
            this.time = time;
            this.id = id;
            this.cap = cap;
            this.ship = ship;
            this.route = route;
            this.profit = profit;
        }

        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public long Id { get => id; set => id = value; }
        public long Cap { get => cap; set => cap = value; }
        public string Ship { get => ship; set => ship = value; }
        public long Route { get => route; set => route = value; }
        public decimal Profit { get => profit; set => profit = value; }
    }
}
