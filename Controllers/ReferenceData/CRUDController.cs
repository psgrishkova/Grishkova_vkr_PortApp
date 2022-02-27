using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Controllers
{
    public interface CRUDController
    {
        void add(object[] data);
        void remove(object[] data);
        void set(object[] data, object[] original_data);
        void fill();
    }
}
