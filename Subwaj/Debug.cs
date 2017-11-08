using System;
using System.Threading;
using System.IO;

namespace Subwaj
{
    class Debug
    {
        public static void DebugMode()
        {


            if (Program.StrAnswer == "debug")
            {
                if (Program.BlnDebug == false)
                {
                    Program.BlnDebug = true;
                    string strFilename = "files/mainmenucodes/Debug.txt";
                    Console.WriteLine(File.ReadAllText(strFilename));
                    Thread.Sleep(1000);
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("ENTER DEBUG COMMAND\r\n");
                        string x = Console.ReadLine().ToLower();
                        string strDebugInput = x;
                        switch (strDebugInput)
                        {
                            case "puzzle3":
                                {
                                    Console.Write(Puzzle3.Room2 + Puzzle3.Room4 + Puzzle3.Room1 + Puzzle3.Room3);
                                    Console.ReadKey();
                                    break;
                                }
                            case "room1":
                                {
                                    Program.TimerThread.Start();
                                    Program.Room1();
                                    break;
                                }
                            case "room2":
                                {
                                    Program.TimerThread.Start();
                                    Program.Room2();
                                    break;
                                }
                            case "room3":
                                {
                                    Program.TimerThread.Start();
                                    Program.Room3();
                                    break;
                                }
                            case "room4":
                                {
                                    Program.TimerThread.Start();
                                    Program.Room4();
                                    break;
                                }
                            case "room5":
                                {
                                    Program.TimerThread.Start();
                                    Program.Room5();
                                    break;
                                }
                            case "room6":
                                {
                                    Program.TimerThread.Start();
                                    Program.Room6();
                                    break;
                                }
                            case "room7":
                                {
                                    Program.TimerThread.Start();
                                    Program.Room7();
                                    break;
                                }
                            case "hall1":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall1();
                                    break;
                                }
                            case "hall2":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall2();
                                    break;
                                }
                            case "hall3":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall3();
                                    break;
                                }
                            case "hall4":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall4();
                                    break;
                                }
                            case "hall5":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall5();
                                    break;
                                }
                            case "hall6":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall6();
                                    break;
                                }
                            case "hall7":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall7();
                                    break;
                                }
                            case "hall8":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall8();
                                    break;
                                }
                            case "hall9":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall9();
                                    break;
                                }
                            case "hall10":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall10();
                                    break;
                                }
                            case "hall11":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall11();
                                    break;
                                }
                            case "hall12":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall12();
                                    break;
                                }
                            case "hall13":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall13();
                                    break;
                                }
                            case "hall14":
                                {
                                    Program.TimerThread.Start();
                                    Program.Hall14();
                                    break;
                                }
                            case "shop":
                                {
                                    Program.TimerThread.Start();
                                    Program.Shop();
                                    break;
                                }
                        }
                    } while (true);

                }
                else
                {
                    string strFilename = "files/mainmenucodes/DebugDisabled.txt";
                    Program.BlnDebug = false;
                    Console.WriteLine(File.ReadAllText(strFilename));
                    Thread.Sleep(1000);
                    Console.Clear();
                    Program.MainMenu();
                }
            }
        }
    }
}