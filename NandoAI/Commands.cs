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
                        Console.WriteLine("\r\n");
                        for (int x = 0; x < Program.RespondReader.Count; x++)
                        {
                            Console.CursorLeft = Console.WindowWidth / 2;
                            Console.Write(Program.RespondReader[x]);
                            Console.Write("\r\n");
                        }
                        Console.ReadKey();
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
                        break;
                    }
            }
        }
    }
}
