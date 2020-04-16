using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class CD: BookStoreItem {
        public string artist { get; set; }

        public override string ToString() {
            return $"[CD] {title} - {artist}, " + base.ToString();
        }
    }
}
