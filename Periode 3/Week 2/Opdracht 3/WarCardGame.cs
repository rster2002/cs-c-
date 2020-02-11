using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    class WarCardGame:CardGame {
        public Player player1;
        public Player player2;

        public WarCardGame(Player player1, Player player2): base() {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void startGame() {
            deck.shuffle();

            dealCards(player1, deck.cards.Count / 2);
            dealCards(player2, deck.cards.Count / 2);
        }

        public void dealCards(Player player, int amount) {
            player.hand.add(deck.drawMultiple(amount));
        }

        public bool endOfGame() {
            return player1.hand.isEmpty() || player2.hand.isEmpty();
        }

        public void playRound() {
            Card player1card = player1.hand.draw();
            Card player2card = player2.hand.draw();

            int player1cardScore = player1card.cardScore();
            int player2cardScore = player2card.cardScore();

            Console.WriteLine($"[{player1.name}] {player1card.ToString()} - [{player2.name}] {player2card.ToString()}");

            if (player1cardScore > player2cardScore) {
                player1.hand.add(player1card);
                player1.hand.add(player2card);

                Console.WriteLine($"{player1.name} got the cards");
            } else if (player2cardScore > player1cardScore) {
                player2.hand.add(player1card);
                player2.hand.add(player2card);

                Console.WriteLine($"{player2.name} got the cards");
            } else {
                Console.WriteLine("Cards were lost");
                Console.WriteLine($"Current standings: {player1.name} {player1.hand.cards.Count}x, {player2.name} {player2.hand.cards.Count}x");
            }
        }
    }
}
