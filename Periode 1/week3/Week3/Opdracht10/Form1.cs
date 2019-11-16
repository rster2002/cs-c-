using System;
using System.Windows.Forms;

namespace Opdracht10 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        public string toEuroFormat(double value) {
            return "€ " + Math.Round(value, 2).ToString("0.00");
        }

        private void Button1_Click(object sender, EventArgs e) {
            double currentSalery = double.Parse(inputSalery.Text);

            double raise = currentSalery * 0.05;

            if (raise < 75) {
                raise = 75;
            }

            outputRaise.Text = toEuroFormat(raise);
            outputNewSalery.Text = toEuroFormat(currentSalery + raise);
        }
    }
}
