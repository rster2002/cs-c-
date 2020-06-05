using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class ExpensiveMonitor: IMonitor {
        public void display() {
            Console.WriteLine("Look at that 4k resolution");
        }
    }
}
