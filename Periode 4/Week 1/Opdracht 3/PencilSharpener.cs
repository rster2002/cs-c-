using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    class PencilSharpener: IPencilSharpener {
        public void sharpenPencil(IPencil pencil) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sharpning the pencil...");
            Console.ResetColor();

            pencil.afterSharpening();
        }
    }
}
