using System;
using System.Windows.Forms;

namespace Opdracht7 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        static double Celsius2Kelvin(double celsius) => celsius + 273;
        static double Celsius2Fahrenheit(double celsius) => celsius * 1.8 + 32;
        static double Fahrenheit2Celsius(double fahrenheit) => (fahrenheit - 32) / 1.8;

        private void ButtonCalculate_Click(object sender, EventArgs e) {
            double inputTemperature = double.Parse(textboxTempInput.Text);
            double output;

            if (radiobuttonCelciusToKelvin.Checked) {
                output = Celsius2Kelvin(inputTemperature);
            } else if (radiobuttonCelciusToFahrenheit.Checked) {
                output = Celsius2Fahrenheit(inputTemperature);
            } else {
                output = Fahrenheit2Celsius(inputTemperature);
            }

            labelOutput.Text = output.ToString();
        }
    }
}
