using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    class Player {
        public string name;
        public Deck hand = new Deck();

        public Player(string name) {
            this.name = name;
        }

        public void addCard(Card card) {
            hand.add(card);
        }

        public Card getNextCard() {
            return hand.draw();
        }
    }
}
