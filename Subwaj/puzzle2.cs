using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Subwaj
{
    class Puzzle2
    {
        public static string answer = string.Empty;
        public Puzzle2() {/*Start methode*/}

        public static void StartPuzzle2()
        {
            Console.Clear();
            string[] strQuestionFile = File.ReadAllLines("files/Puzzles/Puzzle2/Questions.txt");
            string[] strAnserFile = File.ReadAllLines("files/Puzzles/Puzzle2/Answers.txt");
            string[] strLettersFile = File.ReadAllLines("files/Puzzles/Puzzle2/Letters.txt");
            int i = 0;
            int WrongAnswer = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\r\n\r\n");
                Console.WriteLine(strQuestionFile[i] + "\r\n");

                if (WrongAnswer >= 3)
                {
                    Console.WriteLine("The length of the answer is:" + strAnserFile[i].Length + "\r\n");
                    Console.WriteLine("Use the following letters to solve the puzzle.\r\n" + strLettersFile[i] + "\r\n");
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
