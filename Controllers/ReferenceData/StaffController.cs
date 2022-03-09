using Grishkova_vkr_PortApp.Exceptions;
using System;
using System.Data;
using System.Linq;

namespace Grishkova_vkr_PortApp.Controllers.ReferenceData
{
    class StaffController : CRUDController
    {
        private const long companyId = 1;

        private demoDataSetTableAdapters.ПерсоналTableAdapter adapter;
        private demoDataSet.ПерсоналDataTable table;

        public StaffController(System.ComponentModel.Component adapter, System.Data.DataTable table)
        {
            this.adapter = (demoDataSetTableAdapters.ПерсоналTableAdapter)adapter;
            this.table = (demoDataSet.ПерсоналDataTable)table;
            fill();
        }
        public void add(object[] data)
        {
            if (data.Contains(null))
                throw new IncorrectDataException();

            adapter.addStaff(data[3].ToString(), data[0].ToString(), Convert.ToDecimal(data[1]), (DateTime)data[2], companyId);
            fill();
        }

        public void fill()
        {
            adapter.Fill(table);
        }

        public void remove(object[] data)
        {
            adapter.DeleteStaff(data[0].ToString(), Convert.ToDecimal(data[1]));
            fill();
        }

        public void set(object[] data, object[] original_data)
        {
            adapter.UpdateStaff(data[0].ToString(), Convert.ToDecimal(data[1]), (string)data[2], original_data[0].ToString(), Convert.ToDecimal(original_data[1]));
            fill();
        }

        public string getRole(object[] data)
        {
            string c = null;
            adapter.getRoleByNameAndTel(data[0].ToString(), Convert.ToDecimal(data[1]), ref c);
            return c;
        }
    }
}
