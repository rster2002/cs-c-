using System;
using System.Windows.Forms;

namespace Opdracht5 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e) {
            double number1 = double.Parse(textboxNumber1.Text);
            double number2 = double.Parse(textboxNumber2.Text);

            labelOutput.Text = (number1 + number2).ToString();
        }

        private void ButtonSubtract_Click(object sender, EventArgs e) {
            double number1 = double.Parse(textboxNumber1.Text);
            double number2 = double.Parse(textboxNumber2.Text);

            labelOutput.Text = (number1 - number2).ToString();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e) {
            double number1 = double.Parse(textboxNumber1.Text);
            double number2 = double.Parse(textboxNumber2.Text);

            labelOutput.Text = (number1 * number2).ToString();
        }

        private void ButtonDevide_Click(object sender, EventArgs e) {
            double number1 = double.Parse(textboxNumber1.Text);
            double number2 = double.Parse(textboxNumber2.Text);

            labelOutput.Text = (number1 / number2).ToString();
        }
    }
}
