using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef  het aantal seconden: ");

            if (int.TryParse(Console.ReadLine(), out int inputSeconds)) {
                if (inputSeconds >= 0) {
                    int hours = inputSeconds / 3600;
                    inputSeconds -= hours * 3600;

                    int minutes = inputSeconds / 60;
                    inputSeconds -= minutes * 60;

                    int seconds = inputSeconds;

                    string displayHours = hours.ToString("00");
                    string displayMinutes = minutes.ToString("00");
                    string displaySeconds = seconds.ToString("00");

                    Console.WriteLine($"{displayHours}:{displayMinutes}:{displaySeconds}");
                } else {
                    Console.WriteLine("De laatste keer dat ik keek had je geen negatieve tijden...");
                }
            } else {
                Console.WriteLine("Dit is niet een getal.");
            }

            Console.ReadKey();
        }
    }
}
