using Opdracht_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class LowBudgetFactory: ComputerFactory {
        public override IHardDisk createHardDisk() => new CheapHardDisk();
        public override IMonitor createMonitor() => new CheapMonitor();
        public override IProcessor createProcessor() => new CheapProcessor();
    }
}
