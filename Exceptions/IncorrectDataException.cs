using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Exceptions
{
    class IncorrectDataException : Exception
    {
        private static string message = "Введены некорректные данные";
        public IncorrectDataException(string message) : base(message) { }

        public IncorrectDataException() : base(message) { }
    }
}
