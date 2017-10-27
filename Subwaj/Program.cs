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
        public static string strAnswer = string.Empty;
        public static int intCode = 0;
        //Here we will place the public static variables
        public static Random _randomforeground = new Random();  //Gets used for random foregroundcolor.
        public static ConsoleColor originalForegroundColor;     //Sets the old foreground to a variable to make sure it isn't the same.

        public static ConsoleKeyInfo cki; //uses cki to use readkey.

        //Rooms
        public static string CurrentRoom = "MainMenu"; //Makes sure the program knows in what room the user is.
        public static string InGameMenuTempRoom = string.Empty; //Makes a temporary room when you go to the ingame menu

        //BGM
        public static int intReadSong;
        public static int intReadDuration;
        public static int intSongCounter;
        public static string BGMFileTone = "Tone.txt";
        public static string BGMFolder = "BGM subwaj/";
        public static string BGMFileDuration = "Duration.txt";
        public static ThreadStart ts = new ThreadStart(BGM);
        public static Thread BGMThread = new Thread(ts);
        public static bool blnPlayMusic = true;

        //Puzzle complete bools
        public static bool blnPuzzle1Complete = false;
        public static bool blnPuzzle2Complete = false;
        public static bool blnPuzzle3Complete = false;
        public static bool blnPuzzle4Complete = false;

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

        //HUD STUFF
        public static int intTimer = 3600;
        public static ThreadStart tsTimer = new ThreadStart(TimerFunction);
        public static Thread TimerThread = new Thread(tsTimer);
        public static int intCursorpositionLeft;
        public static int intCursorpositionTop;

        //TTS
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public static bool blnBGMCancel = false;
        public static string strTTSLocation = "files/story/TTS/";
        public static string strTXTLocation = "files/story/";

        //boolean's for code menu
        public static bool blnBoss = false;
        public static bool blnShop = false;
        public static bool blnDebug = false;

        //sleep
        public static int intSleep400 = 400; //400
    
        static void Main(string[] args)
        {
            Console.Title = "NOT A GAME";
            //Loops the program
            Console.WindowWidth = 120;
            Console.WindowHeight = 30;
            do
            {
                Console.WriteLine("\t\t\t\tPlease turn on the volume for best user experience");
                Console.Beep(800, 200); //default beep settings
                Console.Beep(600, 200);
                Console.Beep(400, 200);
                Thread.Sleep(1000);
                BGMThread.Start();
                Program.MAINMENU();
            }
            while (true);
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
                
                Program.GetRandomConsoleColor();

                Console.Clear();
                string strFilenamee = "files/menu/mainmenu.txt";
                Console.WriteLine(File.ReadAllText(strFilenamee));
                Console.ForegroundColor = ConsoleColor.White;
                UserInputs.UserInput();

            } while (true);
        }
        public static void MainMenuStart()
        {
            Console.Clear();
            //story
            string strUserStart;
            bool blnLoopQuestion = true;
            blnBGMCancel = true;
            player.SoundLocation = strTTSLocation + "Intro/intro1.wav";
            player.Play();

            string strIntroTextName = "Ah, you're Finally here: " + Environment.UserName + "!\r\n";
            for (int x = 0; x < strIntroTextName.Length; x++)
            {
                Console.Write(strIntroTextName[x]);
                if (strIntroTextName[x] == ',' || strIntroTextName[x] == ':')
                {
                    Thread.Sleep(intSleep400); //400
                }
                Thread.Sleep(40); //40

            }
            string strFilename = strTXTLocation + "intro/intro.txt";

            int intIntroTTS = 1; //Used to count the file

            string[] IntroText = File.ReadAllLines(strFilename);
            for (int i = 0; i < IntroText.Length; i++)
            {

                //Makes the TTS speak when int i is on 1, 3, 5, 7, 9, 11, 13 This way, it will speak at the same way as the text appears on the screen.
                //The location of the TTS changes  based on intIntroTTS
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 13)
                {
                    intIntroTTS += 1;
                    player.SoundLocation = strTTSLocation + "Intro/intro" + intIntroTTS + ".wav";
                    player.Play();
                }


                string strIntroText = IntroText[i];
                for (int x = 0; x < strIntroText.Length; x++)
                {
                    Console.Write(strIntroText[x]);
                    if (strIntroText[x] == ',')
                    {
                        Thread.Sleep(intSleep400); //400
                    }
                    Thread.Sleep(40); //40

                    //This had to be added to make line 8 of the text file (byte 7) in sync with the audio. Because the audio would else be interrupted.
                    if (i == 7 && x == 47) 
                    {
                        Thread.Sleep(600); //600
                    }
                }
                Console.Write("\r\n");
                Thread.Sleep(intSleep400); //400

            }
            Console.WriteLine("\r\n");
            if (TimerThread.IsAlive == false)
            {
                TimerThread.Start();
            }
            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Ah, you're Finally here: " + Environment.UserName + "!\r\n");
                Console.WriteLine(File.ReadAllText(strTXTLocation + "intro/intro.txt"));

                Program.DrawBottom();
                Console.SetCursorPosition(Console.CursorLeft, 28);


                strUserStart = Console.ReadLine().ToLower();
                if (strUserStart == "start" || strUserStart == "exit")
                {
                    blnLoopQuestion = false;
                }
            } while (blnLoopQuestion == true);

            if (strUserStart == "start")
            {
                Program.ROOM1();
            }
            else
            {
                Console.Clear();
                strFilename = strTXTLocation + "intro/exit.txt";
                IntroText = File.ReadAllLines(strFilename);
                intIntroTTS = 0;
                for (int i = 0; i < IntroText.Length; i++)
                {
                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 13)
                    {
                        intIntroTTS += 1;
                        player.SoundLocation = strTTSLocation + "Intro/Exit/exit" + intIntroTTS + ".wav";
                        player.Play();
                    }

                    string strIntroText = IntroText[i];
                    for (int x = 0; x < strIntroText.Length; x++)
                    {

                        Console.Write(strIntroText[x]);
                        if (strIntroText[x] == ',')
                        {
                            Thread.Sleep(intSleep400);
                        }
                        Thread.Sleep(40);

                    }
                    Console.Write("\r\n");
                    Thread.Sleep(500);

                }
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
        public static void MainMenuHelp()
        {

            do
            {
                Console.Clear();
                GetRandomConsoleColor();
                string strFilename = "files/help.txt";
                Console.WriteLine(File.ReadAllText(strFilename));
                Console.ForegroundColor = ConsoleColor.White;
                cki = Console.ReadKey();
                string strCKI = cki.Key.ToString();
                switch (strCKI)
                {
                    case "Enter":
                    case "Escape":
                        {
                                UserInputs.BackToCurrentRoom();
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
                            UserInputs.BackToCurrentRoom();
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

            do
            {
                Console.Clear();
                Console.WriteLine("Press Enter to go back to Main Menu");
                while (intCode == 0)
                {
                     strAnswer = Console.ReadLine().ToLower();
                    Debug.debug();
                    if (strAnswer == "boss" || strAnswer == "BOSS" || strAnswer == "Boss")
                    {
                        blnBoss = true;
                        string strFilename = "files/mainmenucodes/BossEnabled.txt";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        Program.MAINMENU();
                    }
                    else if (strAnswer == "shop" || strAnswer == "SHOP" || strAnswer == "Shop")
                    {
                        blnShop = true;
                        string strFilename = "files/mainmenucodes/ShopEnabled.txt";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        Program.MAINMENU();
                    }
                    
                    else if (strAnswer == "konami" || strAnswer == "KONAMI" || strAnswer == "Konami")
                    {
                        intCode = 1;
                    }
                    else
                    {
                        Program.MAINMENU();
                    }
                }
                while (intCode == 0);
                Console.Clear();
                Console.WriteLine("Please enter the Konami Code (START = ENTER)");
                Konami_Code.CheckKonami_Code();
            }
            while (true);

        }
        public static void MainMenuAchievements()
        {
            Errors.ErrorNotYetCreated();
        }
        public static void MainMenuLoadSaveGame()
        {
            Errors.ErrorNotYetCreated();
        }
        public static void MainMenuExit()
        {
            Environment.Exit(0);
        }
        //END OF MAINMENU

        //BEGIN OF InGameMenu
        public static void InGameMenu()
        {
            if (CurrentRoom != strInGameMenu)
            {
                InGameMenuTempRoom = CurrentRoom;
                CurrentRoom = strInGameMenu;
            }
            Console.Clear();
            GetRandomConsoleColor();
            string strFilename = "files/menu/ingamenu.txt";
            Console.WriteLine(File.ReadAllText(strFilename));
            UserInputs.UserInput();
            Console.ForegroundColor = ConsoleColor.White;

        }
        //END OF InGameMenu

        //BEGIN OF HUD
        public static void HUD()
        {
            if (CurrentRoom != strMainMenu && CurrentRoom != strInGameMenu)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.CursorLeft = 54, Console.CursorTop = 0);
                Console.WriteLine("║\t   TIME:  {0}\t  Current location:   {1}\t╠═╦╗:\t0", intTimer, CurrentRoom);
                Console.SetCursorPosition(Console.CursorLeft = 54, Console.CursorTop = 1);
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void TimerFunction()
        {
            while (intTimer > 0)
            {
                intTimer -= 1;
                intCursorpositionLeft = Console.CursorLeft;
                intCursorpositionTop = Console.CursorTop;
                Program.HUD();
                Console.SetCursorPosition(intCursorpositionLeft, intCursorpositionTop);
                Thread.Sleep(1000);
            }
            Program.GameOver();

        }
        //END OF HUD


        //BEGIN OF ROOMS
        public static void ROOM1()
        {

            CurrentRoom = strROOM1;
            Console.Clear();

                //story
            blnBGMCancel = true;
            string strFilename = strTXTLocation + "Rooms/Room1/Room1.txt";
            string[] IntroText = File.ReadAllLines(strFilename);
            int intIntroTTS = 0; //Used to count the file
            for (int i = 0; i < IntroText.Length; i++)
            {

                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 13 || i == 17)
                {
                    intIntroTTS += 1;
                    player.SoundLocation = strTTSLocation + "ROOM1/room1-" + intIntroTTS + ".wav";
                    player.Play();
                }
                if ( i == 12 || i == 15)
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                }
                string strIntroText = IntroText[i];
                for (int x = 0; x < strIntroText.Length; x++)
                {
                    Console.Write(strIntroText[x]);
                    if (strIntroText[x] == ',')
                    {
                        Thread.Sleep(intSleep400); //400
                    }
                    Thread.Sleep(40); //40

                }
                Console.Write("\r\n");
                Thread.Sleep(intSleep400); //400

            }
            Thread.Sleep(1000);
            blnBGMCancel = false;
            Console.WriteLine(File.ReadAllText("files/story/Rooms/Room1/Room1.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM2()
        {
            CurrentRoom = strROOM2;
            Console.Clear();
            if (blnPuzzle1Complete == false)
            {
                Puzzle1.StartPuzzle1();
                
            }
            Console.WriteLine(File.ReadAllText("files/story/Rooms/Room2/Room2.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM3()
        {
            CurrentRoom = strROOM3;
            Console.Clear();
            if (blnPuzzle2Complete == false)
            {
                puzzle2.startpuzzle2();
            }
            Console.WriteLine(File.ReadAllText("files/story/Rooms/Room3/Room3.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM4()
        {
            CurrentRoom = strROOM4;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Rooms/Room4/Room4.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM5()
        {
            CurrentRoom = strROOM5;
            Console.Clear();
            if (blnPuzzle3Complete == false)
            {
                puzzle3.startpuzzle3();
            }
            Console.WriteLine(File.ReadAllText("files/story/Rooms/Room5/Room5.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM6()
        {
            CurrentRoom = strROOM6;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Rooms/Room6/Room6.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM7()
        {
            CurrentRoom = strROOM7;
            Console.Clear();
            Console.WriteLine("BOSSROOM");
            Console.WriteLine(File.ReadAllText("files/story/Rooms/Room7/Room7.txt"));
            UserInputs.UserInput();
        }
        //END OF ROOMS

        //BEGIN OF HALLS
        public static void HALL1()
        {
            CurrentRoom = strHALL1;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall1.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();

        }
        public static void HALL2()
        {
            CurrentRoom = strHALL2;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall2.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL3()
        {
            CurrentRoom = strHALL3;
            Errors.ErrorNotYetCreated();
        }
        public static void HALL4()
        {
            CurrentRoom = strHALL4;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall4.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL5()
        {
            CurrentRoom = strHALL5;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall5.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL6()
        {
            CurrentRoom = strHALL6;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall6.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL7()
        {
            CurrentRoom = strHALL7;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall7.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL8()
        {
            CurrentRoom = strHALL8;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall8.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL9()
        {
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall9.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL10()
        {
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall10.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL11()
        {
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall11.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL12()
        {
            CurrentRoom = strHALL12;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall12.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL13()
        {
            CurrentRoom = strHALL13;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall13.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL14()
        {
            CurrentRoom = strHALL14;
            Console.Clear();
            Console.WriteLine(File.ReadAllText("files/story/Halls/Hall14.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        //END OF HALLS

        public static void NextRoom()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

        }

        //Draw a line above user input
        public static void DrawBottom()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.CursorLeft, 27);
            Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Random ConsoleColor Generator
        public static void GetRandomConsoleColor()
        {
            Array consoleColors = Enum.GetValues(typeof(ConsoleColor));
            originalForegroundColor = Console.ForegroundColor;
            do
            {
                Console.ForegroundColor = (ConsoleColor)consoleColors.GetValue(_randomforeground.Next(consoleColors.Length));
            } while (Console.ForegroundColor == Console.BackgroundColor || Console.ForegroundColor == originalForegroundColor || Console.ForegroundColor == ConsoleColor.Gray || Console.ForegroundColor == ConsoleColor.DarkGray || Console.ForegroundColor == ConsoleColor.DarkRed || Console.ForegroundColor == ConsoleColor.DarkMagenta || Console.ForegroundColor == ConsoleColor.DarkYellow || Console.ForegroundColor == ConsoleColor.DarkBlue || Console.ForegroundColor == ConsoleColor.DarkGreen || Console.ForegroundColor == ConsoleColor.Blue || Console.ForegroundColor == ConsoleColor.DarkCyan);
            originalForegroundColor = Console.ForegroundColor;
        }

        //BGM
        public static void BGM()
        {
            do
            {
                if (CurrentRoom != strMainMenu && CurrentRoom != string.Empty && blnPlayMusic == true /*&& blnBGMCancel ==false*/) //BGM In Game
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
                            } while (intSongCounter < strReadSong.Length && CurrentRoom != strMainMenu && blnPlayMusic == true /*&& blnBGMCancel == false*/);
                        intSongCounter = 0;
                    } while (CurrentRoom != string.Empty || CurrentRoom != strMainMenu && blnPlayMusic == true /*&& blnBGMCancel == false*/);
                }
                else if (CurrentRoom != string.Empty && CurrentRoom == strMainMenu && blnPlayMusic == true /*&& blnBGMCancel == false*/) //BGM Main Menu
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
                        } while (intSongCounter < strReadSong.Length && CurrentRoom == strMainMenu && blnPlayMusic == true /*&& blnBGMCancel == false*/);
                        intSongCounter = 0;
                    } while (CurrentRoom == strMainMenu && blnPlayMusic == true /*&& blnBGMCancel == false*/);
                }
            } while (true);
        }

        //GAMEOVER
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("How did you even manage to lose? this isn't even a game.\r\nPress any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
