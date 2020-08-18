using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_dag_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

        lbl1:
            Console.Clear();
            Console.WriteLine("Hoi, hoe heet jij?\r\n");
            string Name = Console.ReadLine();

        lbl2:
            Console.Clear();
            Console.WriteLine("Jou naam is {0}, klopt dit? Y/N", Name);
            cki = Console.ReadKey();

            switch (cki.Key)
            {
                case ConsoleKey.Y:
                    break;
                case ConsoleKey.N:
                    goto lbl1;
                default:
                    goto lbl2;
            }

        lbl3:
            Console.Clear();
            Console.WriteLine("Hoi {0}, in welk jaar ben jij geboren?", Name);
            string Year = Console.ReadLine();
            int IntYear;
            try
            {
                IntYear = Convert.ToInt16(Year);
                if (IntYear <= 1900 || IntYear >= DateTime.Now.Year)
                {
                    Console.WriteLine("Vul A.U.B een geldig jaartal in");
                    Console.ReadKey();
                    goto lbl3;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Vul A.U.B een geldig jaartal in");
                Console.ReadKey();
                goto lbl3;
            }

        lbl4:
            Console.Clear();
            Console.WriteLine("{0}, jou geboortejaar is {1}, klopt dit? Y/N", Name, Year);
            cki = Console.ReadKey();

            switch (cki.Key)
            {
                case ConsoleKey.Y:
                    break;
                case ConsoleKey.N:
                    goto lbl3;
                default:
                    goto lbl4;
            }

        lbl5:
            Console.Clear();
            Console.WriteLine("Laatste vraag {0}, Ben je dit jaar al jarig geweest? Y/N", Name);
            cki = Console.ReadKey();
            int Age;
            if (cki.Key == ConsoleKey.Y)
            {
                Age = (DateTime.Now.Year - IntYear);
            }
            else if (cki.Key == ConsoleKey.N)
            {
                Age = (DateTime.Now.Year - IntYear - 1);
            }
            else
            {
                goto lbl5;
            }
            Console.Clear();
            Console.WriteLine("{0} Jou Leeftijd is {1}", Name, Age);
            Console.ReadKey();
        }
    }
}
