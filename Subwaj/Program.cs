using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Subwaj
{
    class Program
    {
        //Here we will place the public static variables
        public static Random _randomforeground = new Random();  //Gets used for random foregroundcolor.
        public static ConsoleColor originalForegroundColor;     //Sets the old foreground to a variable to make sure it isn't the same.

        public static ConsoleKeyInfo cki; //uses cki to use readkey.
        public static string CurrentRoom = "MainMenu"; //Makes sure the program knows in what room the user is.

        //BGM
        public static int intReadSong;
        public static int intReadDuration;
        public static int intSongCounter;
        public static string BGMFileTone = "Tone.BGM";
        public static string BGMFolder = "BGM subwaj/";
        public static string BGMFileDuration = "Duration.BGM";
        public static ThreadStart ts = new ThreadStart(BGM);
        public static Thread BGMThread = new Thread(ts);
        public static bool blnPlayMusic = true;

        //Makes it easier to change rooms
        public static string strMainMenu = "MainMenu";
        public static string strInGameMenu = "InGameMenu";
        public static string strROOM1 = "ROOM1";
        public static string strROOM2 = "ROOM2";
        public static string strROOM3 = "ROOM3";
        public static string strROOM4 = "ROOM4";
        public static string strROOM5 = "ROOM5";
        public static string strROOM6 = "ROOM6";
        public static string strROOM7 = "ROOM7";
        public static string strHALL1 = "HALL1";
        public static string strHALL2 = "HALL2";
        public static string strHALL3 = "HALL3";
        public static string strHALL4 = "HALL4";
        public static string strHALL5 = "HALL5";
        public static string strHALL6 = "HALL6";
        public static string strHALL7 = "HALL7";
        public static string strHALL8 = "HALL8";
        public static string strHALL9 = "HALL9";
        public static string strHALL10 = "HALL10";
        public static string strHALL11 = "HALL11";
        public static string strHALL12 = "HALL12";
        public static string strHALL13 = "HALL13";
        public static string strHALL14 = "HALL14";

        //boolean's for code menu
        public static bool blnBoss = false;
        public static bool blnShop = false;


        static void Main(string[] args)
        {
            Console.Title = "NOT A GAME";
            //Loops the program
            do
            {
                BGMThread.Start();
                Program.MAINMENU();
            }
            while (true);
        }

        //Checks UserInput
        public static void UserInput()
        {
            Program.cki = Console.ReadKey();
            string strCKI = cki.Key.ToString();
            switch (CurrentRoom)
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

                                        cki = Console.ReadKey();
                                        strCKI = cki.Key.ToString();
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
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM1":
                    {
                        switch (strCKI)
                        {
                            case "Enter":
                                {
                                    break;
                                }
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case "ROOM2":
                    {
                        switch (strCKI)
                        {
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
                            default:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        Program.ErrorHandlerStart();
                        Console.WriteLine("ERROR: ROOM NOT KNOWN");
                        Console.WriteLine("ERROR ID:0001");
                        Program.ErrorFinisher();
                        break;
                    }
            }
            Program.ErrorHandlerStart();
            Console.WriteLine("ERROR: OUT OF ROOM EXCEPTION");
            Console.WriteLine("ERROR ID: 0002");
            Program.ErrorFinisher();
        }

        // BEGIN OF MAINMENU
        public static void MAINMENU()
        {
            Console.Clear();
            //Loops the main menu.
            do
            {
                CurrentRoom = strMainMenu;

                //makes the text a random color and prevents the foregroundcolor to be the same as the backgroundcolor.
                do
                {
                    originalForegroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = GetRandomConsoleColor();
                }
                while (Console.ForegroundColor == Console.BackgroundColor || Console.ForegroundColor == originalForegroundColor);
                Console.Clear();
                string strFilenamee = "files/mainmenu.menu";
                Console.WriteLine(File.ReadAllText(strFilenamee));

                Console.ForegroundColor = ConsoleColor.White;
                Program.UserInput();

            } while (true);
        }
        public static void MainMenuStart()
        {
            Console.Clear();
            //story
            Console.WriteLine("Going to ROOM1");
            Program.NextRoom();
            Program.ROOM1();
        }
        public static void MainMenuHelp()
        {

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                string strFilename = "files/help.menu";
                Console.WriteLine(File.ReadAllText(strFilename));
                Console.ForegroundColor = ConsoleColor.White;
                cki = Console.ReadKey();
                string strCKI = cki.Key.ToString();
                switch (strCKI)
                {
                    case "Enter":
                    case "Escape":
                        {
                            Program.MAINMENU();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            while (true);
        }
        public static void MainMenuOptions()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Press Esc to go back to Main Menu\r\n");
                Console.WriteLine("1.)\tToggle BGM(BackGroundMusic)");
                cki = Console.ReadKey();
                string strCKI = cki.Key.ToString();
                switch (strCKI)
                {
                    case "NumPad1":
                    case "D1":
                        {
                            if (blnPlayMusic == true)
                            {
                                blnPlayMusic = false;
                            }
                            else
                            {
                                blnPlayMusic = true;
                            }
                            break;
                        }
                    case "Escape":
                        {
                            Program.MAINMENU();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            while (true);
        }
        public static void MainMenuCode()
        {

            int intCode = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Press Enter to go back to Main Menu");
                while (intCode == 0)
                {
                    string strAnswer = Console.ReadLine();
                    if(strAnswer == "boss" || strAnswer == "BOSS" || strAnswer == "Boss")
                    {
                        blnBoss = true;
                        string strFilename = "files/BossEnabled.Codes";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        Program.MAINMENU();
                    }
                    else if(strAnswer == "shop" ||  strAnswer == "SHOP" || strAnswer == "Shop")
                    {
                        blnShop = true;
                        string strFilename = "files/ShopEnabled.Codes";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        Program.MAINMENU();
                    }
                    else if(strAnswer == "konami" || strAnswer == "KONAMI" || strAnswer == "Konami")
                    {
                        intCode = 1;
                    }
                    else
                    {
                        Program.MAINMENU();
                    }
                }
                while(intCode == 0);
                int Konamicode = 0;
                Console.Clear();
                Console.WriteLine("Please enter the Konami Code (START = ENTER)");
                do
                {
                    cki = Console.ReadKey();
                    string strCKI = cki.Key.ToString();
                    switch (strCKI)
                    {
                        case "UpArrow":
		                {
                                if (Konamicode == 0 || Konamicode == 1)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
			                break;
		                }
                        case "DownArrow":
                            {
                                if (Konamicode == 2 || Konamicode == 3)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "LeftArrow":
                            {
                                if (Konamicode == 4 || Konamicode == 6)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "RightArrow":
                            {
                                if (Konamicode == 5 || Konamicode == 7)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "B":
                            {
                                if (Konamicode == 8)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "A":
                            {
                                if (Konamicode == 9)
                                {
                                    Konamicode += 1;
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "Enter":
                            {
                                if (Konamicode == 10)
                                {
                                    string strFilename = "files/Achievements/Konami.Achievement";
                                    Console.WriteLine(File.ReadAllText(strFilename));
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Program.MAINMENU();
                                }
                                else
                                {
                                    Konamicode = 0;
                                }
                                break;
                            }
                        case "Escape":
                        {
                            Program.MAINMENU();
                            break;
                        }
                        default:
                        {
                            break;
                        }
                    }
                } while (true);
            }
            while (true);

        }
        public static void MainMenuAchievements()
        {
            Program.ErrorNotYetCreated();
        }
        public static void MainMenuLoadSaveGame()
        {
            Program.ErrorNotYetCreated();
        }
       
        public static void MainMenuExit() 
        {
             Environment.Exit(0);
        }
        //END OF MAINMENU


        //BEGIN OF ROOMS
        public static void ROOM1()
        {
            CurrentRoom = strROOM1;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL1);
            Program.NextRoom();
            Program.HALL1();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM2()
        {
            CurrentRoom = strROOM2;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL2);
            Program.NextRoom();
            Program.HALL2();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM3()
        {
            CurrentRoom = strROOM3;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL4);
            Program.NextRoom();
            Program.HALL4();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM4()
        {
            CurrentRoom = strROOM5;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL6);
            Program.NextRoom();
            Program.HALL6();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM5()
        {
            CurrentRoom = strROOM5;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL7);
            Program.NextRoom();
            Program.HALL7();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM6()
        {
            CurrentRoom = strROOM6;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL13);
            Program.NextRoom();
            Program.HALL13();
            Program.ErrorOutOfBounds();
        }
        public static void ROOM7()
        {
            CurrentRoom = strROOM7;
            Console.WriteLine("BOSSROOM");
            Console.ReadLine();
            Program.ErrorNotYetCreated();
        }
        //END OF ROOMS

        //BEGIN OF HALLS
        public static void HALL1()
        {
            CurrentRoom = strHALL1;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM2);
            Program.NextRoom();
            Program.ROOM2();
            Program.ErrorOutOfBounds();
        }
        public static void HALL2()
        {
            CurrentRoom = strHALL2;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM3);
            Program.NextRoom();
            Program.ROOM3();
            Program.ErrorOutOfBounds();
        }
        public static void HALL3()
        {
            CurrentRoom = strHALL3;
            Program.ErrorNotYetCreated();
        }
        public static void HALL4()
        {
            CurrentRoom = strHALL4;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL5);
            Program.NextRoom();
            Program.HALL5();
            Program.ErrorOutOfBounds();
        }
        public static void HALL5()
        {
            CurrentRoom = strHALL5;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM4);
            Program.NextRoom();
            Program.ROOM4();
            Program.ErrorOutOfBounds();
        }
        public static void HALL6()
        {
            CurrentRoom = strHALL6;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM5);
            Program.NextRoom();
            Program.ROOM5();
            Program.ErrorOutOfBounds();
        }
        public static void HALL7()
        {
            CurrentRoom = strHALL7;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL8);
            Program.NextRoom();
            Program.HALL8();
            Program.ErrorOutOfBounds();
        }
        public static void HALL8()
        {
            CurrentRoom = strHALL8;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL12);
            Program.NextRoom();
            Program.HALL12();
            Program.ErrorOutOfBounds();
        }
        public static void HALL9()
        {
            CurrentRoom = strHALL9;
            Program.ErrorNotYetCreated();
        }
        public static void HALL10()
        {
            CurrentRoom = strHALL10;
            Program.ErrorNotYetCreated();
        }
        public static void HALL11()
        {
            CurrentRoom = strHALL11;
            Program.ErrorNotYetCreated();
        }
        public static void HALL12()
        {
            CurrentRoom = strHALL12;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM6);
            Program.NextRoom();
            Program.ROOM6();
            Program.ErrorOutOfBounds();
        }
        public static void HALL13()
        {
            CurrentRoom = strHALL13;
            Console.Clear();
            Console.WriteLine("Going to " + strHALL14);
            Program.NextRoom();
            Program.HALL14();
            Program.ErrorOutOfBounds();
        }
        public static void HALL14()
        {
            CurrentRoom = strHALL14;
            Console.Clear();
            Console.WriteLine("Going to " + strROOM7);
            Program.NextRoom();
            Program.ROOM7();
            Program.ErrorOutOfBounds();
        }
        //END OF HALLS

        public static void NextRoom()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }


        //Random ConsoleColor Generator
        public static ConsoleColor GetRandomConsoleColor()
        {
            Array consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_randomforeground.Next(consoleColors.Length));
        }

        //BGM
        public static void BGM()
        {
            do
            {
                if (CurrentRoom != strMainMenu && CurrentRoom != string.Empty && blnPlayMusic == true) //BGM In Game
                {
                    do
                    {
                        string[] strReadSong = File.ReadAllLines(BGMFolder + BGMFileTone);
                        string[] strReadDuration = File.ReadAllLines(BGMFolder + BGMFileDuration);
                        intSongCounter = 0;
                        if (CurrentRoom != string.Empty && CurrentRoom != strMainMenu)

                            do
                            {
                                for (int i = 0; i < strReadSong.Length; i++)
                                {
                                    intReadSong = Convert.ToInt32(strReadSong[intSongCounter]);
                                }

                                for (int i = 0; i < strReadDuration.Length; i++)
                                {
                                    intReadDuration = Convert.ToInt32(strReadDuration[intSongCounter]);
                                }
                                intSongCounter++;
                                if (intReadSong != 0)
                                {
                                    Console.Beep(intReadSong, intReadDuration);
                                }
                                else
                                {
                                    Thread.Sleep(intReadDuration);
                                }
                            } while (intSongCounter < strReadSong.Length && CurrentRoom != strMainMenu && blnPlayMusic == true);
                        intSongCounter = 0;
                    } while (CurrentRoom != string.Empty || CurrentRoom != strMainMenu && blnPlayMusic == true);
                }
                else if (CurrentRoom != string.Empty && CurrentRoom == strMainMenu && blnPlayMusic == true) //BGM Main Menu
                {
                    do
                    {
                        string[] strReadSong = File.ReadAllLines(BGMFolder + "MainMenu/" + BGMFileTone);
                        string[] strReadDuration = File.ReadAllLines(BGMFolder + "MainMenu/" + BGMFileDuration);
                        intSongCounter = 0;
                        do
                        {
                            for (int i = 0; i < strReadSong.Length; i++)
                            {
                                intReadSong = Convert.ToInt32(strReadSong[intSongCounter]);
                            }

                            for (int i = 0; i < strReadDuration.Length; i++)
                            {
                                intReadDuration = Convert.ToInt32(strReadDuration[intSongCounter]);
                            }
                            intSongCounter++;
                            if (intReadSong != 0)
                            {
                                Console.Beep(intReadSong, intReadDuration);
                            }
                            else
                            {
                                Thread.Sleep(intReadDuration);
                            }
                        } while (intSongCounter < strReadSong.Length && CurrentRoom == strMainMenu && blnPlayMusic == true);
                        intSongCounter = 0;
                    } while (CurrentRoom == strMainMenu && blnPlayMusic == true);
                }
            } while (true);
        }

        //Error color
        public static void ErrorHandlerStart()
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
        //Error preventor
        public static void ErrorFinisher()
        {
            Console.WriteLine("\r\nInformation:\r\nCurrentRoom = {0}\r\n", CurrentRoom);
            Console.WriteLine("An unexpected error occured, please contact me at nando.kools@hotmail.com and give me the error ID");
            CurrentRoom = string.Empty;
            Thread.Sleep(500);
            Console.Beep(500, 1200);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadLine();
            Console.ReadLine();// made 2 readlines to make sure the user doesnt skip the error.
        }
        //If code isn't created yet
        public static void ErrorNotYetCreated()
        {
            Program.ErrorHandlerStart();
            Console.WriteLine("ERROR: CODE DOESN'T EXIST");
            Console.WriteLine("ERROR ID: 0003");
            Program.ErrorFinisher();
            Console.WriteLine("Press any button to return to Main Menu");
            Console.ReadKey();
            Program.MAINMENU();

        }
        //Error code out of bounds
        public static void ErrorOutOfBounds()
        {
            Program.ErrorHandlerStart();
            Console.WriteLine("ERROR: CODE OUT OF BOUNDS");
            Console.WriteLine("ERROR ID: 0004");
            Program.ErrorFinisher();
            Console.WriteLine("Press any button to return to Main Menu");
            Console.ReadKey();
            Program.MAINMENU();
        }
    }
}
