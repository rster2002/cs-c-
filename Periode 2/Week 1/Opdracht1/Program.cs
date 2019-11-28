using System;

namespace Opdracht1 {
    class Program {
        InputMethods inputMethods = new InputMethods();

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            printMonths();

            Console.WriteLine();

            Month month = inputMonth();

            Console.WriteLine("{0} => {1}", (int) month, month);

            Console.ReadKey();
        }

        void printMonth(Month month) => Console.WriteLine("{0, 3}. {1}", (int) month, month);

        void printMonths() {
            for (int i = 1; i <= 12; i++) {
                printMonth((Month) i);
            }
        }

        Month inputMonth() {
            int monthInput = inputMethods.readInt(
                "Geef een maand: ",
                "{0} is geen geldige waarde",
                input => Enum.IsDefined(typeof(Month), input)
            );

            return (Month) monthInput;
        }
    }
}
