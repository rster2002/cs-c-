using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class LowBudgetShop: ComputerShop {
        public void createComputer() {
            processor = new CheapProcessor();
            hardDisk = new CheapHardDisk();
            monitor = new CheapMonitor();
        }
    }
}
