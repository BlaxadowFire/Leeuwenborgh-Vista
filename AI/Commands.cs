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
    class Commands
    {
        public static void CommandList(string i)
        {
            switch (Program.Input)
            {
                case "?":
                case "help":
                    {
                        Program.write = "These are all the available commands and actions, press any key to continue";
                        Program.ResetCursor();
                        Console.CursorTop = 0;
                        Console.WriteLine(Program.write);
                        TTS.speech(Program.write);
                        Console.SetCursorPosition(0, 2);
                        for (int x = 0; x < Program.ListenReader.Count; x++)
                        {
                            Console.CursorLeft = 0;
                            Console.Write(Program.ListenReader[x]);
                            Console.Write("\r\n");
                        }
                        Console.SetCursorPosition(Console.WindowWidth / 2 + 10, 2);
                        for (int x = 0; x < Program.RespondReader.Count; x++)
                        {
                            Console.CursorLeft = Console.WindowWidth / 2;
                            Console.Write(Program.RespondReader[x]);
                            Console.Write("\r\n");
                        }
                        Console.WriteLine("\r\n\r\n");
                        for (int x = 0; x < Program.StockCommands.Count; x++)
                        {;
                            Console.Write(Program.StockCommands[x]);
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
                            Program.write = "Your name is " + Environment.UserName;
                        }
                        else
                        {
                            Program.write = "Your name is " + Program.Username[0];
                        }
                        Program.ResetCursor();
                        Console.WriteLine(Program.write);
                        TTS.speechsync(Program.write);
                        break;
                    }
                case "what is your name?":
                case "what is your name":
                case "your name":
                case "name":
                    {
                        Program.write = "My name is, NANDOAI";
                        Program.ResetCursor();
                        Console.WriteLine(Program.write);
                        TTS.speechsync("My name is, Nando Artificial Intelligence");
                        Thread.Sleep(500);
                        break;
                    }
                case "age":
                case "your age":
                case "current age":
                case "currentage":
                    {
                        var CurrentAge = Program.CurrentDate() - Program.CreationDate;
                        Program.write = "My current age is: " + CurrentAge;
                        Program.ResetCursor();
                        Console.WriteLine(Program.write);
                        TTS.speechsync(Program.write);
                        Thread.Sleep(500);
                        break;
                    }
                case "creation":
                case "creation date":
                case "creationdate":
                    {
                        Program.write = "I have been created on " + Program.CreationDate;
                        Program.ResetCursor();
                        Console.WriteLine(Program.write);
                        TTS.speechsync(Program.write);
                        Thread.Sleep(500);
                        break;
                    }
                case "date":
                case "current date":
                case "time":
                case "current time":
                case "datetime":
                    {
                        Program.write = "today is " + Program.CurrentDate();
                        Program.ResetCursor();
                        Console.WriteLine(Program.write);
                        TTS.speechsync(Program.write);
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
                            Program.write = "Current username: " + Program.Username[0];
                            Console.WriteLine(Program.write);
                            TTS.speechsync(Program.write);
                        Console.Write("New username: ");
                        TTS.speech("Enter your new username");
                        Program.Username[0] = Console.ReadLine();
                        File.WriteAllLines(Program.StockCommandsPath, Program.StockCommands.ToArray());
                        break;
                    }
                case "exit":
                case "bye":
                case "close":
                    {
                        Program.ResetCursor();
                        Program.write = "See you later " + Program.Username[0];
                        Console.WriteLine(Program.write);
                        TTS.speechsync(Program.write);
                        Program.MiddleLeft(Program.write);
                        Program.write = "bye bye";
                        Console.WriteLine(Program.write);
                        TTS.speechsync(Program.write);
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
