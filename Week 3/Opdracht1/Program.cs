using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1 {
    class Program {
        InputMethods inputMethods = new InputMethods();

        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            Console.ReadKey();

            Main(args);
        }

        void start() {
            readPracticeReview();
        }

        PracticeReview readPracticeReview() {
            foreach (PracticeReview value in Enum.GetValues(typeof(PracticeReview))) {
                Console.Write("{0}: {1} ", (int) value, value);
            }

            Console.WriteLine();

            int practiceInt = inputMethods.readInt("Geef getal: ", 1, 5);

            return (PracticeReview) practiceInt;
        }
    }
}
