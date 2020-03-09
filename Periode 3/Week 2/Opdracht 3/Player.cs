using System;

namespace Opdracht_3 {
    class Player {
        public string name;
        public Deck hand = new Deck();
        public ConsoleColor playerColor = ConsoleColor.White;

        public Player(string name, ConsoleColor playerColor) {
            this.name = name;
            this.playerColor = playerColor;
        }

        public void addCard(Card card) {
            hand.add(card);
        }

        public Card getNextCard() {
            return hand.draw();
        }
    }
}
