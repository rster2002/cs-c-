using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    public class MainSystem {
        private Logger logger = Logger.create();

        public void doSomeMainWork() {
            logger.logLine("MainSystem", "doing some main work");

            SubSystem subSystem = new SubSystem();
            subSystem.doSomeWork();
            subSystem.doSomeMoreWork();
        }
    }
}
