using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class PINBetaling: BetaalWijze {
        protected override void VerwerkBetaling() {
            Console.WriteLine("PIN betaling verwerken...");
        }
    }
}
