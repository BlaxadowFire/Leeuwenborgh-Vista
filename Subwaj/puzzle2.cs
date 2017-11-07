using System;
using System.Threading;
using System.IO;

namespace Subwaj
{
    class Puzzle2
    {


        public static string Answer = string.Empty;

        public static void StartPuzzle2()
        {
            if (Program.BlnPuzzle2 == false)
            {
                //story
                //story
                Console.Clear();
                string strFilename = Program.StrTxtLocation + "Halls/Hall2/Hall2.txt";
                string[] introText = File.ReadAllLines(strFilename);
                foreach (string strIntroText in introText)
                {
                    Program.Ss.SpeakAsync(strIntroText);
                    foreach (char vha in strIntroText)
                    {
                        Console.Write(vha);
                        if (vha == ',')
                        {
                            Thread.Sleep(Program.IntSleep400); //400
                        }
                        Thread.Sleep(40); //40
                    }
                    Console.Write("\r\n");
                    Thread.Sleep(Program.IntSleep400); //400
                }
                Thread.Sleep(1000);
                Console.Clear();
                Program.BlnPuzzle2 = true;
            }

            Console.Clear();
            string[] strQuestionFile = File.ReadAllLines("files/Puzzles/Puzzle2/Questions.txt");
            string[] strAnserFile = File.ReadAllLines("files/Puzzles/Puzzle2/Answers.txt");
            string[] strLettersFile = File.ReadAllLines("files/Puzzles/Puzzle2/Letters.txt");
            int i = 0;
            int wrongAnswer = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\r\n\r\n");
                Program.Ss.SpeakAsync(strQuestionFile[i]);
                Console.WriteLine(strQuestionFile[i] + "\r\n");

                if (wrongAnswer >= 3)
                {
                    Console.WriteLine("The length of the answer is:" + strAnserFile[i].Length + "\r\n");
                    Console.WriteLine("Use the following letters to solve the puzzle.\r\n" + strLettersFile[i] + "\r\n");
                }
                Program.DrawBottom();
                Answer = Console.ReadLine().ToLower();
                if (Answer == strAnserFile[i])
                {
                    i++;
                    wrongAnswer = 0;
                }
                else
                {
                    wrongAnswer++;
                }

            } while (i < 6);
            Program.BlnPuzzle2Complete = true;
        }
    }
}
