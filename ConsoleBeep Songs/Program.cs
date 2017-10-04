using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 * https://msdn.microsoft.com/nl-nl/library/4fe3hdb1(v=vs.110).aspx
 * https://msdn.microsoft.com/en-us/library/471w8d85.aspx
 * 
 */


namespace ConsoleBeep_Songs
{
    class Program
    {
        public static int REST = 37;
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
        public static bool blnFirstRun = true;
        static void Main()
        {
            ConsoleKeyInfo cki;

            if (blnFirstRun == true)
            {

                //Console.TreatControlCAsInput = true;
                Console.WriteLine("Select Song");
                Console.WriteLine("0.) Play own song\r\n1.) Mario Theme\r\n2.) Tetris Theme");
                strSong = Console.ReadLine();
                Console.Clear();
                blnFirstRun = false;
            }

            //Play self
            if (strSong == "0")
            {
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
            Console.Clear();
            blnFirstRun = true;
            Program.Main();
        }
        public static int Tones(string strPlay)
        {//37 is minumim value

            // octave difference 219hz

            switch (strPlay)
            {
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
                        intDuration = intDuration + 100;
                        break;
                    }
                case "Subtract":
                    {
                        if (intDuration > 100)
                        {
                            intDuration = intDuration - 100;
                        }
                        break;
                    }
                case "OemPlus":
                    {
                        intDuration = intDuration + 100;
                        break;
                    }
                case "OemMinus":
                    {
                        if (intDuration > 100)
                        {
                            intDuration = intDuration - 100;
                        }
                        break;
                    }

                //Octave
                case "Multiply":
                    {
                        if (intOctave < 90)
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




            }
            return intDuration;
        }
        public static void Play(string strPlay/* int A, int B, int C, int D, int E, int F, int G, int Asharp, int Csharp, int Dsharp, int Fsharp, int Gsharp, int REST*/)
        {
            int intDuration = Program.Duration_octave(strPlay);
            int intPlay = Program.Tones(strPlay);

            Console.Beep(intPlay,intDuration);
        }
    }
}
