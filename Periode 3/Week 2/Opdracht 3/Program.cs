using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            WarCardGame game = new WarCardGame(player1, player2);

            playGame(game);

            Console.ReadKey();
        }

        void playGame(WarCardGame game) {
            game.startGame();

            while (!game.endOfGame()) {
                game.playRound();
            }

            Console.WriteLine();

            if (!game.player1.hand.isEmpty()) {
                Console.WriteLine($"{game.player1.name} has won");
            } else {
                Console.WriteLine($"{game.player2.name} has won");
            }
        }
    }
}
