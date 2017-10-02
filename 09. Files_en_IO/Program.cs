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
        static void Main(string[] args)
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
            Console.Clear();
            Console.WriteLine("Hoeveel regels wilt u wegscrhijven?");
            int intRegels = Convert.ToInt32(Console.ReadLine());
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

        }
    }
}
