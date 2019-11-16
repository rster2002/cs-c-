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
        // Initializeer constante variable voor de prijzen van voetbal en tennis
        const double contributionSoccer = 175.00;
        const double contributionTennis = 225.00;

        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            // Initializeer een variable om zo verder mee te rekenen
            double contributionPrice;

            // Check welke sport geselecteerd is en zet de variable (contributionPrice)
            // naar de constributie prijs voor die sport
            if (radioSoccer.Checked) {
                contributionPrice = contributionSoccer;
            } else {
                contributionPrice = contributionTennis;
            }

            // Check of de leeftijd groter is dan 40, en als dat waar is, haal 25 euro van de prijs
            if (int.Parse(inputAge.Text) > 40) {
                contributionPrice -= 25;
            }

            // Check of de lengte van het lidmaadschap langer dan 10 jaar is, en als dat waar is, haal 20 euro
            // van de prijs af
            if (int.Parse(inputDuration.Text) > 10) {
                contributionPrice -= 20;
            }

            // Laat de prijs aan de gebruiker zien.
            outputContribution.Text = "€ " + contributionPrice.ToString("0.00");
        }
    }
}
