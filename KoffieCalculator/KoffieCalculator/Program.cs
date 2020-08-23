using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieCalculator
{
    class Program
    {
        public static double dblKoffieMoney;
        public static double dblPayPalMoney;

        static void Main(string[] args)
        {
            start:
            Console.Clear();
            Console.WriteLine("Koffie calculator");
            Console.WriteLine("Voer uw keuze in: \r\n1.) Bekijk saldo \r\n2.) herbereken \r\n3.) Afsluiten");
            string strChoice = Console.ReadLine();

            switch(strChoice)   
            {
                case "1":
                    goto strChoiceLabel1;
                    break;

                case "2":
                    goto strChoiceLabel2;
                    break;
                case "3":
                    Environment.Exit(1);
                    break;
            
                default:
                Console.WriteLine("error, geef een goede waarde aan \r\nDruk op enter om door te gaan.");
                Console.ReadLine();
                goto start;
            }
            //strChoise=1///////////////////////////////////////////////////////////////////////////////////////////
            strChoiceLabel1:
            Console.Clear();
            if (dblKoffieMoney >= dblPayPalMoney)
            {
                Console.WriteLine("Het tegoed staat positief voor Koffie, met een waarde van:{0}", dblKoffieMoney);
            }
            else if (dblPayPalMoney >= dblKoffieMoney)
            {
                Console.WriteLine("Het tegoed staat positief voor PayPal, met een waarde van:{0}", dblPayPalMoney);
            }
            goto finish;
            //strChoise=2///////////////////////////////////////////////////////////////////////////////////////////
            strChoiceLabel2:
            Console.Clear();
            Console.WriteLine("Wil je tegoed van Koffie of PayPal bewerken? \r\n1.)Koffie\r\n2.)PayPal");
            string strKoffiePayPalChoice = Console.ReadLine();

            if (strKoffiePayPalChoice == "1" || strKoffiePayPalChoice == "2")
            {
                goto KoffiePayPalLabel;
            }
            else
            {
                Console.WriteLine("error, geef een goede waarde aan \r\nDruk op enter om door te gaan.");
                Console.ReadLine();
                goto strChoiceLabel2;
            }

            KoffiePayPalLabel:
            Console.Clear();
            if (strKoffiePayPalChoice == "1")
            {
                Console.WriteLine("Je hebt gekozen voor Koffie");
            }
            else
            {
                Console.WriteLine("je hebt gekozen voor PayPal");
            }
            Console.WriteLine("Is that correct?");
            string strKoffiePayPalCheck = Console.ReadLine();
            if (strKoffiePayPalCheck == "y" || strKoffiePayPalCheck == "yes" || strKoffiePayPalCheck == "j" || strKoffiePayPalCheck == "ja")
            {

            }
            else if (strKoffiePayPalCheck == "n" || strKoffiePayPalCheck == "no" || strKoffiePayPalCheck == "nee")
            {
                goto strChoiceLabel2;
            }
            else
            {
                Console.WriteLine("error, geef een goede waarde aan \r\nDruk op enter om door te gaan.");
                Console.ReadLine();
                goto KoffiePayPalLabel;
            }

            finish:
            Console.ReadLine();

            /*
             * check of koffie value of paypal value groter is om zo automatisch te berekenen.
             * koffie en paypal value toekennen.
             * waarden opslaan en lezen in bestand.
             * funcie maken om geld aan te passen.
             * functie maken om geld om te rekenen van koffie naar paypal ( of andersom)
             * 
             */
        }
    }
}