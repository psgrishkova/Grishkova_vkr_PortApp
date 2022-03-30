using System;

namespace Grishkova_vkr_PortApp.Models
{
    public class TicketOffice
    {
        private DateTime date;
        private TimeSpan time;
        private long cap;
        private long cashier;
        private string ship;
        private long route;
        private long vessel;
        private long price;
        private string category;
        private int count;

        public TicketOffice(DateTime date, TimeSpan time, long cap, string ship, long route, long vessel, long price, string category, int count, long cashier)
        {
            this.date = date;
            this.time = time;
            this.cap = cap;
            this.ship = ship;
            this.route = route;
            this.vessel = vessel;
            this.price = price;
            this.category = category;
            this.count = count;
            this.cashier = cashier;
        }

        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Time { get => time; set => time = value; }
        public long Cap { get => cap; set => cap = value; }
        public string Ship { get => ship; set => ship = value; }
        public long Route { get => route; set => route = value; }
        public long Vessel { get => vessel; set => vessel = value; }
        public long Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }
        public int Count { get => count; set => count = value; }
        public long Cashier { get => cashier; set => cashier = value; }
    }
}
