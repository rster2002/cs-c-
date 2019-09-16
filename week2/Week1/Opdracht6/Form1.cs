using System;
using System.Windows.Forms;

namespace Opdracht6 {
    public partial class Form1 : Form {

        const double vatFactor = 1.21;

        public Form1() {
            InitializeComponent();
        }

        private void BtnErase_Click(object sender, EventArgs e) {
            inputStartKM.Text = "";
            inputEndKM.Text = "";
            inputCostPerKM.Text = "";
        }

        private void BtnCalculate_Click(object sender, EventArgs e) {
            bool inputsValid = true;

            double getAndValidateInput(TextBox inputBox) {
                if (double.TryParse(inputBox.Text, out double value)) {
                    return value;
                } else {
                    inputsValid = false;
                    return 0;
                }
            }

            double startKM = getAndValidateInput(inputStartKM);
            double endKM = getAndValidateInput(inputEndKM);
            double costPerKM = getAndValidateInput(inputCostPerKM);

            if (inputsValid) {
                double distance = endKM - startKM;

                if (distance >= 0) {
                    string toEuroFormat(double cost) {
                        return $"€{cost.ToString("0.00")}";
                    }

                    double priceNoVat = distance * costPerKM;
                    double vatPricePart = priceNoVat * vatFactor - priceNoVat;
                    double priceIncludingVat = priceNoVat * vatFactor;

                    outputDistance.Text = distance.ToString() + " KM";
                    outputPriceNoVat.Text = toEuroFormat(priceNoVat);
                    outputVat.Text = toEuroFormat(vatPricePart);
                    outputPriceTotal.Text = toEuroFormat(priceIncludingVat);
                } else {
                    MessageBox.Show("Iemand heeft met de auto geklooit...");
                }
            }
        }
    }
}
