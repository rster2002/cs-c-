using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class CreditCardBetaling: BetaalWijze {
        protected override void VerwerkBetaling() {
            Console.WriteLine("CreditCard betaling verwerken...");
        }
    }
}
