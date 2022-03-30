using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Models
{
    public class Route
    {
        private long id;
        private string name;
        private string start;
        private string end;
        private string description;

        public Route(long id, string name, string start, string end, string description)
        {
            this.id = id;
            this.name = name;
            this.start = start;
            this.end = end;
            this.description = description;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Start { get => start; set => start = value; }
        public string End { get => end; set => end = value; }
        public string Description { get => description; set => description = value; }
    }
}
