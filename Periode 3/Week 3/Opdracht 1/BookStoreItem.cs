using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    abstract class BookStoreItem {
        public string title { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        abstract public void print();
    }
}
