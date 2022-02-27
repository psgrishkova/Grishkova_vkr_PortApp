using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Exceptions
{
    class DataNotFoundException : Exception
    {
        private static string message = "Данные не найдены. Проверьте правильность введенных данных";
        public DataNotFoundException(string message) : base(message) { }

        public DataNotFoundException() : base(message) { }

    }
}
