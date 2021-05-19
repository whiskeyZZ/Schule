using System;

namespace Schule
{
    class Program
    {
        static void Main(string[] args)
        {
            //AufgabeSechs();
            //Stromkosten();
            Tarifoptimierer();
        }

        static void AufgabeSechs()
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
            if (alter > 65)
            {
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

        static void Stromkosten()
        {
            string tarif = "1";
            double verbrauch = 1000;
            double preis = 0;

            if (tarif == "1")
            {
                preis = verbrauch * 0.12 + 80;
            }
            if (tarif == "2")
            {
                preis = verbrauch * 0.15 + 50;
            }

            Console.WriteLine("Der Preis beträgt: {0} Euro", preis);
        }

        static void Tarifoptimierer(){
            double preiseins = 0;
            double preiszwei = 0;
            double verbrauch = 8000;

            preiseins = verbrauch * 0.12 + 80;
            preiszwei = verbrauch * 0.15 + 50;

            if (preiseins > preiszwei){
                Console.Write("Tarif 2 ist der beste");
            }
            else if (preiseins < preiszwei){
                Console.Write("Tarif 1 ist der beste");
            }
            else {
                Console.Write("Beide Tarife sind gleich gut");
            }

        }
    }
}
