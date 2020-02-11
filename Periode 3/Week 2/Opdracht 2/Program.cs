using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            Deck deck = new Deck();

            deck.addDefaultCards();
            deck.shuffle();
            deck.print();

            Console.ReadKey();
        }
    }
}
