using Opdracht_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class HighBudgetFactory: ComputerFactory {
        public override IHardDisk createHardDisk() => new ExpensiveHardDisk();
        public override IMonitor createMonitor() => new ExpensiveMonitor();
        public override IProcessor createProcessor() => new ExpensiveProcessor();
    }
}
