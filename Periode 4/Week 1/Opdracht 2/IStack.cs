using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    interface IStack {
        void push(int value);
        int pop();
        bool contains(int value);
        int count { get; }
        bool isEmpty { get; }
    }
}
