using System;
using System.Windows.Forms;

namespace Opdracht5 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        static int addNumbers(int number1, int number2) => number1 + number2;
        static int subtrackNumbers(int number1, int number2) => number1 - number2;
        static int multiplyNumbers(int number1, int number2) => number1 * number2;
        static double divideNumbers(int number1, int number2) => (double) number1 / number2;

        private void ButtonAdd_Click(object sender, EventArgs e) {
            int number1 = int.Parse(textboxNumber1.Text);
            int number2 = int.Parse(textboxNumber2.Text);

            labelOutput.Text = addNumbers(number1, number2).ToString();
        }

        private void ButtonSubtract_Click(object sender, EventArgs e) {
            int number1 = int.Parse(textboxNumber1.Text);
            int number2 = int.Parse(textboxNumber2.Text);

            labelOutput.Text = subtrackNumbers(number1, number2).ToString();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e) {
            int number1 = int.Parse(textboxNumber1.Text);
            int number2 = int.Parse(textboxNumber2.Text);

            labelOutput.Text = multiplyNumbers(number1, number2).ToString();
        }

        private void ButtonDevide_Click(object sender, EventArgs e) {
            int number1 = int.Parse(textboxNumber1.Text);
            int number2 = int.Parse(textboxNumber2.Text);

            labelOutput.Text = divideNumbers(number1, number2).ToString();
        }
    }
}
