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

        public ATMMachine(decimal cashAmount) {
            amountInMachine = cashAmount;
            state = new NoCardState(this);
        }

        public void InsertCard() => state.InsertCard();
        public void RejectCard() => state.RejectCard();
        public void EnterPincode(int pin) => state.EnterPincode(pin);
        public void WithdrawCash(int amount) => state.WithdrawCash(amount);

        public void setState(IATMState state) {
            this.state = state;
        }
    }
}
