using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    public class Logger {
        private static Logger instance;
        private int numberOfLines;

        private Logger() { }

        public static Logger create() {
            if (instance == null) instance = new Logger();
            return instance;
        }

        public void logLine(string system, string line) {
            numberOfLines++;
            Console.WriteLine($"{numberOfLines} - [{system}] {line}");
        }
    }
}
