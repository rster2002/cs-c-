using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class NoCashState: IATMState {
        private ATMMachine machine;

        public NoCashState(ATMMachine machine) {
            this.machine = machine;
        }

        public void EnterPincode(int pin) {
            throw new NotImplementedException();
        }

        public void InsertCard() {
            throw new NotImplementedException();
        }

        public void RejectCard() {
            throw new NotImplementedException();
        }

        public void WithdrawCash(int amount) {
            throw new NotImplementedException();
        }
    }
}
