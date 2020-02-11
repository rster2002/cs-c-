using System;
using System.Collections.Generic;

namespace Opdracht_3 {
    class Card {
        public CardSuit suit;
        public string rank;

        Dictionary<string, int> rankScoreMap = new Dictionary<string, int>() {
            { "J", 11 },
            { "Q", 12 },
            { "K", 13 },
            { "A", 14 },
        };

        public Card() { }

        public Card(CardSuit suit, string rank) {
            this.suit = suit;
            this.rank = rank;
        }

        public int cardScore() {
            bool isNumber = int.TryParse(rank, out int value);

            if (isNumber) {
                return value;
            } else {
                return rankScoreMap[rank];
            }
        }

        public override string ToString() {
            return $"{rank} of {suit}";
        }
    }
}
