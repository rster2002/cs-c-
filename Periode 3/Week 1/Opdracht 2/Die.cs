using System;

namespace Opdracht3 {
    class Die {
        public int value;
        Random random;

        public Die(Random generator) {
            random = generator;
        }

        public void roll() {
            value = random.Next(1, 7);
        }

        public void showValue() {
            Console.Write(value);
        }
    }
}
