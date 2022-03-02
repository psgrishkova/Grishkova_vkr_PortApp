using Grishkova_vkr_PortApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Controllers.ReferenceData
{
    class CategoryController : CRUDController
    {
        private demoDataSetTableAdapters.Категория_гражданTableAdapter adapter;
        private demoDataSet.Категория_гражданDataTable table;

        public CategoryController(System.ComponentModel.Component adapter, System.Data.DataTable table)
        {
            this.adapter = (demoDataSetTableAdapters.Категория_гражданTableAdapter)adapter;
            this.table = (demoDataSet.Категория_гражданDataTable)table;
            fill();
        }

        public void add(object[] data)
        {
            if (adapter.GetCountOfCatByName(data[0].ToString()) != 0)
                throw new IncorrectDataException("Категория с таким наименованием уже существует");
            adapter.Insert((string)data[0]);
            fill();
        }

        public void fill()
        {
            adapter.Fill(table);
        }

        public void remove(object[] data)
        {
            adapter.Delete((string)data[0]);
            fill();
        }

        public void set(object[] data, object[] original_data)
        {
            if (!data[0].ToString().Equals(original_data[0].ToString()) && adapter.GetCountOfCatByName((string)data[0]) != 0)
                throw new IncorrectDataException("Категория с таким наименованием уже существует");
            adapter.Update((string)data[0], (string)original_data[0]);
            fill();
        }
    }
}
