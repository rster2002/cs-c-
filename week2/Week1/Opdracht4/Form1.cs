using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht4 {
    public partial class Form1 : Form {

        const double vatFactor = 1.21;

        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (double.TryParse(priceInputBox.Text, out double price)) {
                string displayPrice = price.ToString("0.00");
                string displayVat = (price * vatFactor - price).ToString("0.00");
                string displayTotal = (price * vatFactor).ToString("0.00");

                priceOutput.Text = displayPrice;
                vatOutput.Text = displayVat;
                totalOutput.Text = displayTotal;
            } else {
                priceOutput.Text = "-";
                vatOutput.Text = "-";
                totalOutput.Text = "-";
            }
        }
    }
}
