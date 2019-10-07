using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht6 {
    public partial class Form1:Form {

        int[] randomNumbers = new int[20];

        public Form1() {
            InitializeComponent();

            Random rnd = new Random();
            for (int i = 3; i <= 22; i++) {
                int randomNumber = rnd.Next(1, 200 + 1);

                randomNumbers[i - 3] = randomNumber;

                Control lbl = Controls["label" + (22 - (i - 3))];
                lbl.Text = $"Element {(i - 3).ToString("00")}={randomNumber}";
            }

            for (int i = 23; i <= 42; i++) {
                Control lbl = Controls["label" + i];
                lbl.Text = "-";
            }
        }

        private void Button1_Click(object sender, EventArgs e) {
            int comparisonNumber = int.Parse(textboxComparasonNumber.Text);

            for (int i = 0; i < randomNumbers.Length; i++) {
                int number = randomNumbers[i];
                Control lbl = Controls["label" + (42 - i)];

                if (number >= comparisonNumber) {
                    lbl.Text = $"Element {i.ToString("00")}={number + 10}";
                } else {
                    lbl.Text = $"Element {i.ToString("00")}={number - 5}";
                }
            }
        }
    }
}
