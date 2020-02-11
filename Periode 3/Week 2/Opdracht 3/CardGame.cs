using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    class CardGame {
        public Deck deck;

        public CardGame() {
            deck = new Deck();
            deck.addDefaultCards();
        }
    }
}
