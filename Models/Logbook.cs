using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Models
{
    public class Logbook
    {
        private string ship;
        private DateTime date;
        private long id;
        private long cap;
        private long nav;

        public Logbook(string ship, DateTime date, long id, long cap, long nav)
        {
            this.ship = ship;
            this.date = date;
            this.id = id;
            this.cap = cap;
            this.nav = nav;
        }

        public string getShip() { return ship; }
        public DateTime getDate() { return date; }
        public long getId() { return id; }
        public long getCap() { return cap; }
        public long getNav() { return nav; }

        public void setShip(string ship) {  this.ship=ship; }
        public void setDate(DateTime date) { this.date=date; }
        public void setId(long id) { this.id=id; }
        public void setCap(long cap) { this.cap=cap; }
        public void setNav(long nav) { this.nav=nav; }
    }
}
