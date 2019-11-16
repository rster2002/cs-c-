using System;

namespace Opdracht3 {
    class Die {
        public int value;
        static Random random = new Random();

        public void roll() {
            value = random.Next(1, 7);
        }

        public void showValue() {
            Console.Write(value);
        }
    }
}
