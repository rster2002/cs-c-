using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    public class SubSystem {
        private Logger logger = Logger.create();

        public void doSomeWork() {
            logger.logLine("SubSystem", "doing some work");
        }

        public void doSomeMoreWork() {
            logger.logLine("SubSystem", "doing some more work");
        }
    }
}
