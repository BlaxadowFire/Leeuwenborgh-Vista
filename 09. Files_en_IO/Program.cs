using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09.Files_en_IO
{
    class Program
    {
        public static string strFile = "UserInput.txt";
        public static string strPath = "../../";
        public static string strText = string.Empty;
        static void Main()
        {
            Console.Title = "Made by Nando";
            do
            {
                start:
                Console.Clear();
                Console.WriteLine("Wilt u text naar een bestand lezen of schrijven?\r\n1.) Lezen\r\n2.) Schrijven\r\n3.) Edit");
                string strReadWrite = Console.ReadLine();
                if (strReadWrite == "1")
                {
                    Program.funRead();
                }
                else if (strReadWrite == "2")
                {
                    Program.funWrite();
                }
                else if (strReadWrite == "3")
                {
                    Program.funEdit();
                }
                else
                {
                    Console.WriteLine("Error, geef een goede invoer aan.");
                    goto start;
                }
            }
            while (true);
        }
        public static void funRead()
        {
            Console.Clear();
           //Console.WriteLine(File.ReadAllText(strPath + strFile));
            string[] strRead = File.ReadAllLines(strPath + strFile);
            for (int i = 0; i < strRead.Length; i++)
            {
                Console.WriteLine(strRead[i]);
            }
            Console.ReadLine();
        }
        public static void funWrite()
        {
            labWrite:
            Console.Clear();
            Console.WriteLine("Hoeveel regels wilt u wegscrhijven?\r\n(0 om terug te gaan)");
            string strRegels = Console.ReadLine();
            int intRegels;
            if (!Int32.TryParse(strRegels, out intRegels))
            {
                Console.WriteLine("Please enter a valid value.");
                Console.ReadLine();
                goto labWrite;
            }
            if (intRegels == 0)
            {
                Program.Main();
            }

            Console.Clear();
            Console.WriteLine("Schrijf de regels die u in het bestand wilt schrijven.");
            string[] strWrite = { };
            Array.Resize(ref strWrite, intRegels);
            for (int i = 0;i < intRegels ;i++ )
            {
                strWrite[i] = Console.ReadLine();
            }
            File.WriteAllLines(strPath + strFile, strWrite);


           /* for ( int i = 0; i < intRegels;i++)
            Console.WriteLine(strWrite[i]);
            Console.ReadLine();
            */

        }
        public static void funEdit()
        {
            labUserEdit:
            Console.Clear();
            string[] strText = File.ReadAllLines(strPath + strFile);
            for (int i = 0; i < strText.Length; i++)
            {
                Console.WriteLine("{0}.| {1}",i+1, strText[i]);
            }
            Console.WriteLine("\r\nGeef aan welke regel u wilt bewerken\r\n(1 regel tegelijkertijd)\r\n(0 om terug te gaan)");
            //int intUserEdit = Convert.ToInt32(Console.ReadLine());
            string strUserEdit = Console.ReadLine();
            int intUserEdit;
            if (!Int32.TryParse(strUserEdit, out intUserEdit))
            {
                Console.WriteLine("Please enter a valid value.");
                Console.ReadLine();
                goto labUserEdit;
            }
            if (intUserEdit ==0)
            {
                Program.Main();
            }


            intUserEdit -= 1;
            Console.Clear();
            Console.WriteLine(strText[intUserEdit]);
            Console.WriteLine("Geef aan welke text u hier wilt hebben staan.");
            strText[intUserEdit] = Console.ReadLine();
            File.WriteAllLines(strPath + strFile, strText);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
