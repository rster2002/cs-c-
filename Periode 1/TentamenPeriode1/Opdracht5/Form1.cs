using System;
using System.Windows.Forms;

namespace Opdracht5 {
    public partial class Form1:Form {
        const double secondClassPrice = 53.00;
        const double firstClassPrice = 87.46;
        const double railRunnerPrice = 2.50;

        public Form1() {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e) {
            double totalPrice = 0;
            double classPrice = 0;

            int ticketAmount = int.Parse(txtboxAmount.Text);
            int railRunnerAmount = int.Parse(txtboxRailRunnerAmount.Text);

            classPrice = radiobtnFirstClass.Checked ? firstClassPrice : secondClassPrice;

            totalPrice += classPrice * ticketAmount;
            totalPrice += railRunnerAmount * railRunnerPrice;

            txtboxOutputPrice.Text = totalPrice.ToString("0.00");
        }
    }
}
