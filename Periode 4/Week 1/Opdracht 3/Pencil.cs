using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    class Pencil: IPencil {
        private int maxToWrite;
        private int nrOfCharsWritten = 0;

        public bool canWrite { get; }

        public Pencil(int characters) {
            maxToWrite = characters;
        }

        public void write(string message) {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (char character in message) {
                if (nrOfCharsWritten <= maxToWrite) {
                    Console.Write(character);
                } else {
                    Console.Write("#");
                }

                nrOfCharsWritten++;
            }

            Console.ResetColor();

            Console.WriteLine();
        }

        public void afterSharpening() {
            nrOfCharsWritten = 0;
        }
    }
}
