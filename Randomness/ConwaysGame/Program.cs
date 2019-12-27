using System;
using System.Timers;

namespace ConwaysGame {
    class Position {
        public int row = -1;
        public int column = -1;

        public Position(int r, int c) {
            row = r;
            column = c;
        }
    }

    class Program {
        ConwaysGame game;
        int generationsPerTick;

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            game = new ConwaysGame(rows: 30, columns: 50);
            game.getInput();

            startGame();

            start();
        }

        void startGame() {
            Console.Clear();
            game.initialDraw();

            Console.WriteLine();
            Console.Write("Game tick speed (in TPS): ");
            int tickSpeed = int.Parse(Console.ReadLine());
            Console.Write("Game generations per tick (in generations): ");
            generationsPerTick = int.Parse(Console.ReadLine());

            Timer timer = new System.Timers.Timer();
            timer.Interval = 1000 / tickSpeed;
            timer.Elapsed += doGameTick;
            timer.AutoReset = true;
            timer.Enabled = true;

            Console.ReadKey();

            timer.Enabled = false;

            return;
        }

        void doGameTick(Object source, System.Timers.ElapsedEventArgs e) {
            for (int i = 0; i <= generationsPerTick; i++) {
                game.gameTick();
            }
            
            game.reDraw();
        }
    }
}
