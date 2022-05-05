using Grishkova_vkr_PortApp.Forms.OperationalData;
using System;
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
            Application.Run(new SignIn_Form());
        }
    }
}
