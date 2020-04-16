using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class Book: BookStoreItem {
        public string author { get; set; }

        public override string ToString() {
            return $"[Book] {author} - {title}, " + base.ToString();
        }
    }
}
