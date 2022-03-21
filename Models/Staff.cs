using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Models
{
    public class Staff
    {

        private string name;
        private decimal tel;
        private DateTime bday;
        private string role;
        private long id;
        private long company;

        public Staff(string name, decimal tel, DateTime bday, string role, long id, long company)
        {
            this.name = name;
            this.tel = tel;
            this.bday = bday;
            this.role = role;
            this.id = id;
            this.company = company;
        }

        public string getName() { return name; }
        public decimal getTel() { return tel; }
        public DateTime getBDay() { return bday; }
        public string getRole() { return role; }
        public long getId() { return id; }

        public void setName(string name) { this.name = name; }
        public void setTel(decimal tel) { this.tel = tel; }
        public void setBDay(DateTime bday) { this.bday = bday; }
        public void setRole(string role) { this.role = role; }
        public void setId(long id) { this.id = id; }
    }
}
