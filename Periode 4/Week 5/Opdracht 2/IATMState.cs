using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    public interface IATMState {
        void InsertCard();
        void RejectCard();
        void EnterPincode(int pin);
        void WithdrawCash(int amount);
    }
}
