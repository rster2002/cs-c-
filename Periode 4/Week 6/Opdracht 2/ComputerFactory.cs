using Opdracht_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    abstract class ComputerFactory {
        public abstract IProcessor createProcessor();
        public abstract IHardDisk createHardDisk();
        public abstract IMonitor createMonitor();
    }
}
