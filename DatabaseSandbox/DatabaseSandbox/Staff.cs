using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSandbox {
    public class Staff {
        public string name;
        public int salt;
        public string role;

        public override string ToString() => $"{name}: {salt} as {role}";
    }
}
