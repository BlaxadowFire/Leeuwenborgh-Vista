using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Subwaj
{
    class Errors
    {
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
            Console.WriteLine("\r\nInformation:\r\nCurrentRoom = {0}\r\n", Program.CurrentRoom);
            Console.WriteLine("An unexpected error occured, please contact me at nando.kools@hotmail.com and give me the error ID");
            Program.CurrentRoom = string.Empty;
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
            Errors.ErrorHandlerStart();
            Console.WriteLine("ERROR: CODE DOESN'T EXIST");
            Console.WriteLine("ERROR ID: 0003");
            Errors.ErrorFinisher();
            Console.WriteLine("Press any button to return to Main Menu");
            Console.ReadKey();
            Program.MAINMENU();

        }
        //Error code out of bounds
        public static void ErrorOutOfBounds()
        {
            Errors.ErrorHandlerStart();
            Console.WriteLine("ERROR: CODE OUT OF BOUNDS");
            Console.WriteLine("ERROR ID: 0004");
            Errors.ErrorFinisher();
            Console.WriteLine("Press any button to return to Main Menu");
            Console.ReadKey();
            Program.MAINMENU();
        }
    }
}
