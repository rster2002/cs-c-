using System;

namespace Opdracht_2 {
    class NoCashState: IATMState {
        private ATMMachine machine;

        public NoCashState(ATMMachine machine) {
            this.machine = machine;
        }

        public void enterPincode(int pin) {
            Console.WriteLine("You've already enter your pin");
        }

        public void insertCard() {
            Console.WriteLine("There is already a card present");
        }

        public void rejectCard() {
            Console.WriteLine("Your card got rejected");
            machine.setState(machine.getNoCardState());
        }

        public void withdrawCash(int amount) {
            Console.WriteLine("No cash in machine");
            rejectCard();
        }
    }
}
