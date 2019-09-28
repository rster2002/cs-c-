using System;
using System.Windows.Forms;

namespace Opdracht8 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            int number = int.Parse(textboxNInput.Text);

            int sumTotal = 0;
            for (int i = 1; i <= number; i++) {
                sumTotal += i;
            }

            int formulaTotal = number * (number + 1) / 2;

            labelSumOutput.Text = sumTotal.ToString();
            labelFormulaOutput.Text = formulaTotal.ToString();

            labelConclution.Text = $"De som en formule zijn{ (sumTotal == formulaTotal ? " " : " niet ") }gelijk";
        }
    }
}
