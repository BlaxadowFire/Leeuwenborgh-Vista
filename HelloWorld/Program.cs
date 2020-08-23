using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, hoe heet jij?");
            var sInputName = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Hallo " + sInputName + " Hoe oud ben jij?");
            string sInputAge = Console.ReadLine();
            int intInputAge = Convert.ToInt16(sInputAge);

            if (intInputAge == 0)
            {
                Console.WriteLine("Please enter a valid number");
                Console.ReadLine();
                goto Finish;
            }
            Console.Clear();

            Console.WriteLine("Hallo " + sInputName + ". Jij bent dus " + sInputAge + " Jaar oud.");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Ben jij al jarig geweest dit jaar?");

            intInputAge = Convert.ToInt16(sInputAge);
            long lngBirthYearOld = 2017 - intInputAge;
            long lngBirthYearYoung = 2016 - intInputAge;
            long lngBirthYear = 2017;
            string strBirthYearCheck = Console.ReadLine();

            if(strBirthYearCheck == "ja")
            {
                lngBirthYear = lngBirthYearOld;
            }
            else
            {
                lngBirthYear= lngBirthYearYoung;
            }

            Console.WriteLine("Jij bent dus geboren in: " + lngBirthYear);
            Console.ReadLine();
            Finish:;
        }
    }
}
