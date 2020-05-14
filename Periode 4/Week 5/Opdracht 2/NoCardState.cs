using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class NoCardState: IATMState {
        private ATMMachine machine;

        public NoCardState(ATMMachine machine) {
            this.machine = machine;
        }

        public void EnterPincode(int pin) {
            Console.WriteLine("You have to insert a card first");
        }

        public void InsertCard() {
            Console.WriteLine("Please enter your pincode");
            machine.setState(new CardPresentState(machine));
        }

        public void RejectCard() {
            Console.WriteLine("Could not reject card (no card present)");
        }

        public void WithdrawCash(int amount) {
            Console.WriteLine("Cannot withdraw cash without a valid card");
        }
    }
}
