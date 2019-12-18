using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.Input;

namespace Opdracht_1 {
    class Program {
        Input input = new Input();

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            int test = input.readInt("Geef een getal: ", "Het getal moet een getal zijn van 10 t'm 100", 10, 100);

            Console.WriteLine(test);

            Console.ReadKey();
        }
    }
}
