using System;

namespace Opdracht_2 {
    class CorrectPinState: IATMState {
        private ATMMachine machine;

        public CorrectPinState(ATMMachine machine) {
            this.machine = machine;
        }

        public void enterPincode(int pin) {
            Console.WriteLine("You have already entered a correct pin");
        }

        public void insertCard() {
            Console.WriteLine("You have already inserted a card. You need to withdraw money");
        }

        public void rejectCard() {
            Console.WriteLine("Your card has been rejected");
            machine.setState(machine.getNoCardState());
        }

        public void withdrawCash(int amount) {
            if (amount > machine.amountInMachine) {
                Console.WriteLine("Not enough money in machine");
            } else {
                Console.WriteLine($"{amount} withdrawn from machine");
                machine.amountInMachine -= amount;

                if (machine.amountInMachine == 0) {
                    machine.setState(machine.getNoCashState());
                    return;
                }
            }

            rejectCard();
        }
    }
}
