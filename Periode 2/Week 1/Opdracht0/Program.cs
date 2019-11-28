using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            int test = readInt("Geef een getal: ", 10, 100);

            Console.WriteLine(test);

            Console.ReadKey();
        }

        int readInt(string message) {
            bool validNumber;

            Console.Write(message);

            do {
                validNumber = int.TryParse(Console.ReadLine(), out int input);

                if (validNumber) {
                    return input;
                } else {
                    Console.WriteLine("Dit is geen geldig getal");
                    Console.Write(message);
                }
            } while (!validNumber);

            return 0;
        }

        int readInt(string message, int min, int max) {
            bool validInput = false;

            do {
                int input = readInt(message);

                validInput = input >= min && input <= max;

                if (validInput) {
                    return input;
                } else {
                    Console.WriteLine($"De ingevoerde waarde ligt niet tussen {min} en {max}");
                }
            } while (!validInput);

            return 0;
        }

        int readIntAndValidate(string message, Func<int, bool> validationMethod) {
            bool validInput = false;

            Console.Write(message);

            do {
                bool validNumber = int.TryParse(Console.ReadLine(), out int input);

                if (validNumber) {
                    validInput = validationMethod(input);

                    if (validInput) {
                        return input;
                    } else {
                        Console.WriteLine("Dit in geen geldige waarde");
                        Console.Write(message);
                    }
                } else {
                    Console.WriteLine("Dit is geen gedig getal");
                    Console.Write(message);
                }
            } while (!validInput);

            return 0;
        }

        string readString(string message) {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
