using System;

namespace Schule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entfernung zum Zielort: ");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.Write("Alter des Reisenden: ");
            int alter = Convert.ToInt32(Console.ReadLine());
            Console.Write("Einfache Fahrt? j/n: ");
            string einfach = Console.ReadLine();

            double preis = km * 0.2;

            if (alter < 14)
            {
                if (einfach == "j")
                {
                    preis = preis / 2;
                }
                else
                {
                    preis = preis * 0.6;
                }
            }
            if(alter > 65){
                if (einfach == "j")
                {
                    preis = preis * 0.7;
                }
                else
                {
                    preis = preis * 0.6;
                }
            }
            else
            {
                if (einfach == "n")
                {
                    preis = preis * 0.8;
                }
            }

            Console.Write("Der Preis beträgt: {0} Euro", preis);

        }
    }
}
