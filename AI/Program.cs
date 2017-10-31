using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Speech.Synthesis;

namespace AI
{
    class Program
    {
        public static List<string> ListenReader = File.ReadAllLines("Commands/ListenToCommand.txt").ToList<string>();
        public static List<string> RespondReader = File.ReadAllLines("Commands/RespondToCommand.txt").ToList<string>();
        public static List<string> StockCommands = File.ReadAllLines("Commands/Stock Commands.txt").ToList<string>();
        public static string ListenPath = "Commands/ListenToCommand.txt";
        public static string RespondPath = "Commands/RespondToCommand.txt";
        public static string StockCommandsPath = "Commands/Stock Commands.txt";
        //public static string[] ListenWriter = File.WriteAllText("Commands/ListenToCommand.txt");
        //public static string[] RespondWriter = File.WriteAllText("Commands/RespondToCommand.txt");

        public static int CommandCounter = 0;

        public static List<string> Username = File.ReadAllLines("Commands/Username.txt").ToList<string>();

        public static string write = string.Empty;

        public static bool CommandExists = false;

        public static string Input = string.Empty;

        public static DateTime CreationDate = new DateTime(2017, 10, 31, 14, 30, 00);

        public static DateTime CurrentDate()
        {
            DateTime CurrentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            return CurrentDate;
        }

        static void Main(string[] args)
        {
            if (Program.Username[0] == string.Empty || Program.Username[0] == "" || Program.Username[0] == "\\")
            {
                Program.Username[0] = Environment.UserName;
                File.WriteAllLines(Program.StockCommandsPath, Program.StockCommands.ToArray());
            }


            Console.Title = "Nando AI";
            //TTS.TextToSpeech();
            start();
        }
        public static void start()
        {
            while (true)
            {
                write = string.Empty;
                Console.CursorVisible = true;
                write = "Write Command, Write '?' to see a list of commands.";
                ResetCursor();
                Console.CursorTop -= 4;
                Console.WriteLine(write);
                TTS.speech("Write Command");
                MiddleLeft("");
                MiddleTop();
                Input = Console.ReadLine().ToLower();
                ListenToCommand();
            }
        }
        public static void ResetCursor()
        {
            Console.Clear();
            MiddleLeft(write);
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
            //if Input == ? then write all the commands and reponds
            ResetCursor();
            Console.CursorVisible = false;
            Commands.CommandList(Input);
        }
        public static void RespondToCommand()
        {
            write = RespondReader[CommandCounter];
            ResetCursor();
            Console.WriteLine(write);
            TTS.speech(write);
            Thread.Sleep(3000);
        }
        public static void EditCommand()
        {

        }
        public static void CreateCommand()
        {
            Console.CursorVisible = true;
            ResetCursor();
            write = "How do you want me to respond to this command?";
            Console.WriteLine(write);
            TTS.speech(write);
            MiddleLeft(write);
            write = "Leave empty to cancel";
            Console.WriteLine(write);
            Thread.Sleep(2500);
            TTS.speech(write);
            string Respond = Console.ReadLine().ToLower();
            if (Respond != "")
            {
                ListenReader.Add(Input);
                File.WriteAllLines(ListenPath, ListenReader.ToArray());
                RespondReader.Add(Respond);
                File.WriteAllLines(RespondPath, RespondReader.ToArray());
            }
        }
    }
}
