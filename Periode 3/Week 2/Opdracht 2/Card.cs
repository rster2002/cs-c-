using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class Card {
        public CardSuit suit;
        public string rank;

        public override string ToString() {
            return $"{rank} of {suit}";
        }
    }
}
