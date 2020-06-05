using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            ATMMachine machine = new ATMMachine(2000);

            machine.insertCard();
            machine.rejectCard();

            machine.insertCard();
            machine.enterPincode(1234);
            machine.withdrawCash(1500);

            machine.insertCard();
            machine.enterPincode(1234);
            machine.withdrawCash(750);

            Console.ReadKey();
        }
    }
}
