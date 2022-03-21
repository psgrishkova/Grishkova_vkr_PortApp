using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Models
{
    public class Ship
    {
        private string num;
        private DateTime to;
        private string name;
        private string type;
        private int capacity;
        private long company;

        public Ship(string num, DateTime to, string name, string type, int capacity, long company)
        {
            this.num = num;
            this.to = to;
            this.name = name;
            this.type = type;
            this.capacity = capacity;
            this.company = company;
        }

        public string getNum() { return num; }
        public DateTime getTo() { return to; }
        public string getName() { return name; }
        public string getType() { return type; }
        public int getCapacity() { return capacity; }
        public long getCompany() { return company; }

        public void setNum(string num) { this.num = num; }
        public void setTo(DateTime to) { this.to=to; }
        public void setName(string name) { this.name=name; }
        public void setType(string type) { this.type=type; }
        public void setCapacity(int capacity) { this.capacity=capacity; }
        public void setCompany(long company) { this.company=company; }
    }
}
