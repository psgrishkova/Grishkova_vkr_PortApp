using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Controllers
{
    public class AuthController
    {
        public static string authorization(demoDataSetTableAdapters.АккаунтTableAdapter adapter, string login, string pass)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(pass))
            {
                try
                {
                    return adapter.Authorization(login, pass).Rows[0].ItemArray[2].ToString();
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
            else return string.Empty;
        }
    }
}
