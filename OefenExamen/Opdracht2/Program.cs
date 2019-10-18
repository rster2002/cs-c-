using System;

namespace Opdracht2 {
    class Program {
        static void Main(string[] args) {
            int inputInt;
            do {
                Console.Write("Geef een getal: ");
                inputInt = int.Parse(Console.ReadLine());

                string outputString = "";
                int firstPartLength = inputInt / 2;
                int secondPartLength = inputInt - firstPartLength;

                for (int i = 1; i <= firstPartLength; i++) {
                    outputString += "*";
                }

                for(int i = 1; i <= secondPartLength; i++) {
                    outputString += "!";
                }

                Console.WriteLine(outputString);
            } while (inputInt > 0);
        }
    }
}
