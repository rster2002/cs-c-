using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    abstract class ComputerShop {
        protected IProcessor processor;
        protected IHardDisk hardDisk;
        protected IMonitor monitor;

        public abstract void createComputer();
        public void runComputer() {
            processor.performOperation();
            hardDisk.storeData();
            monitor.display();
        }
    }
}
