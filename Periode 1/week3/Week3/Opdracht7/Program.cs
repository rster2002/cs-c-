using System;

namespace Opdracht7 {
    class Program {
        static void Main(string[] args) {
            double healthyBMIMin, healthyBMIMax;

            double BMI(double _weight, double _length) {
                return _weight / (Math.Pow(_length, 2));
            }

            Console.Write("Wat is je gewicht in kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Geef je length in cm: ");
            double length = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Wat is je geslacht (m/v): ");
            string sex = Console.ReadLine().ToUpper();

            if (sex == "M") {
                healthyBMIMin = 20;
                healthyBMIMax = 25;
            } else if (sex == "V") {
                healthyBMIMin = 19;
                healthyBMIMax = 24;
            } else {
                Console.WriteLine("Dat is geen geldig geslacht.");
                Console.ReadKey();

                return;
            }

            double userBMI = BMI(weight, length);

            if (userBMI >= healthyBMIMin && userBMI <= healthyBMIMax) {
                Console.Write("Je heb een gezond gewicht");
            } else if (userBMI > healthyBMIMax) {
                Console.Write("Je bent te zwaar");
            } else {
                Console.Write("Je bent te licht");
            }

            Console.WriteLine(", je heb namelijk een BMI van {0}", Math.Round(userBMI, 2));
            Console.WriteLine($"Een gezond BMI voor jouw geslacht ligt tussen de {healthyBMIMin} en {healthyBMIMax}");
            Console.ReadKey();
        }
    }
}
