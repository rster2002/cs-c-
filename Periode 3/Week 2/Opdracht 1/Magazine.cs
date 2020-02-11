using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class Magazine: Book {
        public DayOfWeek dayOfPublication;

        public override void printEntry() {
            Console.WriteLine($"[Magazine] '{title}' - release day: {dayOfPublication}, {price}");
        }
    }
}
