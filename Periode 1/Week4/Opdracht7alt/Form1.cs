using System;
using System.Windows.Forms;

namespace Opdracht7 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            // Lees in hoe groot de vierkant moet zijn en omdat de vierkant uit tekst bestaat, begin met een lege string variable
            int sideSize = int.Parse(textboxSideSize.Text);
            string box = "";

            // Voor elke rij (horizontaal) doe het volgende
            for (int i = 1; i <= sideSize; i++) {
                // Elke lijn begint altijd met een '#'. Dit slaan we op in een string variable voor die lijn
                string line = "#";

                // Om de tekens tussen de twee vaste '#' te maken hebben we een for-loop nodig
                for (int j = 0; j <= (sideSize - 2); j++) {
                    // Als het de eerste rij of de laatste rij is, moeten er '#'s tussen de vaste '#', anders moeten het spaties zijn
                    if (i == 1 || i == sideSize) {
                        line += "#";
                    } else {
                        line += " ";
                    }
                }

                // Sluit de rij af met een laaste (vaste) '#' en een cariage return (\n) zodat een nieuwe rij op de volgende lijn komt
                line += "#\n";

                // Voeg de rij toe aan de variable voor de totale vierkant
                box += line;
            }

            // Laat de vierkant ziet bij een label
            labelBox.Text = box;
        }
    }
}
