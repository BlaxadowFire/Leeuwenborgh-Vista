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
        //Checks UserInput
        public static void UserInput()
        {
            Program.DrawBottom();
            Console.SetCursorPosition(Console.CursorLeft, 28);
            Program.cki = Console.ReadKey();
            string strCKI = Program.cki.Key.ToString();
            switch (Program.CurrentRoom)
            {
                case "MainMenu":
                    {
                        switch (strCKI)
                        {
                            case "NumPad1":
                            case "D1":
                                {
                                    Program.MainMenuStart();
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
                                    Program.MainMenuAchievements();
                                    break;
                                }

                            case "NumPad6":
                            case "D6":
                                {
                                    Program.MainMenuLoadSaveGame();
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
                                    Program.MAINMENU();
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

                                        Program.cki = Console.ReadKey();
                                        strCKI = Program.cki.Key.ToString();
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
                                    UserInputs.BackToCurrentRoom();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.MainMenuHelp();
                                    break;
                                }
                            case "D3":
                            case "NumPad3":
                                {
                                    Program.MainMenuOptions();
                                    break;
                                }
                            case "D4":
                            case "NumPad4":
                                {
                                    //achievment options
                                    Errors.ErrorNotYetCreated();
                                    break;
                                }
                            case "D5":
                            case "NumPad5":
                                {
                                    //save game option
                                    Errors.ErrorNotYetCreated();
                                    break;
                                }
                            case "D6":
                            case "NumPad6":
                                {
                                    Program.MAINMENU();
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
                                    UserInputs.UserInput();
                                    break;
                                }
                        }
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
                            default:
                                {
                                    Program.HALL1();
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
                            default:
                                {
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
                            default:
                                {
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
                            default:
                                {
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
                            default:
                                {
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
                            default:
                                {
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
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.ROOM2();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.ROOM1();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.ROOM3();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.ROOM2();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.ROOM2();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.ROOM1();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.HALL5();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.ROOM3();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.ROOM4();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.HALL11();
                                    break;
                                }
                            case "D3":
                            case "NumPad3":
                                {
                                    Program.HALL4();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.ROOM4();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.ROOM5();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.HALL8();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.ROOM5();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.HALL12();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.HALL5();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.HALL10();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.HALL8();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.HALL9();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.HALL4();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.HALL5();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.ROOM6();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.HALL8();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.HALL14();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.ROOM6();
                                    break;
                                }
                            default:
                                {
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
                            case "D1":
                            case "NumPad1":
                                {
                                    Program.ROOM7();
                                    break;
                                }
                            case "D2":
                            case "NumPad2":
                                {
                                    Program.HALL13();
                                    break;
                                }
                            default:
                                {
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
            Errors.ErrorHandlerStart();
            Console.WriteLine("ERROR: OUT OF ROOM EXCEPTION");
            Console.WriteLine("ERROR ID: 0002");
            Errors.ErrorFinisher();
        }

        //Back to current room
        public static void BackToCurrentRoom()
        {
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
                        Program.MAINMENU();
                        break;
                    }
            }
        }

    }
}
