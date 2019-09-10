using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht5 {
    public partial class Form1 : Form {

        bool valuesValidated = false;

        public Form1() {
            InitializeComponent();
        }

        private void CalculateAverage_Click(object sender, EventArgs e) {
            double value1 = double.Parse(inputBox1.Text);
            double value2 = double.Parse(inputBox2.Text);
            double value3 = double.Parse(inputBox3.Text);

            double average = (value1 + value2 + value3) / 3;

            outputAverage.Text = average.ToString("0.000");
        }
    }
}
