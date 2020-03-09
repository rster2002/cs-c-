using System;
using System.Collections.Generic;

namespace Opdracht_3 {
    class Deck {
        public List<Card> cards = new List<Card>();

        public Deck() { }
        
        public Deck(List<Card> cards) {
            this.cards = cards;
        }

        public void addCard(Card card) {
            cards.Add(card);
        }

        public void addDefaultCards() {
            for (int i = 0; i < 4; i++) {
                CardSuit currentSuit = (CardSuit) i;
                string[] additionalRanks = { "J", "Q", "K", "A" };

                for (int c = 2; c <= 10; c++) {
                    addCard(new Card() {
                        suit = currentSuit,
                        rank = c.ToString(),
                    });
                }

                foreach (string additionalRank in additionalRanks) {
                    addCard(new Card() {
                        suit = currentSuit,
                        rank = additionalRank,
                    });
                }
            }
        }

        public void shuffle() {
            List<Card> shuffledCards = new List<Card>();
            Random random = new Random();
            int cardsInDeck = cards.Count;

            for (int i = 0; i < cardsInDeck; i++) {
                int index = random.Next(0, cards.Count);
                Card pickedCard = cards[index];

                shuffledCards.Add(pickedCard);
                cards.Remove(pickedCard);
            }

            cards = shuffledCards;
        }

        public Card drawRandom() {
            Random random = new Random();

            int randomIndex = random.Next(0, cards.Count);
            Card pickedCard = cards[randomIndex];

            cards.Remove(pickedCard);

            return pickedCard;
        }

        public Card draw() {
            Card pickedCard = cards[0];
            cards.Remove(pickedCard);

            return pickedCard;
        }

        public List<Card> drawMultiple(int count = 1) {
            List<Card> drawnCards = new List<Card>();

            for (int i = 1; i <= count; i++) {
                drawnCards.Add(draw());
            }

            return drawnCards;
        }

        public void add(Card card) {
            cards.Add(card);
        }

        public void add(List<Card> cards) {
            foreach (Card card in cards) {
                this.cards.Add(card);
            }
        }

        public void remove(Card card) {
            cards.Remove(card);
        }

        public void print() {
            foreach (Card card in cards) {
                Console.WriteLine(card.ToString());
            }
        }

        public bool isEmpty() {
            return cards.Count == 0;
        }
    }
}
