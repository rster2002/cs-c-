using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht9 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            double contributionPrice;
            double contributionSoccer = 175.00;
            double contributionTennis = 225.00;

            if (radioSoccer.Checked) {
                contributionPrice = contributionSoccer;
            } else {
                contributionPrice = contributionTennis;
            }

            if (int.Parse(inputAge.Text) > 40) {
                contributionPrice -= 25;
            }

            if (int.Parse(inputDuration.Text) > 10) {
                contributionPrice -= 20;
            }

            outputContribution.Text = "€ " + contributionPrice.ToString("0.00");
        }
    }
}
