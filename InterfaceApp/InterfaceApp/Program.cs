using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Phone phone = new Phone();
            Devices(computer);
            Devices(phone);
            Console.ReadLine();
        }

        public static void Devices(IDevice device)
        {
            Console.WriteLine("\r\n\r\nName:");
            Console.WriteLine(device.Name());
            Console.WriteLine("\r\nNIC:");
            Console.WriteLine(device.NIC());
            Console.WriteLine("\r\nTYPE:");
            Console.WriteLine(device.Type());
        }

    }
}
