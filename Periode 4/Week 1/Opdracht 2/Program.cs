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
            IStack stack = new ArrayStack(50);

            addValues(stack);
            Console.WriteLine();

            checkRandomValue(stack);
            Console.WriteLine();

            processValues(stack);

            Console.ReadKey();
        }

        void addValues(IStack stack) {
            Random random = new Random();
            for (int i = 0; i < 10; i++) {
                int randomValue = random.Next(100);
                stack.push(randomValue);

                Console.WriteLine($"Pushed: {randomValue}, count: {stack.count}");
            }
        }

        void processValues(IStack stack) {
            while (!stack.isEmpty) {
                int value = stack.pop();
                Console.WriteLine($"Popped: {value}, count: {stack.count}");
            }
        }

        void checkRandomValue(IStack stack) {
            Random random = new Random();
            int checkValue = random.Next(100);
            bool contains = stack.contains(checkValue);

            Console.WriteLine($"The stack {(contains ? "does" : "does not")} contain {checkValue}");
        }
    }
}
