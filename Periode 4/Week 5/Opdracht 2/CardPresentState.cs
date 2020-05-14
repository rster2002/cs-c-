using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class CardPresentState: IATMState {
        private ATMMachine machine;

        public CardPresentState(ATMMachine machine) {
            this.machine = machine;
        }

        public void EnterPincode(int pin) {
            if (pin == 1234) {
                Console.WriteLine("Entered valid pin");
                machine.setState(new CorrectPinState(machine));
            } else {
                Console.WriteLine("Invalid pin. Rejecting card...");
                machine.setState(new NoCardState(machine));
            }
        }

        public void InsertCard() {
            Console.WriteLine("There is already a card present");
        }

        public void RejectCard() {
            Console.WriteLine("Card was rejected");
            machine.setState(new NoCardState(machine));
        }

        public void WithdrawCash(int amount) {
            Console.WriteLine("You have to enter a pin first");
        }
    }
}
