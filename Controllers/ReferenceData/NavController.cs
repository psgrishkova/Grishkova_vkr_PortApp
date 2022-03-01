using Grishkova_vkr_PortApp.Exceptions;
using System;

namespace Grishkova_vkr_PortApp.Controllers.ReferenceData
{
    class NavController : CRUDController
    {

        private demoDataSetTableAdapters.НавигацияTableAdapter adapter;
        private demoDataSet.НавигацияDataTable table;

        public NavController(System.ComponentModel.Component adapter, System.Data.DataTable table)
        {
            this.adapter = (demoDataSetTableAdapters.НавигацияTableAdapter)adapter;
            this.table = (demoDataSet.НавигацияDataTable)table;
            fill();
        }
        public void add(object[] data)
        {
            if((data[0].ToString()).Equals(""))
                throw new IncorrectDataException();
            if (adapter.CheckPeriod((((DateTime)data[1]).Date).ToString()) != 0 | (data[2] != null && adapter.CheckPeriod((((DateTime)data[2]).Date).ToString()) != 0))
                throw new IncorrectDataException("Периоды не могут пересекаться, проверьте правильность введенных данных");
            if (data[2]==null && adapter.CheckNullPeriod() > 0)
                throw new IncorrectDataException("В базе может быть только один текущий навигационный период. Введите дату завершения периода");
            if (adapter.findNavByNum(Convert.ToInt32(data[0])) != 0)
                throw new IncorrectDataException("Навигационный период с таким номером уже существует");
            if (data[2]!=null && (DateTime)data[1] > (DateTime)data[2])
                throw new IncorrectDataException("Неверный период. Дата начала не может быть позже даты окончания");
            if (data[2] == null)
                adapter.Insert(Convert.ToInt32(data[0]), (DateTime)data[1], null);
            else adapter.Insert(Convert.ToInt32(data[0]), (DateTime)data[1], (DateTime)data[2]);

            fill();
        }

        public void fill()
        {
            adapter.Fill(table);
        }

        public void remove(object[] data)
        {
            DateTime? original_date;
            if (data[2].GetType().Name == "DBNull")
                original_date = null;
            else original_date = (DateTime)data[2];
            adapter.Delete(Convert.ToInt32(data[0]), (DateTime)data[1], original_date);
            fill();
        }

        public void set(object[] data, object[] original_data)
        {
            if ((data[0].ToString()).Equals(""))
                throw new IncorrectDataException();
            if (!(data[0].ToString()).Equals(original_data[0].ToString()) && adapter.findNavByNum(Convert.ToInt32(data[0])) != 0)
                throw new IncorrectDataException("Навигационный период с таким номером уже существует");
            if (data[2] != null && (DateTime)data[1] > (DateTime)data[2])
                throw new IncorrectDataException("Неверный период. Дата начала не может быть позже даты окончания");
            if (data[2] != null && adapter.CheckNullPeriod() > 0)
                throw new IncorrectDataException("В базе может быть только один текущий навигационный период. Введите дату завершения периода");
            if (adapter.CheckPeriod((((DateTime)data[1]).Date).ToString()) != 0 | (data[2] != null && adapter.CheckPeriod((((DateTime)data[2]).Date).ToString()) != 0))
                throw new IncorrectDataException("Периоды не могут пересекаться, проверьте правильность введенных данных"); //потестить
            DateTime? date = (DateTime?)data[2];
            DateTime? original_date;
            if (original_data[2].GetType().Name == "DBNull")
                original_date = null;
            else original_date = (DateTime)original_data[2];
            adapter.Update(Convert.ToInt32(data[0]), (DateTime)data[1], date, 
                Convert.ToInt32(original_data[0]), (DateTime)original_data[1], original_date);
            fill();
           
        }
    }
}

