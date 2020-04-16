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
            PencilSharpener pencilSharpener = new PencilSharpener();
            Pencil pencil = new Pencil(10);

            while (true) {
                Console.Write("Enter a word: ");
                string message = Console.ReadLine();

                if (message == "sharpen") {
                    pencilSharpener.sharpenPencil(pencil);
                } else if (message == "stop") {
                    return;
                } else {
                    pencil.write(message);
                }
            }
        }
    }
}
