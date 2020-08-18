using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Priem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Counter = 2;
            int Numbertotest = 2;
            do
            {
                if (Numbertotest % Counter == 0 && Counter < Numbertotest && Counter !=1)
                {
                    Numbertotest++;
                    Counter = 1;
                }
                
                else if (Numbertotest % Counter == 0 && Counter == Numbertotest)
                {
                        Console.WriteLine(Numbertotest);
                        Numbertotest++;
                        Counter = 1;
                }
                Counter++;
            }
            while (true);
        }
    }
}
