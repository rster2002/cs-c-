using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Testing {
    public partial class MainView: Form {
        public MainView() {
            InitializeComponent();
        }

        private void LoadView(UserControl userControl) {
            userControl.Dock = DockStyle.Fill;

            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(userControl);
        }

        private void button1_Click(object sender, EventArgs e) {
            LoadView(new LoginView());
        }
    }
}
