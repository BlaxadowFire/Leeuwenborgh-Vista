using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Test
{
    class Program
    {
        public static int i = 37;
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Background);
            Thread BackgroundThread = new Thread(ts);
            BackgroundThread.Start();

            do
            {
                i++;
                Console.WriteLine("BEEEEEEEEEEEEP" + i);
                if (i == 30000)
                {
                    i = 37;
                }

            }
            while (true);
        }
        public static void Background()
        {
            do
            {
                Console.Beep(i, 200);
                Console.Beep(i, 200);
                Console.Beep(i, 200);
                Console.Beep(i, 200);
            }
            while (true);
        }
    }
}
