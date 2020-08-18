using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class Program
    {
        public static int intResult;
        static int ShowInfo()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dit is een uitleg over functies");
            Program.intResult = Program.ShowInfo();
            Console.WriteLine("uitkomst is" + intResult);
            Console.ReadLine();
        }
    }
}
