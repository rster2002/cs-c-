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

            machine.InsertCard();
            machine.RejectCard();

            machine.InsertCard();
            machine.EnterPincode(1234);
            machine.WithdrawCash(1500);

            machine.InsertCard();
            machine.EnterPincode(1234);
            machine.WithdrawCash(750);

            Console.ReadKey();
        }
    }
}
