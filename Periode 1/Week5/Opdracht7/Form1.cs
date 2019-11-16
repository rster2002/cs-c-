using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht7 {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            int[] rolledNumbers = new int[6];
            Random rnd = new Random();

            for (var i = 1; i <= 6000; i++) {
                int numberRolled = rnd.Next(1, 6 + 1);

                rolledNumbers[numberRolled - 1]++;
            }

            labelRolled1.Text = $"Waarde 1 is {rolledNumbers[0]} keer gegooit";
            labelRolled2.Text = $"Waarde 2 is {rolledNumbers[1]} keer gegooit";
            labelRolled3.Text = $"Waarde 3 is {rolledNumbers[2]} keer gegooit";
            labelRolled4.Text = $"Waarde 4 is {rolledNumbers[3]} keer gegooit";
            labelRolled5.Text = $"Waarde 5 is {rolledNumbers[4]} keer gegooit";
            labelRolled6.Text = $"Waarde 6 is {rolledNumbers[5]} keer gegooit";
        }
    }
}
