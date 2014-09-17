using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Växelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler

            int paid = 0;

            int change;

            double total;

            double rounding;

            double subtotal = 0;



            // Läs in värden från tangentbord

            

            while (true)
            {
                try
                {
                        
                    Console.Write("Den totala kostnaden: ");
                    total = double.Parse(Console.ReadLine());
                    break;
             
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erhållet belopp är felaktigt. Köpet kunde inte genomföras");
                    Console.ResetColor();
                    
                }
               
            }

            if (Math.Round(total,MidpointRounding.AwayFromZero) < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Totalsumman är för liten");
                Console.ResetColor();
                return;
            }

           
            while (true)
            {
                try
                {

                    Console.Write("Betalat belopp:  ");
                    paid = int.Parse(Console.ReadLine());
                    break;

                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Erhållet belopp är felaktigt. Köpet kunde inte genomföras");
                    Console.ResetColor();
                    
                }


             }
                  
            
             if (paid < total)
             {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du har betalat för lite");
                    Console.ResetColor();
                    return;

                }



            // Uträkningen

                change = paid - (int)Math.Round(total, MidpointRounding.AwayFromZero);
                subtotal = (uint)Math.Round(total);
                rounding = subtotal - total; 





                //Presentation

                Console.WriteLine("KVITTO");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Total :             =    {0:c}", total);
                Console.WriteLine("Öresavrundning :    =    {0:c}", rounding);
                Console.WriteLine("Att betala :        =    {0:c0}", total);
                Console.WriteLine("Kontant :           =    {0:c0}", paid);
                Console.WriteLine("Växel :             =    {0:c0}", change);
                Console.WriteLine("--------------------------");

              


                if (change >= 500)
                {
                    Console.WriteLine("500-lappar       : {0}", change / 500); change %= 500;
                }
                if (change >= 100)
                {
                    Console.WriteLine("100-lappar       : {0}", change / 100); change = change % 100;
                }
                if (change >= 50)
                {
                    Console.WriteLine("50-lappar        : {0}", change / 50); change %= 50;
                }
                if (change >= 20)
                {
                    Console.WriteLine("20-lappar        : {0}", change / 20); change %= 20;
                }
                if (change >= 10)
                {
                    Console.WriteLine("10-kronor        : {0}", change / 10); change %= 10;
                }
                if (change >= 5)
                {
                    Console.WriteLine("5-kronor         : {0}", change / 5); change %= 5;
                }
                if (change >= 1)
                {
                    Console.WriteLine("1-kronor         : {0}", change / 1); change %= 1;
                }




            
        }
    }
}

