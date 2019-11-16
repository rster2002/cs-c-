using System;
using System.Windows.Forms;

namespace Opdracht6 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            int balance = int.Parse(textboxStartBalance.Text);
            double factor = Math.Pow(1.05, 5);

            labelEndBalance.Text = "€ " + (balance * factor).ToString("0.00");
        }
    }
}
