using Grishkova_vkr_PortApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Controllers.OperationalData
{
    public class CashController
    {
        public static bool isWorkingDay(string date, demoDataSetTableAdapters.Вахтенный_журналTableAdapter adapter)
        {
            return adapter.GetLogbookByDay(date) != 0;
        }

        public static void fill(demoDataSetTableAdapters.VesselsTableAdapter adapter, demoDataSet.VesselsDataTable table, string date)
        {
            adapter.FillVessels(table, date);
        }

        public static string[] getCash(demoDataSetTableAdapters.КассаTableAdapter adapter, string date)
        {
            string[] cash = new string[2];
            demoDataSet.КассаDataTable table = adapter.GetDataBy(date);
            if (table.Rows.Count != 0)
            {
                cash[0] = table.Rows[0].ItemArray[0].ToString();
                cash[1] = table.Rows[0].ItemArray[1].ToString();
            }
            return cash;
        }

        public static List<Price> getPriceList(demoDataSetTableAdapters.Прайс_листTableAdapter adapter)
        {
            List<Price> result = new List<Price>();
            demoDataSet.Прайс_листDataTable table = adapter.GetData();
            foreach (DataRow row in table.Rows)
            {
                result.Add(new Price(long.Parse(row.ItemArray[1].ToString()),
                    row.ItemArray[4].ToString(), long.Parse(row.ItemArray[2].ToString()), double.Parse(row.ItemArray[3].ToString())));
            }
            return result;
        }

        public static List<Route> getRoutes(demoDataSetTableAdapters.МаршрутTableAdapter adapter)
        {
            List<Route> result = new List<Route>();
            demoDataSet.МаршрутDataTable table = adapter.GetData();
            foreach (DataRow row in table.Rows)
            {
                result.Add(new Route(long.Parse(row.ItemArray[1].ToString()), row.ItemArray[0].ToString(), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), row.ItemArray[4].ToString()));
            }
            return result;
        }

        public static List<string> getCategories(demoDataSetTableAdapters.Категория_гражданTableAdapter adapter)
        {
            List<string> result = new List<string>();
            demoDataSet.Категория_гражданDataTable table = adapter.GetData();
            foreach (DataRow row in table.Rows)
            {
                result.Add(row.ItemArray[0].ToString());
            }
            return result;
        }

        public static void add(demoDataSetTableAdapters.РейсTableAdapter vesselAdapter, demoDataSet.РейсDataTable vesselTable, 
            demoDataSet.КассаDataTable cashTable, demoDataSetTableAdapters.КассаTableAdapter cashAdapter, 
            Vessel v, List<TicketOffice> tickets)
        {
            vesselAdapter.Insert(v.Time, v.Id, v.Route, v.Profit, v.Cap, v.Ship, v.Date);
            foreach (TicketOffice t in tickets)
            {
                cashAdapter.Insert(t.Vessel, t.Price, t.Count, t.Cashier, t.Category, t.Time, t.Cap, t.Ship, t.Date, t.Route);
            }

            vesselAdapter.Fill(vesselTable);
            cashAdapter.Fill(cashTable);
        }
    }
}
