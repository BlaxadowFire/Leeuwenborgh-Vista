using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

/*
 * https://msdn.microsoft.com/nl-nl/library/4fe3hdb1(v=vs.110).aspx
 * https://msdn.microsoft.com/en-us/library/471w8d85.aspx
 * 
 */


/*In excel 
 * A1 = "Console.Beep("
 * B1 = "Frequention"
 * C1 = ", "
 * D1 = "Duration"
 * E1 = ");"
 */



namespace ConsoleBeep_Songs
{
    class Program
    {
        public static int REST = 0;
        public static int GbelowC = 196;
        public static int A = 220;
        public static int Asharp = 234;
        public static int B = 248;
        public static int C = 262;
        public static int Csharp = 278;
        public static int D = 294;
        public static int Dsharp = 312;
        public static int E = 330;
        public static int F = 350;
        public static int Fsharp = 370;
        public static int G = 392;
        public static int Gsharp = 418;
        public static int intPlay = 37;

        public static int intDuration = 500;
        public static int intOctave = 1;
        public static string strSong;
        public static string strLastPlay;
        public static bool blnFirstRun = true;

        public static int intLastPlay;

        public static int intReadSong;
        public static int intReadDuration;
        public static int intSongCounter;


        public static string strFileName = "Tone.txt";
        public static string strFileSpace = "/Song/";
        public static string strFileDuration = "Duration.txt";
        public static string strFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);



        static void Main()
        {
            ConsoleKeyInfo cki;
            Console.Title = "Keyboard";
            if (blnFirstRun == true)
            {

                //Console.TreatControlCAsInput = true;

                Console.WriteLine("Type \"?\" for help");
                Console.WriteLine("Select Song");
                Console.WriteLine("-.)\tPlay From File\r\n+.)\tKeyboard\r\n1.)\tMario Theme\r\n2.)\tTetris Theme\r\n3.)\tImperial March\r\n4.)\tMission Impossible");
                Console.WriteLine("5.)\tBest song ever(Sightly off tune)\r\n6.)\tSong of Time\r\n7.)\tSong of Storms\r\n8.)\tAttack on Titan\r\n9.)\tMary had a little lamb\r\n10.)\tHe was a pirate");
                Console.WriteLine("11.)\tMortal Kombat\r\n12.)\tDarude Sandstorm");
                strSong = Console.ReadLine();
                Console.Clear();
                blnFirstRun = false;
            }


            //Info
            if (strSong == "?")
            {
                if (!Directory.Exists(strFileLocation + strFileSpace))
                {
                    Directory.CreateDirectory(strFileLocation + strFileSpace);
                }
                File.WriteAllText(strFileLocation + strFileSpace + "Help.txt", "/=====\\_/=====\\\r\n|Nando _ Kools|\r\n\\=====/ \\=====/\r\n\r\nMain screen:\r\n\r\nyou can enter one of the numbers to start playing a song.\r\nIf you press \"+\" (Refered to as keyboard) you are able to play your own music.\r\nIf you press \"-\" you are able to listen to the music that is in the same folder as this file.\r\n\r\nKeyboard:\r\n\r\nWith \"ASDFGHJ\" you can play the white keys of a keyboard.\r\nWith \"WRTUI\" you can play the black keys of a keyboard. (These keys have been chosen because of their relative white keys positions.)\r\nWith the keys \"+\" en \"-\" You can change the lengt of the note. \"+\" is longer and \"-\" is shorter. (This is done by steps of 50 milleseconds)\r\nWith the keys \"*\" and \"/\" you can change the octave. \"*\" is higher and \"/\" is lower.\r\nWith \"Esc\" you can return to the main screen.\r\n\r\nMaking/Saving music:\r\n\r\nWhen you are in Keyboard, you can use the \"Spacebar\" to save the last note you played. It will be stored in a file called \"Tone.txt\" and can be found in the same folder as this help file.\r\nWhen you are in Keyboard, you can use the \"Enter\" to create a rest in your music. (You need to save it with \"Spacebar\")\r\nYou can use this to create small pauses in between your notes.\r\n\r\nFAQ:\r\n\r\nQ|Why is the duration default 500?\r\nA|This means it is 500milliseconds. That means 0.5 or 1/2 seconds.\r\n |\r\nQ|I want to Make a new song/keep the song I made.\r\nA|The files Tone.txt and Duration.txt are the files that store the data to play the song. You can create a new folder, give it the name of your song, and keep the files there. If you want to listen to that song again, just copy them back to the Song folder.\r\n |\r\nQ|Where are the songs stored?\r\nA|The songs are stored in a folder called Song. This folder can be found on your desktop.\r\n |\r\nQ|I can't find the Song folder on my desktop.\r\nA|If the folder doesn't exist, you can make it youself, or press space when you are in Keyboard.\r\n |\r\nQ|I accidentally removed the Song folder, can I retreive the song I made?\r\nA|If the song was in that folder, you can't.\r\n |\r\nQ|I made a song, but it has a low frequency tone in it.\r\nA|This is what happens when you don't press any button before pressing \"Spacebar\" you can recognise it in Tone.txt as number '37'.\r\n |\r\nQ|Can I edit my stored songs?\r\nA|Yes you can, in Tone.txt you fill find the Frequency of the tone. You can change this frequency manually. The same applies for the duration which can be found in Duration.txt\r\n |IMPORTANT!!! If you delete any of the tones, make sure to delete the duration as well! Same goes vice versa! (Same goes for adding Tones)\r\n |\r\nQ|What is the easiest way to edit the Songs manually?\r\nA|The easiest way is to open Excel (Or any other speadsheet software) And to copy the frequency and tone to the grid. This way, it is easy to change. When you are dont, just copy the value's back to the corrosponding file.\r\n\r\nIf you have any questions left, please send an e-mail to nando.kools@hotmail.com and I will see if I can answer your question.\r\nA copy of this file can be found on http://bladadowfire.ddns.net/Codes/KeyboardHelp/Help.txt");
                Console.Write("A help file has been made in ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(strFileLocation + "\\Song\\Help.txt");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }

            //Play self
            else if (strSong == "+")
            {
                Console.Title = "Keyboard";
                do
                {
                    Console.Clear();
                    Console.WriteLine("A# = W, C# = R, D# = T, F# = U, G# = I\r\n");
                    Console.WriteLine("A = A, B = S, C = D, D = F, E = G, F = H, G = J");
                    Console.WriteLine("Octave: {0}\t\tDuration: {1}", intOctave, intDuration);
                    Console.WriteLine("");
                    cki = Console.ReadKey();
                    Console.Clear();
                    string strPlay = cki.Key.ToString();
                    Program.Play(strPlay);
                }
                while (true);
            }

            //Play Song From File
            else if (strSong == "-")
            {
                Program.PlaySong();
            }

            //Mario
            else if (strSong == "1")
            {//Mario
                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
            }

            //Tetris
            else if (strSong == "2")
            {//Tetris
                Console.Beep(658, 125);
                Console.Beep(1320, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 250);
                Console.Beep(1320, 125);
                Console.Beep(1188, 125);
                Console.Beep(1056, 250);
                Console.Beep(990, 250);
                Console.Beep(880, 500);
                Console.Beep(880, 250);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 750);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                Thread.Sleep(250);
                Console.Beep(1188, 500);
                Console.Beep(1408, 250);
                Console.Beep(1760, 500);
                Console.Beep(1584, 250);
                Console.Beep(1408, 250);
                Console.Beep(1320, 750);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                Thread.Sleep(500);
                Console.Beep(1320, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 250);
                Console.Beep(1320, 125);
                Console.Beep(1188, 125);
                Console.Beep(1056, 250);
                Console.Beep(990, 250);
                Console.Beep(880, 500);
                Console.Beep(880, 250);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 750);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                Thread.Sleep(250);
                Console.Beep(1188, 500);
                Console.Beep(1408, 250);
                Console.Beep(1760, 500);
                Console.Beep(1584, 250);
                Console.Beep(1408, 250);
                Console.Beep(1320, 750);
                Console.Beep(1056, 250);
                Console.Beep(1320, 500);
                Console.Beep(1188, 250);
                Console.Beep(1056, 250);
                Console.Beep(990, 500);
                Console.Beep(990, 250);
                Console.Beep(1056, 250);
                Console.Beep(1188, 500);
                Console.Beep(1320, 500);
                Console.Beep(1056, 500);
                Console.Beep(880, 500);
                Console.Beep(880, 500);
                Thread.Sleep(500);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 1000);
                Console.Beep(440, 1000);
                Console.Beep(419, 1000);
                Console.Beep(495, 1000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 500);
                Console.Beep(660, 500);
                Console.Beep(880, 1000);
                Console.Beep(838, 2000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 1000);
                Console.Beep(440, 1000);
                Console.Beep(419, 1000);
                Console.Beep(495, 1000);
                Console.Beep(660, 1000);
                Console.Beep(528, 1000);
                Console.Beep(594, 1000);
                Console.Beep(495, 1000);
                Console.Beep(528, 500);
                Console.Beep(660, 500);
                Console.Beep(880, 1000);
                Console.Beep(838, 2000);
            }

            //Imperial March
            else if (strSong == "3")
            {//Imerial March
                Console.Beep(440, 500);
                Console.Beep(440, 500);
                Console.Beep(440, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 1000);
                Console.Beep(659, 500);
                Console.Beep(659, 500);
                Console.Beep(659, 500);
                Console.Beep(698, 350);
                Console.Beep(523, 150);
                Console.Beep(415, 500);
                Console.Beep(349, 350);
                Console.Beep(523, 150);
                Console.Beep(440, 1000);
            }

            //Mission Impossible
            else if (strSong == "4")
            {
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Thread.Sleep(300);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(932, 150);
                Thread.Sleep(150);
                Console.Beep(1047, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(699, 150);
                Thread.Sleep(150);
                Console.Beep(740, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(932, 150);
                Thread.Sleep(150);
                Console.Beep(1047, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(699, 150);
                Thread.Sleep(150);
                Console.Beep(740, 150);
                Thread.Sleep(150);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(587, 1200);
                Thread.Sleep(75);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(554, 1200);
                Thread.Sleep(75);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(523, 1200);
                Thread.Sleep(150);
                Console.Beep(466, 150);
                Console.Beep(523, 150);
            }

            //Rickroll
            else if (strSong == "5")
            {

                Console.Beep(450, 110);
                Console.Beep(500, 110);
                Console.Beep(550, 110);
                Console.Beep(450, 110);
                Console.Beep(675, 200);
                Thread.Sleep(150);
                Console.Beep(675, 200);
                Console.Beep(600, 300);
                Console.Beep(450, 110);
                Console.Beep(500, 110);
                Console.Beep(550, 110);
                Console.Beep(450, 110);
                Console.Beep(600, 200);
                Console.Beep(600, 200);
                Console.Beep(550, 300);
                Console.Beep(525, 110);
                Console.Beep(450, 300);
                Console.Beep(450, 110);
                Console.Beep(500, 110);
                Console.Beep(550, 110);
                Console.Beep(450, 110);
                Console.Beep(500, 400);
                Console.Beep(600, 300);
                Console.Beep(500, 400);
                Console.Beep(475, 200);
                Console.Beep(450, 200);
                Console.Beep(400, 200);
                Console.Beep(600, 500);
                Console.Beep(525, 500);
                Console.Beep(450, 110);
                Console.Beep(500, 110);
                Console.Beep(550, 110);
                Console.Beep(450, 110);
                Console.Beep(675, 200);
                Console.Beep(675, 200);
                Console.Beep(600, 300);
                Console.Beep(450, 110);
                Console.Beep(500, 110);
                Console.Beep(550, 110);
                Console.Beep(450, 110);
                Console.Beep(800, 200);
                Console.Beep(500, 200);
                Console.Beep(550, 300);
                Console.Beep(525, 110);
                Console.Beep(450, 300);
                Console.Beep(450, 110);
                Console.Beep(500, 110);
                Console.Beep(550, 110);
                Console.Beep(450, 110);
                Console.Beep(500, 400);
                Console.Beep(600, 300);
                Console.Beep(500, 400);
                Console.Beep(475, 200);
                Console.Beep(450, 200);
                Console.Beep(400, 200);
                Console.Beep(600, 500);
                Console.Beep(525, 500);
            }

            //Song of Time
            else if (strSong == "6")
            {//Song of Time
                Console.Beep(880, 500);
                Console.Beep(587, 1000);
                Console.Beep(698, 500);
                Console.Beep(880, 500);
                Console.Beep(587, 1000);
                Console.Beep(698, 500);
                Console.Beep(880, 500);
                Console.Beep(1046, 250);
                Console.Beep(987, 500);
                Console.Beep(783, 500);
                Console.Beep(687, 250);
                Console.Beep(783, 250);
                Console.Beep(880, 500);
                Console.Beep(587, 500);
                Console.Beep(523, 250);
                Console.Beep(659, 250);
                Console.Beep(587, 750);
            }

            //Song of Storms
            else if (strSong == "7")
            {//Song of Storms
                Console.Beep(A, 500);
                Console.Beep(E, 500);
                Console.Beep(A*2, 1000);

                Console.Beep(A, 500);
                Console.Beep(E, 500);
                Console.Beep(A*2, 1000);

                Console.Beep(B*2, 500);
                Console.Beep(C*2, 300);
                Console.Beep(B*2, 500);
                Console.Beep(C*2, 300);
                Console.Beep(B*2, 500);
                Console.Beep(G, 300);
                Console.Beep(E, 1000);

                Console.Beep(E, 300);
                Console.Beep(A, 500);
                Console.Beep(A, 500);
                Console.Beep(C, 300);
                Console.Beep(E, 1000);


                Console.Beep(E, 300);
                Console.Beep(A, 500);
                Console.Beep(C, 500);
                Console.Beep(D, 300);
                Console.Beep(B, 1000);
            }

            //Attack on Titan
            else if (strSong == "8")
            {//Attack on Titan
                Console.Beep(D, 200);
                Console.Beep(D, 200);
                Console.Beep(F, 300);
                Thread.Sleep(150);
                Console.Beep(E, 200);
                Console.Beep(C, 200);
                Console.Beep(C, 200);
                Console.Beep(D, 300);
                Thread.Sleep(150);
                Console.Beep(D, 200);
                Console.Beep(F, 200);
                Console.Beep(E, 300);
                Console.Beep(C, 500);
            }
            
            //Mary had a little lamb
            else if (strSong == "9")
            {
                Console.Beep(330, 250);
                Console.Beep(330, 250);
                Console.Beep(294, 250);
                Console.Beep(262, 250);
                Console.Beep(294, 250);
                Console.Beep(330, 250);
                Console.Beep(330, 250);
                Console.Beep(330, 250);
                Console.Beep(294, 250);
                Console.Beep(294, 250);
                Console.Beep(294, 250);
                Console.Beep(330, 250);
                Console.Beep(330, 250);
                Console.Beep(330, 250);
                Console.Beep(330, 250);
                Console.Beep(294, 250);
                Console.Beep(262, 250);
                Console.Beep(294, 250);
                Console.Beep(330, 250);
                Console.Beep(330, 250);
                Console.Beep(330, 250);
                Console.Beep(330, 250);
                Console.Beep(294, 250);
                Console.Beep(294, 250);
                Console.Beep(330, 250);
                Console.Beep(294, 250);
            }

            //He was a pirate
            else if (strSong == "10")
            {
                Console.Beep(220, 200);
                Console.Beep(262, 200);
                Console.Beep(294, 400);
                Console.Beep(294, 400);
                Console.Beep(294, 200);
                Console.Beep(330, 200);
                Console.Beep(350, 400);
                Console.Beep(350, 400);
                Console.Beep(350, 200);
                Console.Beep(392, 200);
                Console.Beep(330, 400);
                Console.Beep(330, 400);
                Console.Beep(294, 200);
                Console.Beep(262, 200);
                Console.Beep(262, 200);
                Console.Beep(294, 200);
                Console.Beep(294, 400);

            }

            //Mortal Kombat
            else if (strSong == "11")
            {//Mortal Kombat
                Console.Beep(440, 200);
                Console.Beep(440, 200);
                Console.Beep(524, 200);
                Console.Beep(440, 200);
                Console.Beep(588, 200);
                Console.Beep(440, 200);
                Console.Beep(660, 200);
                Console.Beep(588, 200);
                Console.Beep(524, 200);
                Console.Beep(524, 200);
                Console.Beep(660, 200);
                Console.Beep(524, 200);
                Console.Beep(784, 200);
                Console.Beep(524, 200);
                Console.Beep(660, 200);
                Console.Beep(524, 200);
                Console.Beep(392, 200);
                Console.Beep(392, 200);
                Console.Beep(496, 200);
                Console.Beep(392, 200);
                Console.Beep(524, 200);
                Console.Beep(392, 200);
                Console.Beep(524, 200);
                Console.Beep(496, 200);
                Console.Beep(350, 200);
                Console.Beep(350, 200);
                Console.Beep(440, 200);
                Console.Beep(350, 200);
                Thread.Sleep(10);
                Console.Beep(524, 300);
                Console.Beep(524, 200);
                Console.Beep(496, 200);
            }

            //Darude Sandstorm
            else if (strSong == "12")
            {
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Thread.Sleep(0);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Thread.Sleep(0);
                Console.Beep(588, 100);
                Console.Beep(588, 100);
                Console.Beep(588, 100);
                Console.Beep(588, 100);
                Console.Beep(588, 100);
                Console.Beep(588, 100);
                Console.Beep(588, 100);
                Thread.Sleep(0);
                Console.Beep(524, 100);
                Console.Beep(524, 100);
                Console.Beep(524, 100);
                Console.Beep(524, 100);
                Console.Beep(524, 100);
                Console.Beep(524, 100);
                Console.Beep(524, 100);
                Thread.Sleep(0);
                Console.Beep(392, 300);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Console.Beep(440, 100);
                Thread.Sleep(0);

            }

            Console.Clear();
            blnFirstRun = true;
            Program.Main();
        }
        public static int Tones(string strPlay)
        {//37 is minumim value

            // octave difference 219hz

            switch (strPlay)
            {
                case "lowG":
                    {
                        intPlay = GbelowC;
                        break;
                    }
                case "A":
                    {
                        intPlay = A;
                        break;
                    }
                case "W":
                    {
                        intPlay = Asharp;
                        break;
                    }
                case "S":
                    {
                        intPlay = B;
                        break;
                    }
                case "D":
                    {
                        intPlay = C;
                        break;
                    }
                case "R":
                    {
                        intPlay = Csharp;
                        break;
                    }
                case "F":
                    {
                        intPlay = D;
                        break;
                    }
                case "T":
                    {
                        intPlay = Dsharp;
                        break;
                    }
                case "G":
                    {
                        intPlay = E;
                        break;
                    }
                case "H":
                    {
                        intPlay = F;
                        break;
                    }
                case "U":
                    {
                        intPlay = Fsharp;
                        break;
                    }
                case "J":
                    {
                        intPlay = G;
                        break;
                    }
                case "I":
                    {
                        intPlay = Gsharp;
                        break;
                    }
                case "Enter":
                    {
                        intPlay = REST;
                        break;
                    }
                default:
                    {
                        Program.Main();
                        break;
                    }
            }



            return intPlay;
        }
        public static int Duration_octave(string strPlay)
        {
            switch (strPlay)
            {
                //Duration
                case "Add":
                    {
                        intDuration = intDuration + 50;
                        break;
                    }
                case "Subtract":
                    {
                        if (intDuration > 100)
                        {
                            intDuration = intDuration - 50;
                        }
                        break;
                    }
                case "OemPlus":
                    {
                        intDuration = intDuration + 50;
                        break;
                    }
                case "OemMinus":
                    {
                        if (intDuration > 100)
                        {
                            intDuration = intDuration - 50;
                        }
                        break;
                    }

                //Octave
                case "Multiply":
                    {
                        if (intOctave < 7)
                        {
                            A = A * 2;
                            Asharp = Asharp * 2;
                            B = B * 2;
                            C = C * 2;
                            Csharp = Csharp * 2;
                            D = D * 2;
                            Dsharp = Dsharp * 2;
                            E = E * 2;
                            F = F * 2;
                            Fsharp = Fsharp * 2;
                            G = G * 2;
                            Gsharp = Gsharp * 2;
                            intOctave = intOctave + 1;
                        }
                        break;

                    }
                case "Divide":
                    {
                        if (intOctave > 1)
                            {
                            A = A / 2;
                            Asharp = Asharp / 2;
                            B = B / 2;
                            C = C / 2;
                            Csharp = Csharp / 2;
                            D = D / 2;
                            Dsharp = Dsharp / 2;
                            E = E / 2;
                            F = F / 2;
                            Fsharp = Fsharp / 2;
                            G = G / 2;
                            Gsharp = Gsharp / 2;
                            intOctave = intOctave - 1;
                        }
                        break;
                    }
                case "Escape":
                    {
                        blnFirstRun = true;
                        Program.Main();
                        break;
                    }
                case "Spacebar":
                    {
                        if (!Directory.Exists(strFileLocation + strFileSpace))
                        {
                            Directory.CreateDirectory(strFileLocation + strFileSpace);
                        }
                        if (!File.Exists(strFileLocation + strFileSpace + strFileName))
                        {
                           File.WriteAllText(strFileLocation + strFileSpace + strFileName, "");
                        }
                        if (!File.Exists(strFileLocation + strFileSpace + strFileDuration))
                        {
                            File.WriteAllText(strFileLocation + strFileSpace + strFileDuration, "");
                        }
                        string[] strText = File.ReadAllLines(strFileLocation + strFileSpace + strFileName);
                        string[] strDuration = File.ReadAllLines(strFileLocation + strFileSpace + strFileDuration);

                        Array.Resize(ref strText, strText.Length + 1);
                        int i;
                        for (i = 0; i < strText.Length; i++) { }
                        strText[i - 1] = Convert.ToString(intPlay);
                        for (int x = 0; x < strText.Length; x++)
                        {
                            if (x < strText.Length - 1) { }
                            else
                            {
                                strText[x] = /*"Console.Beep(" + */strText[x];
                            }
                        }

                        Array.Resize(ref strDuration, strDuration.Length + 1);
                        i = 0;
                        for (i = 0; i < strDuration.Length; i++) { }
                        strDuration[i - 1] = Convert.ToString(intDuration);
                        for (int x = 0; x < strDuration.Length; x++)
                        {
                            if (x < (strDuration.Length - 1)) { }
                            else
                            {
                                strDuration[x] = strDuration[x];
                            }
                        }

                        File.WriteAllLines(strFileLocation + strFileSpace + strFileDuration, strDuration);
                        File.WriteAllLines(strFileLocation + strFileSpace + strFileName, strText);
                        break;

                    }
                case "Decimal":
                    {
                        Program.PlaySong();
                        break;
                    }
            }
            return intDuration;
        }

        public static void PlaySong()
        {
            string[] strReadSong = File.ReadAllLines(strFileLocation + strFileSpace + strFileName);
            string[] strReadDuration = File.ReadAllLines(strFileLocation + strFileSpace + strFileDuration);
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
            } while (intSongCounter < strReadSong.Length);
            intSongCounter = 0;
        }

        public static void Play(string strPlay)
        {
            int intDuration = Program.Duration_octave(strPlay);
            strLastPlay = strPlay;
            intLastPlay = intPlay;
            intPlay = Program.Tones(strPlay);
            if (intPlay != 0)
            {
                Console.Beep(intPlay, intDuration);
            }
        }
    }
}
