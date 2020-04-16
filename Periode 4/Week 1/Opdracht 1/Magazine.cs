using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    class Magazine: BookStoreItem {
        public DayOfWeek releaseDay { get; set; }

        public override string ToString() {
            return $"[Magazine] {title} - {releaseDay}, " + base.ToString();
        }
    }
}
