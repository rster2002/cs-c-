using System;
using System.Windows.Forms;

namespace UI {
    public partial class MainForm:Form {
        public MainForm() {
            InitializeComponent();
        }

        private void showFormAsPanel(Form form) {
            form.TopLevel = false;
            form.AutoScroll = true;

            panelView.Controls.Clear();
            panelView.Controls.Add(form);

            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void custumersToolStripMenuItem_Click(object sender, EventArgs e) {
            showFormAsPanel(new CustomersView());
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e) {
            showFormAsPanel(new BooksView());
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e) {
            showFormAsPanel(new ReservationsView());
        }
    }
}
