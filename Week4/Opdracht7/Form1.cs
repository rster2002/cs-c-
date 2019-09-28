using System;
using System.Windows.Forms;

namespace Opdracht7 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            int sideSize = int.Parse(textboxSideSize.Text);
            string box = "";

            for (int i = 1; i <= sideSize; i++) {
                string line = "#";

                for (int j = 0; j <= (sideSize - 2); j++) {
                    if (i == 1 || i == sideSize) {
                        line += "#";
                    } else {
                        line += " ";
                    }
                }

                line += "#\n";

                box += line;
            }

            labelBox.Text = box;
        }
    }
}
