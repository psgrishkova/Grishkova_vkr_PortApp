using Grishkova_vkr_PortApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Controllers.ReferenceData
{
    class CompanyController : CRUDController
    {

        private demoDataSetTableAdapters.КомпанияTableAdapter adapter;
        private demoDataSet.КомпанияDataTable table;

        public CompanyController(System.ComponentModel.Component adapter, System.Data.DataTable table)
        {
            this.adapter = (demoDataSetTableAdapters.КомпанияTableAdapter)adapter;
            this.table = (demoDataSet.КомпанияDataTable)table;
            fill();
        }


        public void add(object[] data)
        {
            if (data.Contains(null))
                throw new IncorrectDataException();
            if (adapter.GetCountOfCompByName((string)data[0]) != 0)
                throw new IncorrectDataException("Компания с таким названием уже существует");
            adapter.Insert((string)data[0], (string)data[1], Convert.ToInt64(data[2]), (string)data[3], (string)data[4]);
            fill();
        }

        public void fill()
        {
            adapter.Fill(table);
        }

        public void remove(object[] data)
        {
            adapter.DeleteQuery((string)data[0], (string)data[1], Convert.ToInt64(data[2]), (string)data[3], (string)data[4]);
            fill();
        }

        public void set(object[] data, object[] original_data)
        {
            if (data.Contains(null))
                throw new IncorrectDataException();
            if (!data[0].ToString().Equals(original_data[0].ToString()) && adapter.GetCountOfCompByName((string)data[0]) != 0)
                throw new IncorrectDataException("Компания с таким названием уже существует");
            adapter.UpdateQuery((string)data[0], (string)data[1], Convert.ToInt64(data[2]), (string)data[3], (string)data[4], 
                            (string)original_data[0], (string)original_data[1], Convert.ToInt64(original_data[2]), (string)original_data[3], (string)original_data[4]);
            fill();
        }
    }
}
