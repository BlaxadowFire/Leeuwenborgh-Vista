using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overzicht klas 1IMV-A14M");
            Console.WriteLine("------------------------------------------------");
            int intIndex = 0;

            string[] strArray = {"Maurits Annema", "Shunhui Zheng", "Tom Bastian", "Kevin Ung","Stefan Beckers", "Mark Rendes", "Dennis Engelen", "Michael Pisters", "Julean Hommel", "Jules Paays", "Nando Kools", "Cedric Louis-Guerin", "David Lei", "Bo Loomans"};
            Array.Sort(strArray);

            for (int i = 0; i < strArray.Length; i++)
            {
                intIndex++;
                Console.WriteLine("{0}.) {1}",intIndex,strArray[i]);
            };
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("In deze klas zitten {0} studenten.", intIndex); //volgens de index die loopt.
            Console.WriteLine("In deze klas zitten {0} studenten.", strArray.Length.ToString()); //volgens het aantal entry's in de array.
            Console.ReadLine();
        }
    }
}
