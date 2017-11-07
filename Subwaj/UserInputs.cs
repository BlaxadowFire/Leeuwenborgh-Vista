using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Subwaj
{
    
    class UserInputs
    {
       
        public static void Nothing()
        {
            Console.Clear();
            Console.WriteLine("Nothing happened");
            Thread.Sleep(1000);
            Console.Clear();
            BackToCurrentRoom();
        }
        public static bool FirstRun = true;
        //Checks UserInput
        public static void UserInput()
        {
            Program.DrawBottom();
            Console.SetCursorPosition(Console.CursorLeft, 28);
            Program.Cki = Console.ReadKey();
            string strCKI = Program.Cki.Key.ToString();
            switch (Program.CurrentRoom)
            {
                case "MainMenu":
                    {
                        switch (strCKI)
                        {
                            case "NumPad1":
                            case "D1":
                                {
                                    if (FirstRun)
                                    {
                                        FirstRun = false;
                                        Program.MainMenuStart();
                                    }
                                    else
                                    {
                                        BackToCurrentRoom();
                                    }
                                    break;
                                }

                            case "NumPad2":
                            case "D2":
                                {
                                    Program.MainMenuHelp();
                                    break;
                                }

                            case "NumPad3":
                            case "D3":
                                {
                                    Program.MainMenuOptions();
                                    break;
                                }

                            case "NumPad4":
                            case "D4":
                                {
                                    Program.MainMenuCode();
                                    break;
                                }

                            case "NumPad5":
                            case "D5":
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "NumPad6":
                            case "D6":
                                {
                                    Program.MainMenuDlc();
                                    break;
                                }
                            case "NumPad0":
                            case "D0":
                                {
                                    Program.MainMenuExit();
                                    break;
                                }

                            default:
                                {
                                    Program.MainMenu();
                                    break;
                                }

                            case "Oem3":
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("ControlKeyInfo output debug");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    do
                                    {

                                        Program.Cki = Console.ReadKey();
                                        strCKI = Program.Cki.Key.ToString();
                                        Console.WriteLine("");
                                        Console.WriteLine("OUTPUT:" + strCKI);
                                    } while (true);
                                }

                        }
                        break;
                    }
                case "InGameMenu":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            case "D1":
                            case "NumPad1":
                                {
                                    //escape gaat terug naar de room
                                    Program.CurrentRoom = Program.InGameMenuTempRoom;
                                    Program.InGameMenuTempRoom = string.Empty;
                                    BackToCurrentRoom();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.InGameMap();
                                    break;
                                }
                            case "D3":
                            case "NumPad3":
                                {
                                    Program.MainMenuHelp();
                                    break;
                                }
                            case "D4":
                            case "NumPad4":
                                {
                                    Program.MainMenuOptions();
                                    break;
                                }
                            case "D5":
                            case "NumPad5":
                                {
                                    Program.MainMenu();
                                    break;
                                }
                            case "D0":
                            case "NumPad0":
                                {
                                    Program.MainMenuExit();
                                    break;
                                }
                            default:
                                {
                                    UserInput();
                                    break;
                                }
                        }
                        break;
                    }
                case "SHOP":
                    {
                        break;
                    }
                case "ROOM1":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                {
                                    Program.HALL1();
                                    break;
                                }
                            case "NumPad2":
                            case "D2":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Console.Clear();
                                    Console.WriteLine("Note This");
                                    Console.WriteLine(Puzzle3.Room1.ToString());
                                    Thread.Sleep(2500);
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                Nothing();
                                break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM2":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                if (Program.BlnPuzzle1Complete == false)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You must finish the puzzle first.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Program.HALL2();
                                }
                                break;
                    
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.HALL1();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Console.Clear();
                                    Console.WriteLine("Note This");
                                    Console.WriteLine(Puzzle3.Room2.ToString());
                                    Thread.Sleep(1000);
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                            {
                                if (Program.BlnPuzzle1Complete == false)
                                {
                                    Puzzle1.StartPuzzle1();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("You already completed this puzzle");
                                    Thread.Sleep(1000);
                                }
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM3":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                if (Program.BlnPuzzle2Complete == false)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You must finish the puzzle first.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Program.HALL4();
                                }
                                break;
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.HALL2();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Console.Clear();
                                    Console.WriteLine("Note This");
                                    Console.WriteLine(Puzzle3.Room3.ToString());
                                    Thread.Sleep(1000);
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                                {
                                    if (Program.BlnPuzzle2Complete == false)
                                    {
                                        Puzzle2.StartPuzzle2();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You already completed this puzzle");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                                }
                            case "Numpad6":
                            case "D6":
                            {
                                Errors.ErrorNotYetCreated();
                                break;
                            }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM4":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                {
                                    Program.HALL6();
                                    break;
                                }
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.HALL5();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Console.Clear();
                                    Console.WriteLine("Note This");
                                    Console.WriteLine(Puzzle3.Room4.ToString());
                                    Thread.Sleep(1000);
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM5":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                if (Program.BlnPuzzle3Complete == false)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You must finish the puzzle first.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Program.HALL7();
                                }
                                break;
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.HALL6();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                                {
                                    if (Program.BlnPuzzle3Complete == false)
                                    {
                                        Puzzle3.StartPuzzle3();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You already completed this puzzle");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM6":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                if (Program.BlnPuzzle4Complete == false)
                                {
                                    Console.Clear();
                                    Console.WriteLine("You must finish the puzzle first.");
                                    Thread.Sleep(1000);
                                }
                                else
                                {
                                    Program.HALL13();
                                }
                                break;
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.HALL12();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                                {
                                    if (Program.BlnPuzzle4Complete == false)
                                    {
                                        Puzzle4.StartPuzzle4();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You already completed this puzzle");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM7":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "D1":
                            case "NumPad1":
                                {
                                    // is tijdelijk
                                   
                                    Console.Clear();
                                    Console.WriteLine("Congrats you killed the boss GG");
                                    Console.ReadLine();
                                    Environment.Exit(0);
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.HALL14();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL1":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.ROOM2();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.ROOM1();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                               Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL2":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.ROOM3();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.ROOM2();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL3":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Errors.ErrorNotYetCreated();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.ROOM3();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Program.WallPosition("bla");
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL4":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.HALL5();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.ROOM3();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad5":
                            case "D5":
                            {
                                    if (Program.IntKey == 1)
                                    {
                                        Program.HALL10();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You need a key to open this door.");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                                }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL5":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.ROOM4();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.HALL4();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad5":
                            case "D5":
                            {
                                Program.HALL11();
                                break;
                            }
                            case "NumPad6":
                            case "D6":
                            {
                                    if (Program.IntKey == 1)
                                    {
                                        Program.HALL8();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You need a key to open this door.");
                                        Thread.Sleep(1000);
                                    }
                                    break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL6":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.ROOM5();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.ROOM4();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL7":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.HALL8();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.ROOM5();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL8":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                                {
                                    Program.InGameMenu();
                                    break;
                                }
                            case "NumPad1":
                            case "D1":
                                {
                                    Program.HALL12();
                                    break;
                                }
                            case "NumPad2":
                            case "D2":
                                {
                                    Program.HALL7();
                                    break;
                                }
                            case "NumPad3":
                            case "D3":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad4":
                            case "D4":
                                {
                                    Nothing();
                                    break;
                                }
                            case "NumPad5":
                            case "D5":
                                {
                                    Program.HALL9();
                                    break;
                                }
                            case "NumPad6":
                            case "D6":
                                {
                                    Program.HALL5();
                                    break;
                                }
                            default:
                                {
                                    BackToCurrentRoom();
                                    break;
                                }
                        }
                        break;
                    }
                case "HALL9":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.HALL10();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.HALL8();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL10":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.HALL4();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.HALL9();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL11":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.HALL5();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL12":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.ROOM6();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.HALL8();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL13":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                Program.HALL14();
                                break;
                            }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.ROOM6();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                case "HALL14":
                    {
                        switch (strCKI)
                        {
                            case "Escape":
                            {
                                Program.InGameMenu();
                                break;
                            }
                            case "NumPad1":
                            case "D1":
                            {
                                    if (Program.BlnBoss)
                                    {
                                       
                                        Program.ROOM7();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        string StrFileName = "files/story/Halls/Hall14/Hall14.txt";
                                        Console.WriteLine(File.ReadAllText(StrFileName));
                                        Thread.Sleep(1100);
                                        BackToCurrentRoom();
                                    }
                                    break;
                                }
                            case "NumPad2":
                            case "D2":
                            {
                                Program.HALL13();
                                break;
                            }
                            case "NumPad3":
                            case "D3":
                            {
                                Nothing();
                                break;
                            }
                            case "NumPad4":
                            case "D4":
                            {
                                Nothing();
                                break;
                            }
                            default:
                            {
                                BackToCurrentRoom();
                                break;
                            }
                        }
                        break;
                    }
                default:
                    {
                        Errors.ErrorHandlerStart();
                        Console.WriteLine("ERROR: ROOM NOT KNOWN");
                        Console.WriteLine("ERROR ID:0001");
                        Errors.ErrorFinisher();
                        break;
                    }
            }
            BackToCurrentRoom();
        }

        //Back to current room
        public static void BackToCurrentRoom()
        {
            if (Program.CurrentRoom == Program.StrMainMenu)
            {
                Program.CurrentRoom = Program.InGameMenuTempRoom;
            }
            switch (Program.CurrentRoom)
            {
                case "ROOM1":
                    {
                        Program.ROOM1();
                        break;
                    }
                case "ROOM2":
                    {
                        Program.ROOM2();
                        break;
                    }
                case "ROOM3":
                    {
                        Program.ROOM3();
                        break;
                    }
                case "ROOM4":
                    {
                        Program.ROOM4();
                        break;
                    }
                case "ROOM5":
                    {
                        Program.ROOM5();
                        break;
                    }
                case "ROOM6":
                    {
                        Program.ROOM6();
                        break;
                    }
                case "ROOM7":
                    {
                        Program.ROOM7();
                        break;
                    }
                case "HALL1":
                    {
                        Program.HALL1();
                        break;
                    }
                case "HALL2":
                    {
                        Program.HALL2();
                        break;
                    }
                case "HALL3":
                    {
                        Program.HALL3();
                        break;
                    }
                case "HALL4":
                    {
                        Program.HALL4();
                        break;
                    }
                case "HALL5":
                    {
                        Program.HALL5();
                        break;
                    }
                case "HALL6":
                    {
                        Program.HALL6();
                        break;
                    }
                case "HALL7":
                    {
                        Program.HALL7();
                        break;
                    }
                case "HALL8":
                    {
                        Program.HALL8();
                        break;
                    }
                case "HALL9":
                    {
                        Program.HALL9();
                        break;
                    }
                case "HALL10":
                    {
                        Program.HALL10();
                        break;
                    }
                case "HALL11":
                    {
                        Program.HALL11();
                        break;
                    }
                case "HALL12":
                    {
                        Program.HALL12();
                        break;
                    }
                case "HALL13":
                    {
                        Program.HALL13();
                        break;
                    }
                case "HALL14":
                    {
                        Program.HALL14();
                        break;
                    }
                case "InGameMenu":
                    {
                        Program.InGameMenu();
                        break;
                    }
                case "MainMenu":
                    {
                        //moet value uit ingametemproom pakken.
                        Program.MainMenu();
                        break;
                    }
            }
        }

    }
}
