﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Subwaj
{
    class puzzle2
    {
        public puzzle2() {/*Start methode*/}

        public static void startpuzzle2()
        {
            Console.Clear();
            string[] strFile = File.ReadAllLines("files/Puzzles/puzzle3.txt");
            int i = 0;
            Console.WriteLine(strFile[0]);
            Console.ReadLine();
        }
    }
}
