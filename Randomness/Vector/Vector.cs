using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector {
    class Vector {
        public int rows { get { return this.value.getLength(1) }; private set; }
        public int columns;
        public double[,] value = new double[1, 2]();
        
        Vector(double[,]) {
            
        }
    }
}
