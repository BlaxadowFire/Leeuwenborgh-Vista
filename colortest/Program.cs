using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace colortest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in ConsoleColor)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor[i];
                Thread.Sleep(500);
            }
            Console.ReadLine();
        }
    }
}
