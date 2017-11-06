using System;
using System.Threading;
using System.IO;
using System.Speech.Synthesis;

namespace Subwaj
{

    class Program
    {
        public static string StrAnswer = string.Empty;
        public static int IntCode;



        public static int IntKey;
        //Here we will place the public static variables
        public static Random RandomForeGround = new Random();  //Gets used for random foregroundcolor.
        public static ConsoleColor OriginalForeGroundColor;     //Sets the old foreground to a variable to make sure it isn't the same.

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
        public static SpeechSynthesizer _SS = new SpeechSynthesizer();
        public static void voice()
        {
            

        }

        //boolean's for code menu
        public static bool BlnBoss = false;
        public static bool BlnShop = false;
        public static bool BlnDebug = false;

        //Story read (so you don't get the story every time you go into the room)
        public static bool BlnRoom1Story = false;
        public static bool BlnRoom2Story = false;
        public static bool BlnRoom3Story = false;
        public static bool BlnRoom4Story = false;
        public static bool BlnRoom5Story = false;
        public static bool BlnRoom6Story = false;
        public static bool BlnRoom7Story = false;
        public static bool BlnHall1Story = false;
        public static bool BlnHall2Story = false;
        public static bool BlnHall3Story = false;
        public static bool BlnHall4Story = false;
        public static bool BlnHall5Story = false;
        public static bool BlnHall6Story = false;
        public static bool BlnHall7Story = false;
        public static bool BlnHall8Story = false;
        public static bool BlnHall9Story = false;
        public static bool BlnHall10Story = false;
        public static bool BlnHall11Story = false;
        public static bool BlnHall12Story = false;
        public static bool BlnHall13Story = false;
        public static bool BlnHall14Story = false;
        public static bool BlnPuzzle1     = false;
        public static bool BlnPuzzle2     = false;
        public static bool BlnPuzzle3     = false;
        public static bool BlnPuzzle4     = false;


        //sleep
        public static int IntSleep400 = 500; //400

        public static void Main(string[] args)
        {
            Console.Title = "NOT A GAME";
            voice();
            //Loops the program
            Console.WindowWidth = 120;
            Console.WindowHeight = 30;
            Console.CursorVisible = false;

            _SS.Rate = 1;
            _SS.Volume = 100;

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
            }
            while (true);
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
            string strUserStart;
            bool blnLoopQuestion = true;
            

            string strIntroTextName = "Ah, you're Finally here: " + Environment.UserName + "!\r\n";
            _SS.SpeakAsync(strIntroTextName);
            for (int x = 0; x < strIntroTextName.Length; x++)
            {
                Console.Write(strIntroTextName[x]);
                if (strIntroTextName[x] == ',' || strIntroTextName[x] == ':')
                {
                    Thread.Sleep(IntSleep400); //400
                }
                Thread.Sleep(40); //40

            }
            string strFilename = StrTxtLocation + "intro/intro.txt";

            int intIntroTts = 1; //Used to count the file

            string[] IntroText = File.ReadAllLines(strFilename);
            for (int i = 0; i < IntroText.Length; i++)
            {

                //Makes the TTS speak when int i is on 1, 3, 5, 7, 9, 11, 13 This way, it will speak at the same way as the text appears on the screen.
                //The location of the TTS changes  based on intIntroTTS
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 13)
                {
                    intIntroTts += 1;
                    _SS.SpeakAsync(IntroText[i]);
                }


                string strIntroText = IntroText[i];
                for (int x = 0; x < strIntroText.Length; x++)
                {
                    Console.Write(strIntroText[x]);
                    if (strIntroText[x] == ',')
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
            if (TimerThread.IsAlive == false)
            {
                TimerThread.Start();
            }
            Console.Clear();
            do
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Thread.Sleep(50);
                Console.WriteLine("Ah, you're Finally here: " + Environment.UserName + "!\r\n");
                Console.WriteLine(File.ReadAllText(StrTxtLocation + "intro/intro.txt"));
                Thread.Sleep(50);

                DrawBottom();


                strUserStart = Console.ReadLine().ToLower();
                if (strUserStart == "start" || strUserStart == "exit")
                {
                    blnLoopQuestion = false;
                }
            } while (blnLoopQuestion == true);

            if (strUserStart == "start")
            {
                ROOM1();
            }
            else
            {
                Console.Clear();
                strFilename = StrTxtLocation + "intro/exit.txt";
                IntroText = File.ReadAllLines(strFilename);
                intIntroTts = 0;
                for (int i = 0; i < IntroText.Length; i++)
                {
                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 13)
                    {
                        intIntroTts += 1;
                        _SS.SpeakAsync(IntroText[i]);
                    }

                    string strIntroText = IntroText[i];
                    for (int x = 0; x < strIntroText.Length; x++)
                    {

                        Console.Write(strIntroText[x]);
                        if (strIntroText[x] == ',')
                        {
                            Thread.Sleep(IntSleep400);
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
                            if (BlnPlayMusic == true)
                            {
                                BlnPlayMusic = false;
                            }
                            else
                            {
                                BlnPlayMusic = true;
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
                while (IntCode == 0)
                {
                     StrAnswer = Console.ReadLine().ToLower();
                    Debug.debug();
                    if (StrAnswer == "boss" || StrAnswer == "BOSS" || StrAnswer == "Boss")
                    {
                        BlnBoss = true;
                        string strFilename = "files/mainmenucodes/BossEnabled.txt";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu();
                    }
                    else if (StrAnswer == "shop" || StrAnswer == "SHOP" || StrAnswer == "Shop")
                    {
                        BlnShop = true;
                        string strFilename = "files/mainmenucodes/ShopEnabled.txt";
                        Console.WriteLine(File.ReadAllText(strFilename));
                        Thread.Sleep(1000);
                        Console.Clear();
                        MainMenu();
                    }
                    else if (StrAnswer == "dlc")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }
                    
                    else if (StrAnswer == "konami" || StrAnswer == "KONAMI" || StrAnswer == "Konami")
                    {
                        IntCode = 1;
                    }
                    else
                    {
                        MainMenu();
                    }
                }
                while (IntCode == 0);
                Console.Clear();
                Console.WriteLine("Please enter the Konami Code (START = ENTER)");
                Konami_Code.CheckKonami_Code();
            }
            while (true);

        }
        public static void MainMenuDlc()
        {
            Console.Clear();
            Console.WriteLine("If you want the extra DLC options, you can donate any amount of money to:");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("paypal.me/NandoK");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Current available dlc is: Gray Background \r\nPress any key to continue.");
            Console.ReadKey();
        }
        public static void MainMenuExit()
        {
            Environment.Exit(0);
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
        public static void HUD()
        {
            if (CurrentRoom != StrMainMenu && CurrentRoom != StrInGameMenu)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(Console.CursorLeft = 54, Console.CursorTop = 0);
                Console.WriteLine("║\t   TIME:  {3}:{0}\t  Current location:   {1}\tO═╦╗:\t{2}", IntTimerSeconds, CurrentRoom, IntKey, IntTimerMinutes);
                Console.SetCursorPosition(Console.CursorLeft = 54, Console.CursorTop = 1);
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════");
                Console.ForegroundColor = ConsoleColor.White;
            }
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
                    HUD();
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
        public static void ROOM1()
        {

            CurrentRoom = StrRoom1;
            Console.Clear();
            if (BlnRoom1Story == false)
            {
                //story
                string strFilename = StrTxtLocation + "Rooms/Room1/Room1.txt";
                string[] IntroText = File.ReadAllLines(strFilename);
                int intIntroTts = 0; //Used to count the file
                for (int i = 0; i < IntroText.Length; i++)
                {

                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 13 )
                    {
                        intIntroTts += 1;
                        _SS.SpeakAsync(IntroText[i]);
                    }
                    else if (i == 17)
                    {
                        Player.SoundLocation = StrTtsLocation + "ROOM1/room1-7.wav";
                        Player.Play();
                    }
                    if (i == 12 || i == 15)
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
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds2.txt"));
            Console.WriteLine(File.ReadAllText("files/Rooms/Room1/Room1.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM2()
        {
            CurrentRoom = StrRoom2;
            Console.Clear();
            if (BlnRoom2Story == false)
            {
                //story
                BlnRoom2Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds2.txt"));
            Console.WriteLine(File.ReadAllText("files/Rooms/Room2/Room2.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM3()
        {
            CurrentRoom = StrRoom3;
            Console.Clear();
            if (BlnRoom3Story == false)
            {
                //story
                BlnRoom3Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds2.txt"));
            Console.WriteLine(File.ReadAllText("files/Rooms/Room3/Room3.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM4()
        {
            if (BlnRoom4Story == false)
            {
                //story
                //story
                Console.Clear();
                string strFilename = StrTxtLocation + "Rooms/Room4/Room4.txt";
                string[] IntroText = File.ReadAllLines(strFilename);
                for (int x = 0; x < IntroText.Length; x++)
                {
                    string strIntroText = IntroText[x];
                    _SS.SpeakAsync(strIntroText);
                    for (int z = 0; z < strIntroText.Length; z++)
                    {
                        Console.Write(strIntroText[z]);
                        if (strIntroText[z] == ',')
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
                BlnRoom4Story = true;
            }

            CurrentRoom = StrRoom4;
            Console.Clear();
            if (BlnRoom4Story == false)
            {
                //story
                BlnRoom4Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds2.txt"));
            Console.WriteLine(File.ReadAllText("files/Rooms/Room4/Room4.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM5()
        {
            CurrentRoom = StrRoom5;
            Console.Clear();
            if (BlnRoom5Story == false)
            {
                //story
                BlnRoom5Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds2.txt"));
            Console.WriteLine(File.ReadAllText("files/Rooms/Room5/Room5.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM6()
        {
            CurrentRoom = StrRoom6;
            Console.Clear();
            if (BlnRoom6Story == false)
            {
                //story
                BlnRoom6Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds2.txt"));
            Console.WriteLine(File.ReadAllText("files/Rooms/Room6/Room6.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void ROOM7()
        {
            if (BlnRoom7Story == false)
            {
                //story
                //story
                Console.Clear();
                string strFilename = StrTxtLocation + "Rooms/BossRoom/Boss.txt";
                string[] IntroText = File.ReadAllLines(strFilename);
                for (int x = 0; x < IntroText.Length; x++)
                {
                    string strIntroText = IntroText[x];
                    _SS.SpeakAsync(strIntroText);
                    for (int z = 0; z < strIntroText.Length; z++)
                    {
                        Console.Write(strIntroText[z]);
                        if (strIntroText[z] == ',')
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
                BlnRoom7Story = true;
            }

            CurrentRoom = StrRoom7;
            Console.Clear();
            if (BlnRoom7Story == false)
            {
                //story
                BlnRoom7Story = true;
            }
            Console.WriteLine("BOSSROOM");
            Console.WriteLine(File.ReadAllText("files/Rooms/Room7/Room7.txt"));
            UserInputs.UserInput();
        }
        //END OF ROOMS

        //BEGIN OF HALLS
        public static void HALL1()
        {
            CurrentRoom = StrHall1;
            Console.Clear();
            if (BlnHall1Story == false)
            {
                //story
                BlnHall1Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall1.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();

        }
        public static void HALL2()
        {
            CurrentRoom = StrHall2;
            Console.Clear();

            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall2.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL3()
        {
            CurrentRoom = StrHall3;
            Console.Clear();
            if (BlnHall3Story == false)
            {
                //story
                BlnHall3Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall3.txt"));
            UserInputs.UserInput();
            Errors.ErrorNotYetCreated();
        }
        public static void HALL4()
        {
            CurrentRoom = StrHall4;
            Console.Clear();
            if (BlnHall4Story == false)
            {
                //story
                BlnHall4Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall4.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL5()
        {
            CurrentRoom = StrHall5;
            Console.Clear();
            if (BlnHall5Story == false)
            {
                //story
                BlnHall5Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall5.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL6()
        {
            CurrentRoom = StrHall6;
            Console.Clear();
            if (BlnHall6Story == false)
            {
                //story
                BlnHall6Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall6.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL7()
        {
            CurrentRoom = StrHall7;
            Console.Clear();
            if (BlnHall7Story == false)
            {
                //story
                BlnHall7Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall7.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL8()
        {
            CurrentRoom = StrHall8;
            Console.Clear();
            if (BlnHall8Story == false)
            {
                //story
                BlnHall8Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall8.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL9()
        {
            CurrentRoom = StrHall9;
            Console.Clear();
            if (BlnHall9Story == false)
            {
                //story

                BlnHall9Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall9.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL10()
        {
            CurrentRoom = StrHall10;
            Console.Clear();
            if (BlnHall10Story == false)
            {
                //story
                BlnHall10Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall10.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL11()
        {
            CurrentRoom = StrHall11;
            Console.Clear();
            if (BlnHall11Story == false)
            {
                //story
                BlnHall11Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall11.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL12()
        {
            CurrentRoom = StrHall12;
            Console.Clear();
            if (BlnHall12Story == false)
            {
                //story
                BlnHall12Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall12.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL13()
        {
            if (BlnHall13Story == false)
            {
                //story
                //story
                Console.Clear();
                string strFilename = StrTxtLocation + "Halls/Hall13/Hall13.txt";
                string[] IntroText = File.ReadAllLines(strFilename);
                for (int x = 0; x < IntroText.Length; x++)
                {
                    string strIntroText = IntroText[x];
                    _SS.SpeakAsync(strIntroText);
                    for (int z = 0; z < strIntroText.Length; z++)
                    {
                        Console.Write(strIntroText[z]);
                        if (strIntroText[z] == ',')
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
                BlnHall13Story = true;
            }

            CurrentRoom = StrHall13;
            Console.Clear();
            if (BlnHall13Story == false)
            {
                //story
                BlnHall13Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
            Console.WriteLine(File.ReadAllText("files/Halls/Hall13.txt"));
            UserInputs.UserInput();
            Errors.ErrorOutOfBounds();
        }
        public static void HALL14()
        {
            if (BlnHall14Story == false)
            {
                //story
                //story
                Console.Clear();
                string strFilename = StrTxtLocation + "Halls/Hall14/Hall14.txt";
                string[] IntroText = File.ReadAllLines(strFilename);
                for (int x = 0; x < IntroText.Length; x++)
                {
                    string strIntroText = IntroText[x];
                    _SS.SpeakAsync(strIntroText);
                    for (int z = 0; z < strIntroText.Length; z++)
                    {
                        Console.Write(strIntroText[z]);
                        if (strIntroText[z] == ',')
                        {
                            Thread.Sleep(IntSleep400); //400
                        }
                        Thread.Sleep(40); //40
                    }
                    Console.Write("\r\n");
                    Thread.Sleep(IntSleep400); //400

                }
                Thread.Sleep(4000);
                Console.Clear();
                BlnHall14Story = true;
            }

            CurrentRoom = StrHall14;
            Console.Clear();
            if (BlnHall14Story == false)
            {
                //story
                BlnHall14Story = true;
            }
            Console.WriteLine(File.ReadAllText("files/backgrounds/backgrounds1.txt"));
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
            Console.SetCursorPosition(Console.CursorLeft, 27);
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

        //BGM
        public static void Bgm()
        {
            do
            {
                if (CurrentRoom != StrMainMenu && CurrentRoom != string.Empty && BlnPlayMusic == true /*&& blnBGMCancel ==false*/) //BGM In Game
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
                            } while (IntSongCounter < strReadSong.Length && CurrentRoom != StrMainMenu && BlnPlayMusic == true /*&& blnBGMCancel == false*/);
                        IntSongCounter = 0;
                    } while (CurrentRoom != StrMainMenu && BlnPlayMusic == true /*&& blnBGMCancel == false*/);
                }
                else if (CurrentRoom != string.Empty && CurrentRoom == StrMainMenu && BlnPlayMusic == true /*&& blnBGMCancel == false*/) //BGM Main Menu
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
                        } while (IntSongCounter < strReadSong.Length && CurrentRoom == StrMainMenu && BlnPlayMusic == true /*&& blnBGMCancel == false*/);
                        IntSongCounter = 0;
                    } while (CurrentRoom == StrMainMenu && BlnPlayMusic == true /*&& blnBGMCancel == false*/);
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
