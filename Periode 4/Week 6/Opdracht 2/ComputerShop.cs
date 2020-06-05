using Opdracht_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class ComputerShop {
        private ComputerFactory factory;
        private IProcessor processor;
        private IHardDisk hardDisk;
        private IMonitor monitor;

        public ComputerShop(ComputerFactory computerFactory) {
            factory = computerFactory;
        }

        public void buildComputer() {
            processor = factory.createProcessor();
            hardDisk = factory.createHardDisk();
            monitor = factory.createMonitor();
        }

        public void runComputer() {
            processor.performOperation();
            hardDisk.storeData();
            monitor.display();
        }
    }
}
