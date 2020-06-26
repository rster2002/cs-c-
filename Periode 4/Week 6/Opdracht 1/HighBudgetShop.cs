using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class HighBudgetShop: ComputerShop {
        public override void createComputer() {
            processor = new ExpensiveProcessor();
            hardDisk = new ExpensiveHardDisk();
            monitor = new ExpensiveMonitor();
        }
    }
}
