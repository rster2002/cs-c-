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
            for (int i = 0; i < randomNumbers.Length; i++) {
                int randomNumber = rnd.Next(1, 200 + 1);
                randomNumbers[i] = randomNumber;

                labelList1.Text += $"Element {i.ToString("00")}={randomNumber}\n";
            }
        }

        private void Button1_Click(object sender, EventArgs e) {
            int comparisonNumber = int.Parse(textboxComparasonNumber.Text);
            labelList2.Text = "";

            for (int i = 0; i < randomNumbers.Length; i++) {
                int number = randomNumbers[i];

                if (number >= comparisonNumber) {
                    labelList2.Text += $"Element {i.ToString("00")}={number + 10}\n";
                } else {
                    labelList2.Text += $"Element {i.ToString("00")}={number - 5}\n";
                }
            }

            button1.Enabled = false;
        }
    }
}
