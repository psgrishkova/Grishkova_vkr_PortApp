using Grishkova_vkr_PortApp.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Controllers.ReferenceData
{
    class AccountController : CRUDController
    {

        private demoDataSetTableAdapters.АккаунтTableAdapter adapter;
        private demoDataSet.АккаунтDataTable table;

        public AccountController(System.ComponentModel.Component adapter, System.Data.DataTable table)
        {
            this.adapter = (demoDataSetTableAdapters.АккаунтTableAdapter)adapter;
            this.table = (demoDataSet.АккаунтDataTable)table;
            fill();
        }
        public void add(object[] data)
        {
            if (((string)data[0]).Equals("") | ((string)data[1]).Equals(""))
                throw new IncorrectDataException();
            if (adapter.GetCountAccByRole((string)data[2]) != 0)
                throw new IncorrectDataException("В системе предусмотрена только одна учетная запись с данной ролью");
            if (adapter.GetCountAccByLogin((string)data[0]) != 0)
                throw new IncorrectDataException("Учетная запись с таким логином уже существует");
            adapter.Insert((string)data[0], (string)data[1], (string)data[2]);
            fill();
        }

        public void fill()
        {
            adapter.Fill(table);
        }

        public void remove(object[] data)
        {
            if (((string)data[2]).Equals("Менеджер"))
                throw new IncorrectDataException("Нельзя удалить учетную запись менеджера");
            adapter.Delete((string)data[0], (string)data[1], (string)data[2]);
            fill();
        }

        public void set(object[] data, object[] original_data)
        {
            if (((string)data[0]).Equals("") | ((string)data[1]).Equals(""))
                throw new IncorrectDataException();
            if (!data[2].ToString().Equals(original_data[2].ToString()) | adapter.GetCountAccByRole((string)data[2]) != 0)
                throw new IncorrectDataException("В системе предусмотрена только одна учетная запись с данной ролью");
            if (!((string)data[0]).Equals((string)original_data[0]) | adapter.GetCountAccByLogin((string)data[0]) != 0)
                throw new IncorrectDataException("Учетная запись с таким логином уже существует");
            adapter.Update((string)data[0], (string)data[1], (string)data[2],
                            (string)original_data[0], (string)original_data[1], (string)original_data[2]);
            fill();
        }
    }
}
