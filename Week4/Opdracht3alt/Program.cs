using System;

namespace Opdracht3alt {
    class Program {
        static void Main(string[] args) {
            // Initializeer variabelen
            int inputNumber;
            int numberTotal = 0;
            int iteration = 1;

            // do-while loop omdat we zo minimaal 1x de code uitvoeren
            Console.WriteLine("Geef getallen: ");
            do {
                // Lees input van de gebruiker
                inputNumber = int.Parse(Console.ReadLine());

                // Check of het getal niet 0 is en of de iteratie een veelvoud van 5 is
                if (inputNumber != 0 && iteration % 5 == 0) {
                    // Voeg het ingelezen getal toe bij je totaal
                    numberTotal += inputNumber;
                }

                // Increment de iteratie variable
                iteration++;
            } while (inputNumber != 0);

            // Laat de som van ed getallen zien
            Console.WriteLine($"De som van de getallen is {numberTotal}");
            Console.ReadKey();
        }
    }
}
