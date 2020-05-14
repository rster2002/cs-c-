using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class CorrectPinState: IATMState {
        private ATMMachine machine;

        public CorrectPinState(ATMMachine machine) {
            this.machine = machine;
        }

        public void EnterPincode(int pin) {
            Console.WriteLine("You have already entered a correct pin");
        }

        public void InsertCard() {
            Console.WriteLine("You have already inserted a card. You need to withdraw money");
        }

        public void RejectCard() {
            Console.WriteLine("Youre card has been rejected");
        }

        public void WithdrawCash(int amount) {
            if (amount > machine.amountInMachine) {
                Console.WriteLine("Not enough money in machine");
            } else {
                Console.WriteLine($"{amount} withdrawn from machine");
                machine.amountInMachine -= amount;
            }

            machine.setState(new NoCardState(machine));
        }
    }
}
