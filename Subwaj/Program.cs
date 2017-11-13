using System;
using System.Threading;
using System.IO;
using System.Speech.Synthesis;

namespace Subwaj
{

    class Program
    {
        public static bool Sword = false;

        public static string StrAnswer = string.Empty;

        public static int IntKey;

        //Here we will place the public static variables
        public static Random RandomForeGround = new Random(); //Gets used for random foregroundcolor.

        public static ConsoleColor OriginalForeGroundColor
            ; //Sets the old foreground to a variable to make sure it isn't the same.

        public static ConsoleKeyInfo Cki; //uses Cki to use readkey.

        //Rooms
        public static string CurrentRoom = "MainMenu"; //Makes sure the program knows in what room the user is.

        public static string InGameMenuTempRoom = "MainMenu"; //Makes a temporary room when you go to the ingame menu

        //BGM
        public static int IntReadSong;

        public static int IntReadDuration;
        public static int IntSongCounter;
        public static string BgmFileTone = "Tone.txt";
        public static string BgmFolder = "BGM subwaj/";
        public static string BgmFileDuration = "Duration.txt";
        public static ThreadStart Ts = Bgm;
        public static Thread BgmThread = new Thread(Ts);
        public static bool BlnPlayMusic = true;

        //Puzzle complete bools
        public static bool BlnPuzzle1Complete = false;

        public static bool BlnPuzzle2Complete = false;
        public static bool BlnPuzzle3Complete = false;
        public static bool BlnPuzzle4Complete = false;

        //Makes it easier to change rooms
        public static string StrMainMenu = "MainMenu";

        public static string StrInGameMenu = "InGameMenu";
        public static string StrShop = "SHOP";
        public static string StrRoom1 = "ROOM1";
        public static string StrRoom2 = "ROOM2";
        public static string StrRoom3 = "ROOM3";
        public static string StrRoom4 = "ROOM4";
        public static string StrRoom5 = "ROOM5";
        public static string StrRoom6 = "ROOM6";
        public static string StrRoom7 = "ROOM7";
        public static string StrHall1 = "HALL1";
        public static string StrHall2 = "HALL2";
        public static string StrHall3 = "HALL3";
        public static string StrHall4 = "HALL4";
        public static string StrHall5 = "HALL5";
        public static string StrHall6 = "HALL6";
        public static string StrHall7 = "HALL7";
        public static string StrHall8 = "HALL8";
        public static string StrHall9 = "HALL9";
        public static string StrHall10 = "HALL10";
        public static string StrHall11 = "HALL11";
        public static string StrHall12 = "HALL12";
        public static string StrHall13 = "HALL13";
        public static string StrHall14 = "HALL14";
        //HUD STUFF
        public static int IntTimerSeconds = 60;

        public static int IntTimerMinutes = 59;
        public static ThreadStart TsTimer = TimerFunction;
        public static Thread TimerThread = new Thread(TsTimer);
        public static int IntCursorpositionLeft;
        public static int IntCursorpositionTop;

        //TTS
        public static System.Media.SoundPlayer Player = new System.Media.SoundPlayer();

        public static string StrTtsLocation = "files/story/TTS/";
        public static string StrTxtLocation = "files/story/";
        public static SpeechSynthesizer Ss = new SpeechSynthesizer();

        public static void Voice()
        {
            try
            {
                Ss.SelectVoice("Microsoft David Desktop");
            }
            catch (Exception){}

        }

        //boolean's for code menu
        public static bool BlnBoss;

        public static bool BlnShop;
        public static bool BlnDebug = false;

        //Story read (so you don't get the story every time you go into the room)
        public static bool BlnRoom1Story;
        public static bool BlnRoom2Story;
        public static bool BlnRoom3Story;
        public static bool BlnRoom4Story;
        public static bool BlnRoom5Story;
        public static bool BlnRoom6Story;
        public static bool BlnRoom7Story;
        public static bool BlnHall1Story;
        public static bool BlnHall2Story;
        public static bool BlnHall3Story;
        public static bool BlnHall4Story;
        public static bool BlnHall5Story;
        public static bool BlnHall6Story;
        public static bool BlnHall7Story;
        public static bool BlnHall8Story;
        public static bool BlnHall9Story;
        public static bool BlnHall10Story;
        public static bool BlnHall11Story;
        public static bool BlnHall12Story;
        public static bool BlnHall13Story;
        public static bool BlnHall14Story;
        public static bool BlnPuzzle1 = false;
        public static bool BlnPuzzle2 = false;
        public static bool BlnPuzzle3 = false;
        public static bool BlnPuzzle4 = false;
        public static bool BlnShopStory;


        //sleep
        public static int IntSleep400 = 500; //400

        public static void Main(string[] args)
        {
            Console.Title = "NOT A GAME";
            Voice();
            //Loops the program
            Console.WindowWidth = 120;
            Console.WindowHeight = 30;
            Console.CursorVisible = false;

            Ss.Rate = 1;
            Ss.Volume = 100;

            do
            {
                Console.WriteLine("\t\t\t\tPlease turn on the volume for best user experience");
                Console.Beep(800, 200); //default beep settings
                Console.Beep(600, 200);
                Console.Beep(400, 200);
                Thread.Sleep(1000);
                if (BgmThread.IsAlive == false)
                {
                    BgmThread.Start();
                }
                MainMenuHelp();
            } while (true);
        }

        public static void Shop()
        {
            Console.Clear();
            CurrentRoom = StrShop;
            if (!BlnShopStory)
            {
                SpeakFile("Rooms/Shop/Shop.txt");
                BlnShopStory = true;
                Thread.Sleep(1000);
                Console.Clear();
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Rooms/Shop/Shop.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }

        // BEGIN OF MainMenu
        public static void MainMenu()
        {
            Console.Clear();
            //Loops the main menu.
            do
            {
                CurrentRoom = StrMainMenu;

                //makes the text a random color and prevents the foregroundcolor to be the same as the backgroundcolor.

                GetRandomConsoleColor();

                Console.Clear();
                string StrFileName = "files/menu/mainmenu.txt";
                Console.WriteLine(File.ReadAllText(StrFileName));
                Console.ForegroundColor = ConsoleColor.White;
                UserInputs.UserInput();

            } while (true);
        }

        public static void MainMenuStart()
        {
            Console.Clear();
            //story
            string strUserStart = string.Empty;
            bool blnLoopQuestion = true;

            //control help

            string strHelp2TextName = File.ReadAllText("files/Help2.txt");
            Ss.SpeakAsync(strHelp2TextName);
            foreach (char cha in strHelp2TextName)
            {
                Console.Write(cha);
                if (cha == ',' || cha == ':' || cha == '.' || cha == '!' || cha == '?')
                {
                    Thread.Sleep(IntSleep400); //400
                }
                Thread.Sleep(40); //40
            }
            Thread.Sleep(4000);
            Console.Clear();

            //Begin of game

            string strIntroTextName = "Ah, you're Finally here: " + Environment.UserName + "!\r\n";
            Ss.SpeakAsync(strIntroTextName);
            foreach (char cha in strIntroTextName)
            {
                Console.Write(cha);
                if (cha == ',' || cha == ':' || cha == '!' || cha == '?')
                {
                    Thread.Sleep(IntSleep400); //400
                }
                Thread.Sleep(40); //40
            }
            string strFilename = StrTxtLocation + "intro/intro.txt";

            string[] introText = File.ReadAllLines(strFilename);
            for (int i = 0; i < introText.Length; i++)
            {

                //Makes the TTS speak when int i is on 1, 3, 5, 7, 9, 11, 13 This way, it will speak at the same way as the text appears on the screen.
                //The location of the TTS changes  based on intIntroTTS
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 13)
                {
                    Ss.SpeakAsync(introText[i]);
                }


                string strIntroText = introText[i];
                for (int x = 0; x < strIntroText.Length; x++)
                {
                    Console.Write(strIntroText[x]);
                    if (strIntroText[x] == ',' || strIntroText[x] == '.' || strIntroText[x] == '?')
                    {
                        Thread.Sleep(IntSleep400); //400
                    }
                    Thread.Sleep(40); //40

                    //This had to be added to make line 8 of the text file (byte 7) in sync with the audio. Because the audio would else be interrupted.
                    if (i == 7 && x == 47)
                    {
                        Thread.Sleep(600); //600
                    }
                }
                Console.Write("\r\n");
                Thread.Sleep(IntSleep400); //400

            }
            Console.WriteLine("\r\n");
            if (!TimerThread.IsAlive)
            {
                TimerThread.Start();
            }
            bool firstRun = false;
            do
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("Ah, you're Finally here: " + Environment.UserName + "!");
                string strIntroText = File.ReadAllText(StrTxtLocation + "intro/intro.txt");
                Console.Write(strIntroText);

                if (firstRun)
                {
                    DrawBottom();
                    strUserStart = Console.ReadLine().ToLower();
                }
                else
                {
                    firstRun = true;
                }

                if (strUserStart == "start" || strUserStart == "exit")
                {
                    blnLoopQuestion = false;
                }
            } while (blnLoopQuestion);

            if (strUserStart == "start")
            {
                Room1();
            }
            else
            {
                Console.Clear();
                SpeakFile("intro/exit.txt");
                Environment.Exit(0);
            }
        }

        public static void MainMenuHelp()
        {
            Console.Clear();
            GetRandomConsoleColor();
            string strFilename = "files/help.txt";
            Console.WriteLine(File.ReadAllText(strFilename));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            UserInputs.BackToCurrentRoom();
        }

        public static void MainMenuOptions()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Press Esc to go back to Main Menu\r\n");
                Console.WriteLine("1.)\tToggle BGM(BackGroundMusic)");
                Cki = Console.ReadKey();
                string strCki = Cki.Key.ToString();
                switch (strCki)
                {
                    case "NumPad1":
                    case "D1":
                    {
                        BlnPlayMusic = !BlnPlayMusic;
                        break;
                    }
                    case "Escape":
                    {
                        UserInputs.BackToCurrentRoom();
                        break;
                    }
                }
            } while (Cki.Key.ToString() != "Escape");
        }

        public static void MainMenuCode()
        {
            Console.Clear();
            Console.WriteLine("Type the code here.\r\nLeave empty and press Enter to go back to Main Menu");
            StrAnswer = Console.ReadLine().ToLower();
                Debug.DebugMode();
                switch (StrAnswer)
                {
                    case "boss":
                    {
                        BlnBoss = true;
                        string strFilename = "files/mainmenucodes/BossEnabled.txt";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu();
                        break;
                    }
                    case "shop":
                    {
                        BlnShop = true;
                        string strFilename = "files/mainmenucodes/ShopEnabled.txt";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu();
                        break;
                    }
                    case "dlc":
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        break;
                    }
                    case "konami":
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter the Konami Code (START = ENTER)");
                        KonamiCode.CheckKonami_Code();
                        break;
                    }
                
            }
        }
        public static void MainMenuDlc()
        {
            Console.Clear();
            Console.WriteLine("If you want the extra DLC options, you can donate any amount of money to:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("paypal.me/NandoK ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Current available dlc is: Gray Background \r\nPress any key to continue.");
            Console.ReadKey();
        }
        public static void MainMenuExit()
        { exit:
            Console.WriteLine("Are you sure you want to exit.");
            if (Console.ReadLine().ToLower()== "yes")
            {
                Environment.Exit(0);
            }
            else if (Console.ReadLine().ToLower() == "no")
            {
                UserInputs.BackToCurrentRoom();
            }
            else
            {
                goto exit;
            }
        }
        public static void InGameMap()
        {
            Console.Clear();
            GetRandomConsoleColor();
            string strFilename = "files/menu/map/map2.txt";
            Console.WriteLine(File.ReadAllText(strFilename));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            UserInputs.BackToCurrentRoom();
        }
        //END OF MainMenu

        //BEGIN OF InGameMenu
        public static void InGameMenu()
        {
            if (CurrentRoom != StrInGameMenu)
            {
                InGameMenuTempRoom = CurrentRoom;
                CurrentRoom = StrInGameMenu;
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
        public static void Hud()
        {
            if (CurrentRoom == StrMainMenu || CurrentRoom == StrInGameMenu) return;

            string strZeroSpace = "";
            strZeroSpace = IntTimerSeconds < 10 ? "0" : "";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.CursorLeft = 54, Console.CursorTop = 0);
            Console.WriteLine("║\t   TIME:  {3}:{4}{0}\t  Current location:   {1}\tO═╦╗:\t{2}", IntTimerSeconds, CurrentRoom, IntKey, IntTimerMinutes, strZeroSpace);
            Console.SetCursorPosition(Console.CursorLeft = 54, Console.CursorTop = 1);
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Timer
        public static void TimerFunction()
        {
            do
            {
                do
                {
                    IntTimerSeconds -= 1;
                    IntCursorpositionLeft = Console.CursorLeft;
                    IntCursorpositionTop = Console.CursorTop;
                    Hud();
                    Console.SetCursorPosition(IntCursorpositionLeft, IntCursorpositionTop);
                    Thread.Sleep(1000);
                } while (IntTimerSeconds > 0);
                IntTimerSeconds = 60;
                IntTimerMinutes -= 1;
            }
            while (IntTimerMinutes > 0);

            GameOver();

        }
        //END OF HUD

        //BEGIN OF ROOMS
        public static void Room1()
        {

            CurrentRoom = StrRoom1;
            Console.Clear();
            if (!BlnRoom1Story)
            {
                //story
                string strFilename = StrTxtLocation + "Rooms/Room1/Room1.txt";
                string[] introText = File.ReadAllLines(strFilename);
                for (int i = 0; i < introText.Length; i++)
                {

                    switch (i)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 9:
                        case 13:
                            Ss.SpeakAsync(introText[i]);
                            break;
                        case 17:
                            Player.SoundLocation = StrTtsLocation + "ROOM1/room1-7.wav";
                            Player.Play();
                            break;
                        case 12:
                        case 15:
                            Console.Beep();
                            Console.Beep();
                            Console.Beep();
                            break;
                    }
                    string strIntroText = introText[i];
                    foreach (char cha in strIntroText)
                    {
                        Console.Write(cha);
                        if (cha == ',' || cha == '.' || cha == '?')
                        {
                            Thread.Sleep(IntSleep400); //400
                        }
                        Thread.Sleep(40); //40
                    }
                    Console.Write("\r\n");
                    Thread.Sleep(IntSleep400); //400

                }
                Thread.Sleep(1000);
                Console.Clear();
                BlnRoom1Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Rooms/Room1/Room1.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Room2()
        {
            CurrentRoom = StrRoom2;
            Console.Clear();
            if (!BlnRoom2Story)
            {
                //story
                BlnRoom2Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Rooms/Room2/Room2.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Room3()
        {
            CurrentRoom = StrRoom3;
            Console.Clear();
            if (!BlnRoom3Story)
            {
                //story
                BlnRoom3Story = true;
            }
            BackGroundPosition();

            Console.WriteLine(File.ReadAllText("files/Rooms/Room3/Room3.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Room4()
        {
            if (!BlnRoom4Story)
            {
                //story
                //story
                Console.Clear();
                SpeakFile("Rooms/Room4/Room4.txt");
                Thread.Sleep(1000);
                Console.Clear();
                BlnRoom4Story = true;
            }

            CurrentRoom = StrRoom4;
            Console.Clear();
            if (!BlnRoom4Story)
            {
                //story
                BlnRoom4Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Rooms/Room4/Room4.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }

        public static void Room5()
        {
            CurrentRoom = StrRoom5;
            Console.Clear();
            if (!BlnRoom5Story)
            {
                //story
                BlnRoom5Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Rooms/Room5/Room5.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Room6()
        {
            CurrentRoom = StrRoom6;
            Console.Clear();
            if (!BlnRoom6Story)
            {
                //story
                BlnRoom6Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Rooms/Room6/Room6.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Room7()
        {
            CurrentRoom = StrRoom7;
            Console.Clear();
            if (!BlnRoom7Story)
            {
                //story
                //story
                Console.Clear();
                SpeakFile("Rooms/BossRoom/Boss.txt");
                Thread.Sleep(1000);
                Console.Clear();
                BlnRoom7Story = true;
            }
            Console.WriteLine("BOSSROOM");
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Rooms/Room7/Room7.txt"));
            UserInputs.UserInput();
        }
        //END OF ROOMS

        //Background
        public static void BackGroundPosition()
        {
            if (CurrentRoom == StrRoom1)
            {
                Console.SetCursorPosition(48, 3);
                string[] background = File.ReadAllLines("files/backgrounds/BG Room1.txt");
                foreach (string bg in background)
                {
                    Console.CursorLeft = 48;
                    Console.Write(bg);
                    Console.WriteLine("");
                }
                Console.SetCursorPosition(0, 0);
            }
            else if (CurrentRoom == StrRoom2 || CurrentRoom == StrRoom3 || CurrentRoom == StrRoom5 || CurrentRoom == StrRoom6)
            {
                Console.SetCursorPosition(48, 3);
                string[] background = File.ReadAllLines("files/backgrounds/backgrounds2.txt");
                foreach (string bg in background)
                {
                    Console.CursorLeft = 48;
                    Console.Write(bg);
                    Console.WriteLine("");
                }
                Console.SetCursorPosition(0, 0);
            }
            else if (CurrentRoom == StrRoom4)
            {
                Console.SetCursorPosition(48, 3);
                string[] background = File.ReadAllLines("files/backgrounds/BGNoTree.txt");
                foreach (string bg in background)
                {
                    Console.CursorLeft = 48;
                    Console.Write(bg);
                    Console.WriteLine("");
                }
                Console.SetCursorPosition(0, 0);
            }
            else if (CurrentRoom == StrRoom7)
            {
                Console.SetCursorPosition(48, 3);
                string[] background = File.ReadAllLines("files/backgrounds/spongebob.txt");
                foreach (string bg in background)
                {
                    Console.CursorLeft = 48;
                    Console.Write(bg);
                    Console.WriteLine("");
                }
                Console.SetCursorPosition(0, 0);
            }
            else if (CurrentRoom == StrHall1 || CurrentRoom == StrHall2 || CurrentRoom == StrHall3 || CurrentRoom == StrHall4 || CurrentRoom == StrHall5 || CurrentRoom == StrHall6 || CurrentRoom == StrHall7 || 
                CurrentRoom == StrHall8 || CurrentRoom == StrHall9 || CurrentRoom == StrHall10 || CurrentRoom == StrHall12 || CurrentRoom == StrHall13 || CurrentRoom == StrHall14 )
            {
                Console.SetCursorPosition(48, 3);
                string[] background = File.ReadAllLines("files/backgrounds/backgrounds1.txt");
                foreach (string bg in background)
                {
                    Console.CursorLeft = 48;
                    Console.Write(bg);
                    Console.WriteLine("");
                }
                Console.SetCursorPosition(0, 0);
            }
            else if (CurrentRoom == StrHall11)
            {
                Console.SetCursorPosition(48, 3);
                string[] background = File.ReadAllLines("files/backgrounds/Base BG.txt");
                foreach (string bg in background)
                {
                    Console.CursorLeft = 48;
                    Console.Write(bg);
                    Console.WriteLine("");
                }
                Console.SetCursorPosition(0, 0);
            }
            else if (CurrentRoom == StrShop)
            {
                Console.SetCursorPosition(48, 3);
                string[] background = File.ReadAllLines("files/backgrounds/Shop.txt");
                foreach (string bg in background)
                {
                    Console.CursorLeft = 48;
                    Console.Write(bg);
                    Console.WriteLine("");
                }
                Console.SetCursorPosition(0, 0);
            }
        }

        //Walls
        public static void WallPosition(string x)
        {
            Console.Clear();
            Console.WriteLine("\r\n\r\n\r\n  Press any key to go back");
            x = x == "" ? "Nothing" : x;
            Console.SetCursorPosition(48, 3);
            string[] background = File.ReadAllLines("files/story/Walls/Wall1/Wall1.txt");
            foreach (string t in background)
            {
                Console.CursorLeft = 48;
                Console.Write(t);
                Console.WriteLine("");
            }
            Console.SetCursorPosition(48 + 34 - x.Length/2, 12);
            Console.Write(x);

            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
        }

        //BEGIN OF HALLS
        public static void Hall1()
        {
            CurrentRoom = StrHall1;
            Console.Clear();
            if (!BlnHall1Story)
            {
                //story
                BlnHall1Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall1.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();

        }
        public static void Hall2()
        {
            CurrentRoom = StrHall2;
            Console.Clear();
            if (!BlnHall2Story)
            {
                //story
                BlnHall2Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall2.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall3()
        {
            CurrentRoom = StrHall3;
            Console.Clear();
            if (!BlnHall3Story)
            {
                //story
                BlnHall3Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall3.txt"));
            UserInputs.UserInput();
            Errors.ErrorNotYetCreated();
        }
        public static void Hall4()
        {
            CurrentRoom = StrHall4;
            Console.Clear();
            if (!BlnHall4Story)
            {
                //story
                BlnHall4Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall4.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall5()
        {
            CurrentRoom = StrHall5;
            Console.Clear();
            if (!BlnHall5Story)
            {
                //story
                BlnHall5Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall5.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall6()
        {
            CurrentRoom = StrHall6;
            Console.Clear();
            if (!BlnHall6Story)
            {
                //story
                BlnHall6Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall6.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall7()
        {
            CurrentRoom = StrHall7;
            Console.Clear();
            if (!BlnHall7Story)
            {
                //story
                BlnHall7Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall7.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall8()
        {
            CurrentRoom = StrHall8;
            Console.Clear();
            if (!BlnHall8Story)
            {
                //story
                BlnHall8Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall8.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall9()
        {
            CurrentRoom = StrHall9;
            Console.Clear();
            if (!BlnHall9Story)
            {
                //story

                BlnHall9Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall9.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall10()
        {
            CurrentRoom = StrHall10;
            Console.Clear();
            if (!BlnHall10Story)
            {
                //story
                BlnHall10Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall10.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall11()
        {
            CurrentRoom = StrHall11;
            Console.Clear();
            if (!BlnHall11Story)
            {
                //story
                BlnHall11Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall11.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall12()
        {
            CurrentRoom = StrHall12;
            Console.Clear();
            if (!BlnHall12Story)
            {
                //story
                BlnHall12Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall12.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall13()
        {
            CurrentRoom = StrHall13;
            Console.Clear();
            if (!BlnHall13Story)
            {
                //story
                Console.Clear();
                SpeakFile("Halls/Hall13/Hall13.txt");
                Thread.Sleep(1000);
                Console.Clear();
                BlnHall13Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall13.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void Hall14()
        {
            CurrentRoom = StrHall14;
            Console.Clear();
            if (!BlnHall14Story)
            {
                //story
                Console.Clear();
                SpeakFile("Halls/Hall14/Hall14.txt");
                Thread.Sleep(4000);
                Console.Clear();
                BlnHall14Story = true;
            }
            BackGroundPosition();
            Console.WriteLine(File.ReadAllText("files/Halls/Hall14.txt"));
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
            Console.SetCursorPosition(0, 27);
            Console.WriteLine("════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 28);
        }

        //Random ConsoleColor Generator
        public static void GetRandomConsoleColor()
        {
            Array consoleColors = Enum.GetValues(typeof(ConsoleColor));
            OriginalForeGroundColor = Console.ForegroundColor;
            do
            {
                Console.ForegroundColor = (ConsoleColor)consoleColors.GetValue(RandomForeGround.Next(consoleColors.Length));
            } while (Console.ForegroundColor == Console.BackgroundColor || Console.ForegroundColor == OriginalForeGroundColor || Console.ForegroundColor == ConsoleColor.Gray || Console.ForegroundColor == ConsoleColor.DarkGray || Console.ForegroundColor == ConsoleColor.DarkRed || Console.ForegroundColor == ConsoleColor.DarkMagenta || Console.ForegroundColor == ConsoleColor.DarkYellow || Console.ForegroundColor == ConsoleColor.DarkBlue || Console.ForegroundColor == ConsoleColor.DarkGreen || Console.ForegroundColor == ConsoleColor.Blue || Console.ForegroundColor == ConsoleColor.DarkCyan);
            OriginalForeGroundColor = Console.ForegroundColor;
        }

        public static void Wallrun()
        {
            Console.Clear();
            Console.Write(".\r\n");
            Thread.Sleep(1000);
            Console.Write("..\r\n");
            Thread.Sleep(1000);
            Console.Write("...\r\n");
            Thread.Sleep(1000);
            IntTimerMinutes -= 5;
            Ss.SpeakAsync("you where unconscious for 5 minutes because tried to break a wall with your head. What where you even thinking?");

            foreach (char cha in "you where unconscious for 5 minutes because tried to break a wall with your head. What where you even thinking?")
            {
                Console.Write(cha);
                if (cha == ',' || cha == ':' || cha == '.' || cha == '!' || cha == '?')
                {
                    Thread.Sleep(IntSleep400); //400
                }
                Thread.Sleep(40); //40
            }

            Thread.Sleep(1000);
        }

        public static void SpeakFile(string i)
        {
            string strFilename = StrTxtLocation + i;
            string[] introText = File.ReadAllLines(strFilename);
            foreach (string strIntroText in introText)
            {
                Ss.SpeakAsync(strIntroText);
                foreach (char cha in strIntroText)
                {
                    Console.Write(cha);
                    if (cha == ',' || cha == ':' || cha == '.' || cha == '!' || cha == '?')
                    {
                        Thread.Sleep(IntSleep400); //400
                    }
                    Thread.Sleep(40); //40
                }
                Console.Write("\r\n");
                Thread.Sleep(IntSleep400); //400
            }
        }


        //BGM
        public static void Bgm()
        {
            do
            {
                if (CurrentRoom != StrMainMenu && CurrentRoom != string.Empty && BlnPlayMusic /*&& blnBGMCancel ==false*/) //BGM In Game
                {
                    do
                    {
                        string[] strReadSong = File.ReadAllLines(BgmFolder + BgmFileTone);
                        string[] strReadDuration = File.ReadAllLines(BgmFolder + BgmFileDuration);
                        IntSongCounter = 0;
                        if (CurrentRoom != string.Empty && CurrentRoom != StrMainMenu)

                            do
                            {
                                IntReadSong = Convert.ToInt32(strReadSong[IntSongCounter]);
                                IntReadDuration = Convert.ToInt32(strReadDuration[IntSongCounter]);
                                IntSongCounter++;
                                if (IntReadSong != 0)
                                {
                                    Console.Beep(IntReadSong, IntReadDuration);
                                }
                                else
                                {
                                    Thread.Sleep(IntReadDuration);
                                }
                            } while (IntSongCounter < strReadSong.Length && CurrentRoom != StrMainMenu && BlnPlayMusic /*&& blnBGMCancel == false*/);
                        IntSongCounter = 0;
                    } while (CurrentRoom != StrMainMenu && BlnPlayMusic /*&& blnBGMCancel == false*/);
                }
                else if (CurrentRoom != string.Empty && CurrentRoom == StrMainMenu && BlnPlayMusic /*&& blnBGMCancel == false*/) //BGM Main Menu
                {
                    do
                    {
                        string[] strReadSong = File.ReadAllLines(BgmFolder + "MainMenu/" + BgmFileTone);
                        string[] strReadDuration = File.ReadAllLines(BgmFolder + "MainMenu/" + BgmFileDuration);
                        IntSongCounter = 0;
                        do
                        {
                            IntReadSong = Convert.ToInt32(strReadSong[IntSongCounter]);
                            IntReadDuration = Convert.ToInt32(strReadDuration[IntSongCounter]);
                            IntSongCounter++;
                            if (IntReadSong != 0)
                            {
                                Console.Beep(IntReadSong, IntReadDuration);
                            }
                            else
                            {
                                Thread.Sleep(IntReadDuration);
                            }
                        } while (IntSongCounter < strReadSong.Length && CurrentRoom == StrMainMenu && BlnPlayMusic /*&& blnBGMCancel == false*/);
                        IntSongCounter = 0;
                    } while (CurrentRoom == StrMainMenu && BlnPlayMusic /*&& blnBGMCancel == false*/);
                }
            } while (true);
        }

        //GAMEOVER
        public static void GameOver()
        {
            Console.Clear();
            SpeakFile("Rooms/Timer/Timer.txt");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
