using Grishkova_vkr_PortApp.demoDataSetTableAdapters;
using Grishkova_vkr_PortApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Controllers.OperationalData
{
    public class FuelController
    {
        public static List<DateTime> getDates(Вахтенный_журналTableAdapter adapter)
        {
            demoDataSet.Вахтенный_журналDataTable table = adapter.GetDates();
            List<DateTime> res = new List<DateTime>();
            foreach (DataRow row in table)
            {
                res.Add(Convert.ToDateTime(row.ItemArray[1].ToString()));
            }
            return res;
        }

        public static List<Logbook> getLogbook(demoDataSet.Вахтенный_журналDataTable table)
        {
            List<Logbook> result = new List<Logbook>();
            foreach (DataRow row in table.Rows)
            {
                result.Add(new Logbook(row.ItemArray[0].ToString(), Convert.ToDateTime(row.ItemArray[1].ToString()), Convert.ToInt64(row.ItemArray[2]),
                     Convert.ToInt64(row.ItemArray[3]), Convert.ToInt64(row.ItemArray[4])));
            }
            return result;
        }

        public static void giveFuel(Учет_топливаTableAdapter adapter, demoDataSet.Учет_топливаDataTable table, FuelAccounting fuel)
        {
            adapter.Insert(fuel.Volume,fuel.Sum,fuel.Driver,fuel.Cap,fuel.Ship,fuel.Date);
            adapter.Fill(table);
        }

        public static void deleteFuel(Учет_топливаTableAdapter adapter, demoDataSet.Учет_топливаDataTable table, long cap, string date)
        {
            adapter.DeleteQuery(cap,date);
            adapter.Fill(table);
        }
    }
}
