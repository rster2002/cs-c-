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

        public void enterPincode(int pin) {
            if (pin == 1234) {
                Console.WriteLine("Entered valid pin");
                machine.setState(machine.getCorrectPinState());
            } else {
                Console.WriteLine("Invalid pin. Rejecting card...");
                machine.setState(machine.getNoCardState());
            }
        }

        public void insertCard() {
            Console.WriteLine("There is already a card present");
        }

        public void rejectCard() {
            Console.WriteLine("Card got rejected");
            machine.setState(machine.getNoCardState());
        }

        public void withdrawCash(int amount) {
            Console.WriteLine("You have to enter a pin first");
        }
    }
}
