using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2 {
    class Program {
        static void Main(string[] args) {
            Random rnd = new Random();
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = rnd.Next(150 + 1);
            }
        }
    }
}
