using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    class KopieerMachine {
        static private KopieerMachine instance;
        private int aantalKopies;

        public int AantalKopies {
            get {
                return aantalKopies;
            }

            private set {
                aantalKopies = value;
            }
        }

        private KopieerMachine() {
            AantalKopies = 0;
        }

        public static KopieerMachine getInstance() {
            if (instance == null) instance = new KopieerMachine();
            return instance;
        }

        public void kopieer(int aantal) {
            AantalKopies += aantal;

            Console.WriteLine($"Aan het kopieeren, {aantal}x");
            Console.WriteLine($"Totaal kopies: {AantalKopies}");
        }
    }
}
