using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Opdracht_2 {
    public class ATMMachine {
        private IATMState state;
        public decimal amountInMachine;

        private IATMState noCardState;
        private IATMState noCashState;
        private IATMState correctPinState;
        private IATMState cardPresentState;

        public ATMMachine(decimal cashAmount) {
            amountInMachine = cashAmount;

            // Initialize states
            noCardState = new NoCardState(this);
            noCashState = new NoCashState(this);
            correctPinState = new CorrectPinState(this);
            cardPresentState = new CardPresentState(this);

            // Set initial state
            if (amountInMachine > 0) state = noCardState;
            else state = noCashState;
        }
        
        public IATMState getNoCardState() => noCardState;
        public IATMState getNoCashState() => noCashState;
        public IATMState getCorrectPinState() => correctPinState;
        public IATMState getCardPresentState() => cardPresentState;

        public void insertCard() => state.insertCard();
        public void rejectCard() => state.rejectCard();
        public void enterPincode(int pin) => state.enterPincode(pin);
        public void withdrawCash(int amount) => state.withdrawCash(amount);

        public void setState(IATMState state) {
            this.state = state;
        }
    }
}
