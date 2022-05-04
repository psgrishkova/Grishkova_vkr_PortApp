using Grishkova_vkr_PortApp.demoDataSetTableAdapters;
using Grishkova_vkr_PortApp.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Grishkova_vkr_PortApp.Controllers.OperationalData
{
    public class WorkingDayController
    {
        public static bool checkPeriod(НавигацияTableAdapter adapter, string date)
        {
            if ((int)adapter.CheckPeriod(date,0) != 0)
                return true;
            else return false;
        }

        public static List<Staff> GetStaff(demoDataSet.ПерсоналDataTable staff)
        {
            List<Staff> result = new List<Staff>();
            foreach (DataRow row in staff.Rows)
            {
                result.Add(new Staff(row.ItemArray[0].ToString(), Convert.ToDecimal
                        (row.ItemArray[1]), Convert.ToDateTime(row.ItemArray[2]), row.ItemArray[3].ToString(),
                        Convert.ToInt64(row.ItemArray[4]), Convert.ToInt64(row.ItemArray[4])));
            }
            return result;
        }

        public static List<Ship> GetShips(demoDataSet.СудноDataTable ships)
        {
            List<Ship> result = new List<Ship>();
            foreach (DataRow row in ships.Rows)
            {
                result.Add(new Ship(row.ItemArray[0].ToString(), Convert.ToDateTime
                        (row.ItemArray[1]), row.ItemArray[2].ToString(), row.ItemArray[3].ToString(),
                        Convert.ToInt32(row.ItemArray[4]), Convert.ToInt64(row.ItemArray[4])));
            }
            return result;
        }

        public static NavPeriod getNavPeriod(НавигацияTableAdapter adapter, string date)
        {
            demoDataSet.НавигацияDataTable nav = adapter.GetNavByDay(date);
            if (nav.Rows.Count != 0)
                return new NavPeriod(Convert.ToInt64(nav.Rows[0].ItemArray[0]), Convert.ToDateTime(nav.Rows[0].ItemArray[1]), Convert.ToDateTime(nav.Rows[0].ItemArray[2]));
            else return null;
        }

        public static int? GetLogbookByDate(Вахтенный_журналTableAdapter adapter, string date)
        {
            return adapter.GetLogbookByDay(date);
        }

        public static void addLogbook(Вахтенный_журналTableAdapter v,demoDataSet.Вахтенный_журналDataTable t , НавигацияTableAdapter n, string num, DateTime date, long cap)
        {
            long id = (long)(v.maxId() + 1);
            demoDataSet.НавигацияDataTable res = n.GetNavByDay(date.Date.ToString());
            if (res.Rows.Count != 0)
            {
                long nav = Convert.ToInt64(res.Rows[0].ItemArray[0]);
                v.Insert(num, date, id, cap, nav);
                v.Fill(t);
            }
        }

        public static void update(Вахтенный_журналTableAdapter v,demoDataSet.Вахтенный_журналDataTable t,  string newNum, long newCap, long id)
        {
            v.UpdateQuery(newNum,newCap, id);
            v.Fill(t);
        }

        public static void delete(Вахтенный_журналTableAdapter v, demoDataSet.Вахтенный_журналDataTable t, long id)
        {
            v.DeleteQuery(id);
            v.Fill(t);
        }

    }
}
