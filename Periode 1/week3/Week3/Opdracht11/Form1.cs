using System;
using System.Linq;
using System.Windows.Forms;

namespace Opdracht11 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            double[] numbers = { double.Parse(inputValue1.Text), double.Parse(inputValue2.Text) };

            outputBiggestNumber.Text = numbers.Max().ToString();
            outputAverage.Text = numbers.Average().ToString();
            outputDifference.Text = (numbers.Max() - numbers.Average()).ToString();
        }
    }
}
