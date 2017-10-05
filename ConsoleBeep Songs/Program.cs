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




    //Moet vragen hoe ik een array heb , deze resize +1 zodag deze een waarde op nieuwe regel kan krijgen.

namespace ConsoleBeep_Songs
{
    class Program
    {
        public static int REST = 37;
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

        public static string strFileName = "/Song.txt";
        public static string strFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);


        static void Main()
        {
            ConsoleKeyInfo cki;
            Console.Title = "BeepSongs";
            if (blnFirstRun == true)
            {

                //Console.TreatControlCAsInput = true;

                Console.WriteLine("Select Song");
                Console.WriteLine("0.) Play own song\r\n1.) Mario Theme\r\n2.) Tetris Theme\r\n3.) Imperial March\r\n4.) Mission Impossible\r\n5.) Best song ever(Sightly off tune)\r\n6.) Song of Time\r\n7.) Song of Storms\r\n8.) Attack on Titan");
                strSong = Console.ReadLine();
                Console.Clear();
                blnFirstRun = false;
            }

            //Play self
            if (strSong == "0")
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
                case "P":
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
                case "Spacebar":
                    {
                        if (!File.Exists(strFileLocation + strFileName))
                        {
                            File.WriteAllText(strFileLocation + strFileName, "");
                        }
                        string strConverted = Convert.ToString(intPlay);

                        string[] strText = File.ReadAllLines(strFileLocation + strFileName);

                        /* Array.Resize(ref strText, strText.Length+);
                        int i;
                        for (i = 0; i < strText.Length; i++) { }
                        strText[i] = strLastPlay;
                        */
                        File.WriteAllText(strFileLocation + strFileName, "Console.Beep(" + strConverted + ", " + intDuration + ");" /*strText*/ /*+ strLastPlay*/);
                        break;

                    }




            }
            return intDuration;
        }
        public static void Play(string strPlay/* int A, int B, int C, int D, int E, int F, int G, int Asharp, int Csharp, int Dsharp, int Fsharp, int Gsharp, int REST*/)
        {
            int intDuration = Program.Duration_octave(strPlay);
            strLastPlay = strPlay;
            int intPlay = Program.Tones(strPlay);

            Console.Beep(intPlay,intDuration);
        }
    }
}
