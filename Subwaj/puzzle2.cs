using System;
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
        public static string answer = string.Empty;
        public puzzle2() {/*Start methode*/}

        public static void startpuzzle2()
        {
            Console.Clear();
            string[] strQuestionFile = File.ReadAllLines("files/Puzzles/Questions.txt");
            string[] strAnserFile = File.ReadAllLines("files/Puzzles/Answers.txt");
            int i = 0;
            int WrongAnswer = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(strQuestionFile[i]);

                if (WrongAnswer >= 3)
                {
                    Console.WriteLine("The length of the answer is:" + strAnserFile[i].Length);
                }
                Program.DrawBottom();
                answer = Console.ReadLine().ToLower();
                if (answer == strAnserFile[i])
                {
                    i++;
                    WrongAnswer = 0;
                }
                else
                {
                    WrongAnswer++;
                }

            } while (i < 6);
            Program.blnPuzzle2Complete = true;
        }
    }
}
