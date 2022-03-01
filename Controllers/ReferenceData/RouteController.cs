using Grishkova_vkr_PortApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Controllers.ReferenceData
{
    class RouteController : CRUDController
    {
        private demoDataSetTableAdapters.МаршрутTableAdapter adapter;
        private demoDataSet.МаршрутDataTable table;

        public RouteController(demoDataSetTableAdapters.МаршрутTableAdapter маршрутTableAdapter, demoDataSet.МаршрутDataTable маршрут)
        {
            this.adapter = маршрутTableAdapter;
            this.table = маршрут;
            fill();
        }

        public void add(object[] data)
        {
            if ((string)data[0] == string.Empty  | (string)data[2] == string.Empty | (string)data[3] == string.Empty | (string)data[4] == string.Empty)
                throw new IncorrectDataException();
            if (Convert.ToInt32(adapter.getCountRoutesByName((string)data[0])) != 0)
                throw new IncorrectDataException("Маршрут с таким названием уже существует");
            if (Convert.ToInt32(adapter.getCountRoutesByNum(Convert.ToInt32(data[1]))) != 0)
                throw new IncorrectDataException("Маршрут с таким номером уже существует");
            adapter.Insert((string)data[0], Convert.ToInt32(data[1]), (string)data[2], (string)data[3], (string)data[4]);
            fill();
        }

        public void fill()
        {
            adapter.Fill(table);
        }

        public void remove(object[] data)
        {
            adapter.Delete((string)data[0], Convert.ToInt32(data[1]), (string)data[2], (string)data[3], (string)data[4]);
            fill();
        }

        public void set(object[] data, object[] original_data)
        {
            if ((string)data[0] == string.Empty | (string)data[2] == string.Empty | (string)data[3] == string.Empty | (string)data[4] == string.Empty)
                throw new IncorrectDataException();
            if (!((string)data[0]).Equals((string)original_data[0]) && Convert.ToInt32(adapter.getCountRoutesByName((string)data[0])) != 0)
                throw new IncorrectDataException("Маршрут с таким названием уже существует");
            if (Convert.ToInt32(data[1]) != Convert.ToInt32(original_data[1]) && Convert.ToInt32(adapter.getCountRoutesByNum(Convert.ToInt32(data[1]))) != 0)
                throw new IncorrectDataException("Маршрут с таким номером уже существует");
            adapter.Update((string)data[0], Convert.ToInt32(data[1]), (string)data[2], (string)data[3], (string)data[4],
                            (string)original_data[0], Convert.ToInt32(original_data[1]), (string)original_data[2], (string)original_data[3], (string)original_data[4]);
            fill();
        }
    }
}
