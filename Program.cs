using System;

namespace Schule
{
    class Program
    {
        static void Main(string[] args)
        {
            //AufgabeSechs();
            //Stromkosten();
            //Tarifoptimierer();
            //AufgabeZehn();
            AufgabeElf();
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

        static void AufgabeZehn(){
            double betrag = 20000;
            double cent = 0.01;
            int laufzeit = 21;

            for (int i= 0; i < laufzeit; i++){
                cent = cent * 2;
                Console.Write("Tag {0}: {1}", laufzeit, cent);
            }

            if (betrag > cent){
                Console.Write("Option a) ist besser");
            }
            else {
                Console.Write("Option b) ist besser");
            }
        }

        static void AufgabeElf(){
            string pin = "1234";
            int versuche = 0;

            while (versuche < 3){
                string eingabe = Console.ReadLine();

                if (pin == eingabe){
                    Console.WriteLine("Jetzt können sie Geld abheben");
                    break;
                }
                else {
                    versuche++;
                    if (versuche == 3){
                        Console.WriteLine("Die Karte wurde eingezogen.");
                    }
                }

            }

        }
    }
}
