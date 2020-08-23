using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    interface IDevice
    {
        string Name();

        string NIC();

        string Type();
    }
}
