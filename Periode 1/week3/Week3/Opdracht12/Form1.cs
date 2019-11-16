using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht12 {
    public partial class Form1:Form {
        const double basePrice = 12.00;

        public Form1() {
            InitializeComponent();
        }

        public void showOutputPrice(double price) {
            outputPrice.Text = "€ " + Math.Round(price, 2).ToString("0.00");
        }

        private void Button1_Click(object sender, EventArgs e) {
            int age = int.Parse(inputAge.Text);

            if (age < 5 || age >= 55) {
                showOutputPrice(0);
            } else if (age >= 5 && age <= 12) {
                showOutputPrice(basePrice / 2);
            } else {
                showOutputPrice(basePrice);
            }
        }
    }
}
