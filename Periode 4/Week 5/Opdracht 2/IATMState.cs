using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    public interface IATMState {
        void insertCard();
        void rejectCard();
        void enterPincode(int pin);
        void withdrawCash(int amount);
    }
}
