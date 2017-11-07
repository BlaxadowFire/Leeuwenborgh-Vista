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
                    
                    string strDebugInput = Console.ReadLine().ToLower();
                        switch (strDebugInput)
                        {
                            case "room1":
                                {
                                    Program.Room1();
                                    break;
                                }
                            case "room2":
                                {
                                    Program.Room2();
                                    break;
                                }
                            case "room3":
                                {
                                    Program.Room3();
                                    break;
                                }
                            case "room4":
                                {
                                    Program.Room4();
                                    break;
                                }
                            case "room5":
                                {
                                    Program.Room5();
                                    break;
                                }
                            case "room6":
                                {
                                    Program.Room6();
                                    break;
                                }
                            case "room7":
                                {
                                    Program.Room7();
                                    break;
                                }
                            case "hall1":
                                {
                                    Program.Hall1();
                                    break;
                                }
                            case "hall2":
                                {
                                    Program.Hall2();
                                    break;
                                }
                            case "hall3":
                                {
                                    Program.Hall3();
                                    break;
                                }
                            case "hall4":
                                {
                                    Program.Hall4();
                                    break;
                                }
                            case "hall5":
                                {
                                    Program.Hall5();
                                    break;
                                }
                            case "hall6":
                                {
                                    Program.Hall6();
                                    break;
                                }
                            case "hall7":
                                {
                                    Program.Hall7();
                                    break;
                                }
                            case "hall8":
                                {
                                    Program.Hall8();
                                    break;
                                }
                            case "hall9":
                                {
                                    Program.Hall9();
                                    break;
                                }
                            case "hall10":
                                {
                                    Program.Hall10();
                                    break;
                                }
                            case "hall11":
                                {
                                    Program.Hall11();
                                    break;
                                }
                            case "hall12":
                                {
                                    Program.Hall12();
                                    break;
                                }
                            case "hall13":
                                {
                                    Program.Hall13();
                                    break;
                                }
                            case "hall14":
                                {
                                    Program.Hall14();
                                    break;
                                }
                            case "shop":
                                {
                                    Program.Shop();
                                    break;
                                }
                            case "exit":
                            case "":
                            case "mainmenu":
                                {
                                    Program.MainMenu();
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