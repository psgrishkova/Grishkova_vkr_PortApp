using Grishkova_vkr_PortApp.Forms;
using Grishkova_vkr_PortApp.Forms.OperationalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grishkova_vkr_PortApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ReferenceDataForm());
        }
    }
}
