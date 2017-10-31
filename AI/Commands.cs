using System;
using System.IO;
using System.Threading;

namespace AI
{
    class Commands
    {
        public static void CommandList(string i)
        {
            switch (Program.Input)
            {
                case "?":
                case "help":
                    {
                        Program.Write = "These are all the available commands and actions, press any key to continue";
                        Program.ResetCursor();
                        Console.CursorTop = 0;
                        Console.WriteLine(Program.Write);
                        Tts.Speech(Program.Write);
                        Console.SetCursorPosition(0, 2);
                        foreach (string str in Program.ListenReader)
                        {
                            Console.CursorLeft = 0;
                            Console.Write(str);
                            Console.Write("\r\n");
                        }
                        Console.SetCursorPosition(Console.WindowWidth / 2 + 10, 2);
                        foreach (string str in Program.RespondReader)
                        {
                            Console.CursorLeft = Console.WindowWidth / 2;
                            Console.Write(str);
                            Console.Write("\r\n");
                        }
                        Console.WriteLine("\r\n\r\n");
                        foreach (string str in Program.StockCommands)
                        {
                            Console.Write(str);
                            Console.Write("\r\n");
                        }
                        Console.ReadKey();
                        break;
                    }
                case "what is my name?":
                case "what is my name":
                case "my name":
                    {
                        if (Program.Username[0] == string.Empty)
                        {
                            Program.Write = "Your name is " + Environment.UserName;
                        }
                        else
                        {
                            Program.Write = "Your name is " + Program.Username[0];
                        }
                        Program.ResetCursor();
                        Console.WriteLine(Program.Write);
                        Tts.Speechsync(Program.Write);
                        break;
                    }
                case "what is your name?":
                case "what is your name":
                case "your name":
                case "name":
                    {
                        Program.Write = "My name is, NANDOAI";
                        Program.ResetCursor();
                        Console.WriteLine(Program.Write);
                        Tts.Speechsync("My name is, Nando Artificial Intelligence");
                        Thread.Sleep(500);
                        break;
                    }
                case "age":
                case "your age":
                case "current age":
                case "currentage":
                    {
                        var currentAge = Program.CurrentDate() - Program.CreationDate;
                        Program.Write = "My current age is: " + currentAge;
                        //Program.Write = "My current age is: " + CurrentAge.Days + " Days, "+ CurrentAge.Hours + " Hours, "+ CurrentAge.Minutes + " Minutes & " + CurrentAge.Seconds + " Seconds.";
                        //Program.ResetCursor();
                        //Console.WriteLine(Program.Write);
                        //TTS.speechsync(Program.Write);
                        Program.Write = "My current age is: " + currentAge;
                        Program.ResetCursor();
                        Console.WriteLine(Program.Write);
                        Tts.Speechsync(Program.Write);
                        Thread.Sleep(500);
                        break;
                    }
                case "creation":
                case "creation date":
                case "creationdate":
                    {
                        Program.Write = "I have been created on " + Program.CreationDate;
                        Program.ResetCursor();
                        Console.WriteLine(Program.Write);
                        Tts.Speechsync(Program.Write);
                        Thread.Sleep(500);
                        break;
                    }
                case "date":
                case "current date":
                case "time":
                case "current time":
                case "datetime":
                    {
                        Program.Write = "today is " + Program.CurrentDate();
                        Program.ResetCursor();
                        Console.WriteLine(Program.Write);
                        Tts.Speechsync(Program.Write);
                        Thread.Sleep(500);
                        break;
                    }
                case "change username":
                case "change my name":
                case "change my username":
                case "username":
                case "change name":
                    {
                        Program.ResetCursor();
                        if (Program.Username[0] == string.Empty || Program.Username[0] == "" || Program.Username[0] == "\\")
                        {
                            Program.Username[0] = Environment.UserName;
                            File.WriteAllLines(Program.StockCommandsPath, Program.StockCommands.ToArray());
                        }
                            Program.Write = "Current username: " + Program.Username[0];
                            Console.WriteLine(Program.Write);
                            Tts.Speechsync(Program.Write);
                        Console.Write("New username: ");
                        Tts.Speech("Enter your new username");
                        Program.Username[0] = Console.ReadLine();
                        File.WriteAllLines(Program.StockCommandsPath, Program.StockCommands.ToArray());
                        break;
                    }
                case "exit":
                case "bye":
                case "close":
                    {
                        Program.ResetCursor();
                        Program.Write = "See you later " + Program.Username[0];
                        Console.WriteLine(Program.Write);
                        Tts.Speechsync(Program.Write);
                        Program.MiddleLeft(Program.Write);
                        Program.Write = "bye bye";
                        Console.WriteLine(Program.Write);
                        Tts.Speechsync(Program.Write);
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        for (Program.CommandCounter = 0; Program.CommandCounter < Program.ListenReader.Count; Program.CommandCounter++)
                        {
                            if (Program.ListenReader[Program.CommandCounter] == Program.Input)
                            {
                                Program.CommandExists = true;
                                Program.RespondToCommand();
                            }
                            /*
                            else
                            {
                                CommandCounter++;
                            }
                            */
                        }
                        if (!Program.CommandExists)
                        {
                            Program.CreateCommand();
                        }
                        Program.CommandExists = false;
                        break;
                    }
            }
        }
    }
}
