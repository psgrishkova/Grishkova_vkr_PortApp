using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Models
{
    public class NavPeriod
    {
        private long id;
        private DateTime start;
        private DateTime end;

        public NavPeriod(long id, DateTime start, DateTime end)
        {
            this.id = id;
            this.start = start;
            this.end = end;
        }

        public long getId() { return id; }
        public DateTime getStart() { return start; }
        public DateTime getEnd() { return end; }

        public void setId(long id) { this.id = id; }
        public void setStart(DateTime start) { this.start = start; }
        public void setEnd(DateTime end) { this.end = end; }
    }
}
