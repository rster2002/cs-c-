using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class CheapMonitor: IMonitor {
        public void display() {
            Console.WriteLine("I can literally count the pixels");
        }
    }
}
