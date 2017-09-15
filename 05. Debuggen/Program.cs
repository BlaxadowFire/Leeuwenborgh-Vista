using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Debuggen
{
    class Program
    {
        /*  In deze opdracht gaan we aan de slag met debuggen, de volgende code heeft een fout
            waardoor het programma vast loopt, zoek doormiddel van debugging uit wat er aan 
            de hand is en corrigeer de fout. */
        
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
