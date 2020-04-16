using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3 {
    interface IPencil {
        bool canWrite { get; }
        void write(string message);
        void afterSharpening();
    }
}
