using System;

namespace Aufgaben1Lsg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe1();
            //Aufgabe2();
            //Aufgabe3();
            //Aufgabe4();
            AufgabeG1();

            //Damit das Programmfenster nicht gleich wieder zu geht.
            Console.ReadLine();
        }

        static void Aufgabe1()
        {
            string input = Console.ReadLine();
            Console.Write(input);
        }

        static void Aufgabe2()
        {
            string zeile1 = Console.ReadLine();
            string zeile2 = Console.ReadLine();
            Console.Write(zeile1 + zeile2);
        }

        static void Aufgabe3()
        {
            Console.Write("Gib deinen Namen ein: ");
            string name = Console.ReadLine();
            //"Hallo (Benutzername), wie geht's?"
            Console.WriteLine($"Hallo {name}, wie geht's?"); //Damit man {...} verwenden kann muss man vorne @ setzen.
        }

        static void Aufgabe4()
        {
            Console.Write("Gib Zahl 1 ein: ");
            string z1 = Console.ReadLine();
            Console.Write("Gib Zahl 2 ein: ");
            string z2 = Console.ReadLine();

            int zahl1 = Convert.ToInt32(z1);
            int zahl2 = Convert.ToInt32(z2);
            int erg = zahl1 + zahl2;

            string ergAusgabe = Convert.ToString(erg);

            Console.WriteLine($"Ergebnis: {ergAusgabe}");
        }

        static void AufgabeG1()
        {
            Console.Write("Gib eine Zahl oder ein Wort ein: ");
            string input = Console.ReadLine();
            
            int n;
            bool isInt = int.TryParse(input, out n);

            if(isInt == true)
            {
                Console.WriteLine("Es handelt sich um eine Ganzzahl.");
            }
            else
            {
                double d;
                bool isKomma = double.TryParse(input, out d);

                if(isKomma == true)
                {
                    Console.WriteLine("Es handlet sich um eine Kommazahl.");
                }
                else
                {
                    Console.WriteLine("Es handelt sich um ein Wort.");
                }
            }
        }
    }
}
