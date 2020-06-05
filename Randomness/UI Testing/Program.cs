using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Testing {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            Form form = new MainView();

            form.ShowDialog();

            Console.ReadKey();
        }
    }
}
