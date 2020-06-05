using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class ComputerShop {
        protected IProcessor processor;
        protected IHardDisk hardDisk;
        protected IMonitor monitor;

        public void runComputer() {
            processor.performOperation();
            hardDisk.storeData();
            monitor.display();
        }
    }
}
