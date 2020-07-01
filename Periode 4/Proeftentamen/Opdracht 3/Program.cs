using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            machine1();

            Console.WriteLine();

            machine2();

            Console.ReadKey();
        }

        void machine1() {
            KopieerMachine kopieerMachine = KopieerMachine.getInstance();

            Console.WriteLine("Kopieeren met 'machine 1'");
            kopieerMachine.kopieer(10);
            kopieerMachine.kopieer(23);
        }

        void machine2() {
            KopieerMachine kopieerMachine = KopieerMachine.getInstance();

            Console.WriteLine("Kopieeren met 'machine 2'");
            kopieerMachine.kopieer(40);
        }
    }
}
