using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdrracht6 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (int.TryParse(inputBoxSeconds.Text, out int inputSeconds)) {
                if (inputSeconds > 0) {
                    int hours = inputSeconds / 3600;
                    inputSeconds -= hours * 3600;

                    int minutes = inputSeconds / 60;
                    inputSeconds -= minutes * 60;

                    int seconds = inputSeconds;

                    string displayHours = hours.ToString("00");
                    string displayMinutes = minutes.ToString("00");
                    string displaySeconds = seconds.ToString("00");

                    outputTimeFormat.Text = $"{displayHours}:{displayMinutes}:{displaySeconds}";
                }
            }
        }
    }
}
