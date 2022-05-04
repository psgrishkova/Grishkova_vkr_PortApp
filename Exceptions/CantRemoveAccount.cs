using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grishkova_vkr_PortApp.Exceptions
{
    public class CantRemoveAccount : Exception
    {
        private static string message = "Удалять аккануты нельзя. Доступно только редактирование.";
        public CantRemoveAccount() : base(message) { }
    }
}
