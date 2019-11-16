using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht13 {
    public partial class Form1:Form {

        const double rentCostPerDay = 55.00;
        const double costPerKM = 0.25;
        const int freeKMs = 100;
        const double costPerLiter = 2.20;

        public Form1() {
            InitializeComponent();
        }

        private void BtnCalcRent_Click(object sender, EventArgs e) {
            double totalCost = 0;

            int daysRented = int.Parse(textboxDaysRented.Text);
            totalCost += daysRented * rentCostPerDay;

            int kmDriven = int.Parse(textboxKMDriven.Text);
            if (kmDriven > (freeKMs * daysRented)) {
                kmDriven -= freeKMs * daysRented;

                totalCost += kmDriven * costPerKM;
            }

            if (checkboxFuelCostByRenter.Checked) {
                double litersTanked = double.Parse(textboxLitersTanked.Text);

                totalCost += litersTanked * costPerLiter;
            }

            labelRentCost.Text = "€ " + totalCost.ToString("0.00");
        }

        private void CheckboxFuelCostByRenter_CheckedChanged(object sender, EventArgs e) {
            CheckBox ckb = sender as CheckBox;

            bool checkBoxState = ckb.Checked;

            textboxLitersTanked.Text = "";
            labelLitersTanked.Visible = checkBoxState;
            textboxLitersTanked.Visible = checkBoxState;
        }
    }
}
