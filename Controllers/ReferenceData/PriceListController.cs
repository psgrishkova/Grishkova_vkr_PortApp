using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Controllers.OperationalData
{
    public class PriceListController : CRUDController
    {
        private demoDataSetTableAdapters.Прайс_листTableAdapter adapter;
        private demoDataSet.Прайс_листDataTable table;

        public PriceListController(System.ComponentModel.Component adapter, System.Data.DataTable table)
        {
            this.adapter = (demoDataSetTableAdapters.Прайс_листTableAdapter)adapter;
            this.table = (demoDataSet.Прайс_листDataTable)table;
            fill();
        }

        public void add(object[] data)
        {
            DateTime date;
            demoDataSet.Прайс_листDataTable price = adapter.GetDataBy(long.Parse(data[0].ToString()));
            if (price.Rows.Count == 0)
                date = DateTime.Now;
            else date = (DateTime)price.Rows[0].ItemArray[0];
            adapter.Insert(date, long.Parse(data[0].ToString()), long.Parse(data[1].ToString()), data[2].ToString(), data[3].ToString());
            fill();
        }

        public void fill()
        {
            adapter.Fill(table);
        }

        public void remove(object[] data)
        {
            adapter.Delete((DateTime?)data[0], long.Parse(data[1].ToString()), long.Parse(data[2].ToString()), data[3].ToString(), data[4].ToString());
            fill();
        }

        public void set(object[] data, object[] original_data)
        {

        }
        public static object[] getNums(demoDataSet.PrDataTable prDataTable)
        {
            List<object> result = new List<object>();
            foreach (DataRow row in prDataTable.Rows)
            {
                result.Add(row.ItemArray[0]);
            }
            return result.ToArray();
        }
    }
}
