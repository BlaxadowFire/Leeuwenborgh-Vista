using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Computer : IDevice
    {
        public string Name()
        {
            return "Acer";
        }

        public string NIC()
        {
            return "LAN";
        }

        public string Type()
        {
            return "Desktop";
        }
    }
}
