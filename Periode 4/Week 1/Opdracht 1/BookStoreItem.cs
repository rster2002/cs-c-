using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    abstract class BookStoreItem {
        public string title { get; set; }
        public float price { get; set; }
        public int numberOfItems { get; set; }

        public override string ToString() {
            return $"{price.ToString("0.00")} ({numberOfItems}x)";
        }
    }
}
