using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Subwaj
{
    class Debug
    {
        public static void debug()
        {


            if (Program.StrAnswer == "debug" || Program.StrAnswer == "DEBUG" || Program.StrAnswer == "Debug")
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
                                    Program.ROOM1();
                                    break;
                                }
                            case "room2":
                                {
                                    Program.ROOM2();
                                    break;
                                }
                            case "room3":
                                {
                                    Program.ROOM3();
                                    break;
                                }
                            case "room4":
                                {
                                    Program.ROOM4();
                                    break;
                                }
                            case "room5":
                                {
                                    Program.ROOM5();
                                    break;
                                }
                            case "room6":
                                {
                                    Program.ROOM6();
                                    break;
                                }
                            case "room7":
                                {
                                    Program.ROOM7();
                                    break;
                                }
                            case "hall1":
                                {
                                    Program.HALL1();
                                    break;
                                }
                            case "hall2":
                                {
                                    Program.HALL2();
                                    break;
                                }
                            case "hall3":
                                {
                                    Program.HALL3();
                                    break;
                                }
                            case "hall4":
                                {
                                    Program.HALL4();
                                    break;
                                }
                            case "hall5":
                                {
                                    Program.HALL5();
                                    break;
                                }
                            case "hall6":
                                {
                                    Program.HALL6();
                                    break;
                                }
                            case "hall7":
                                {
                                    Program.HALL7();
                                    break;
                                }
                            case "hall8":
                                {
                                    Program.HALL8();
                                    break;
                                }
                            case "hall9":
                                {
                                    Program.HALL9();
                                    break;
                                }
                            case "hall10":
                                {
                                    Program.HALL10();
                                    break;
                                }
                            case "hall11":
                                {
                                    Program.HALL11();
                                    break;
                                }
                            case "hall12":
                                {
                                    Program.HALL12();
                                    break;
                                }
                            case "hall13":
                                {
                                    Program.HALL13();
                                    break;
                                }
                            case "hall14":
                                {
                                    Program.HALL14();
                                    break;
                                }
                            case "exit":
                            case "":
                            case "mainmenu":
                                {
                                    Program.MainMenu();
                                    break;
                                }
                            default:
                                {
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