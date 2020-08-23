using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Phone : IDevice
    {
        public string Name()
        {
            return "Samsung";
        }

        public string NIC()
        {
            return "Wireless";
        }

        public string Type()
        {
            return "Smartphone";
        }
    }
}
