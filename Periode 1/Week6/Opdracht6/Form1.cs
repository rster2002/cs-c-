using System;
using System.Windows.Forms;

namespace Opdracht6 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }
        
        static void squareByReference(ref int input) {
            input = input * input;
        }

        static void squareByOutParameter(int input, out int squaredNumber) {
            squaredNumber = input * input;
        }

        static int squareByReturnValue(int input) {
            return input * input;
        }

        private void ButtonByRef_Click(object sender, EventArgs e) {
            int number = int.Parse(textboxInput.Text);

            squareByReference(ref number);

            labelOutput.Text = number.ToString();
        }

        private void ButtonByOut_Click(object sender, EventArgs e) {
            int number = int.Parse(textboxInput.Text);

            squareByOutParameter(number, out int squaredNumber);

            labelOutput.Text = squaredNumber.ToString();
        }

        private void ButtonByReturn_Click(object sender, EventArgs e) {
            int number = int.Parse(textboxInput.Text);

            labelOutput.Text = squareByReturnValue(number).ToString();
        }
    }
}
