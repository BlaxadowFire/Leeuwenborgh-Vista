using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace AI
{
    class Program
    {
        public static List<string> ListenReader = File.ReadAllLines("Commands/ListenToCommand.txt").ToList();
        public static List<string> RespondReader = File.ReadAllLines("Commands/RespondToCommand.txt").ToList();
        public static List<string> StockCommands = File.ReadAllLines("Commands/Stock Commands.txt").ToList();
        public static string ListenPath = "Commands/ListenToCommand.txt";
        public static string RespondPath = "Commands/RespondToCommand.txt";
        public static string StockCommandsPath = "Commands/Stock Commands.txt";
        //public static string[] ListenWriter = File.WriteAllText("Commands/ListenToCommand.txt");
        //public static string[] RespondWriter = File.WriteAllText("Commands/RespondToCommand.txt");

        public static int CommandCounter = 0;

        public static List<string> Username = File.ReadAllLines("Commands/Username.txt").ToList();

        public static string Write = string.Empty;

        public static bool CommandExists = false;

        public static string Input = string.Empty;

        public static DateTime CreationDate = new DateTime(2017, 10, 31, 14, 30, 00);

        public static DateTime CurrentDate()
        {
            DateTime currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            return currentDate;
        }

        static void Main()
        {
            if (Username[0] == string.Empty || Username[0] == "" || Username[0] == "\\")
            {
                Username[0] = Environment.UserName;
                File.WriteAllLines(StockCommandsPath, StockCommands.ToArray());
            }


            Console.Title = "Nando AI";
            //Tts.TextToSpeech();
            Start();
        }
        public static void Start()
        {
            while (true)
            {
                Write = string.Empty;
                Console.CursorVisible = true;
                ResetCursor();
                Write = "NANDO AI CREATED BY NANDO KOOLS";
                MiddleLeft(Write);
                Console.CursorTop = 0;
                Console.WriteLine(Write);
                MiddleTop();
                MiddleLeft(Write);
                Write = "Write Command, Write '?' to see a list of commands.";
                Console.CursorTop -= 4;
                Console.WriteLine(Write);
                Tts.Speech("Write Command");
                MiddleLeft("");
                MiddleTop();
                Input = Console.ReadLine()?.ToLower();
                ListenToCommand();
            }
            // ReSharper disable once FunctionNeverReturns
        }
        public static void ResetCursor()
        {
            Console.Clear();
            MiddleLeft(Write);
            MiddleTop();
        }
        public static void MiddleLeft(string i)
        {
            if (i == string.Empty)
            {
                Console.CursorLeft = (Console.WindowWidth / 2) - 10;
            }
            else
            {
                Console.CursorLeft = (Console.WindowWidth / 2) - (i.Length/2)-2;
            }
        }
        public static void MiddleTop()
        {
            Console.CursorTop = Console.WindowHeight / 2;
        }
        public static void ListenToCommand()
        {
            //if Input == ? then Write all the commands and reponds
            ResetCursor();
            Console.CursorVisible = false;
            Commands.CommandList(Input);
        }
        public static void RespondToCommand()
        {
            Write = RespondReader[CommandCounter];
            ResetCursor();
            Console.WriteLine(Write);
            Tts.Speechsync(Write);
        }
        public static void EditCommand()
        {

        }
        public static void CreateCommand()
        {
            Console.CursorVisible = true;
            ResetCursor();
            Write = "How do you want me to respond to this command?";
            Console.WriteLine(Write);
            Tts.Speech(Write);
            MiddleLeft(Write);
            Write = "Leave empty to cancel";
            Console.WriteLine(Write);
            Thread.Sleep(2500);
            Tts.Speech(Write);
            string respond = Console.ReadLine()?.ToLower();
            if (respond != "")
            {
                ListenReader.Add(Input);
                File.WriteAllLines(ListenPath, ListenReader.ToArray());
                RespondReader.Add(respond);
                File.WriteAllLines(RespondPath, RespondReader.ToArray());
            }
        }
    }
}
