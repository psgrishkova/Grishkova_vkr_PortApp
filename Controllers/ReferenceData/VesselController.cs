using Grishkova_vkr_PortApp.Exceptions;
using System;

namespace Grishkova_vkr_PortApp.Controllers.ReferenceData
{
    class VesselController : CRUDController
    {
        private const long companyId = 1;

        private vpdbDataSetTableAdapters.СудноTableAdapter adapter;
        private vpdbDataSet.СудноDataTable table;

        public VesselController(System.ComponentModel.Component adapter, System.Data.DataTable table)
        {
            this.adapter = (vpdbDataSetTableAdapters.СудноTableAdapter)adapter;
            this.table = (vpdbDataSet.СудноDataTable)table;
            fill();
        }

        public void add(object[] data)
        {
            if ((string)data[0] == string.Empty | (DateTime)data[1] > DateTime.Now | (string)data[2] == string.Empty | (string)data[3] == string.Empty)
                throw new IncorrectDataException();
            if (Convert.ToInt32(adapter.GetVesselCountByNum((string)data[0])) != 0)
                throw new IncorrectDataException("Судно с таким регистрационным номером уже существует");
            if (Convert.ToInt32(adapter.GetVesselCountByName((string)data[2])) != 0)
                throw new IncorrectDataException("Судно с таким названием уже существует");
            adapter.Insert((string)data[0], (DateTime)data[1], (string)data[2], (string)data[3], Convert.ToInt32(data[4]), companyId);
            fill();
        }

        public void fill()
        {
            adapter.Fill(table);
        }

        public void remove(object[] data)
        {
            adapter.Delete((string)data[0], (DateTime)data[1], (string)data[2], (string)data[3], Convert.ToInt32(data[4]), companyId);
            fill();
        }

        public void set(object[] data, object[] original_data)
        {
            if ((string)data[0] == string.Empty | (DateTime)data[1] > DateTime.Now | (string)data[2] == string.Empty | (string)data[3] == string.Empty)
                throw new IncorrectDataException();
            if (!((string)data[0]).Equals((string)original_data[0]) && Convert.ToInt32(adapter.GetVesselCountByNum((string)data[0])) != 0)
                throw new IncorrectDataException("Судно с таким регистрационным номером уже существует");
            if (!((string)data[2]).Equals((string)original_data[2]) && Convert.ToInt32(adapter.GetVesselCountByName((string)data[2])) != 0)
                throw new IncorrectDataException("Судно с таким названием уже существует");
            adapter.Update((string)data[0], (DateTime)data[1], (string)data[2], (string)data[3], Convert.ToInt32(data[4]), companyId,
                            (string)original_data[0], (DateTime)original_data[1], (string)original_data[2], (string)original_data[3], Convert.ToInt32(original_data[4]), companyId);
            fill();
        }
    }
}
