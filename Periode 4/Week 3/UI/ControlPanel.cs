using Model;
using System;
using System.Windows.Forms;

namespace UI {
    public partial class mainForm: Form {
        private TreinController treinController;
        private TreinReis treinReis = new TreinReis();

        public mainForm() {
            InitializeComponent();

            treinReis.voegStationToe(new TreinStation(
                name: "Sloterdijk",
                platform: "7",
                arrivalTime: new DateTime(2020, 3, 16, 12, 30, 00),
                departureTime: new DateTime(2020, 3, 16, 12, 31, 00)
            ));

            treinReis.voegStationToe(new TreinStation(
                name: "Haarlem",
                platform: "8",
                arrivalTime: new DateTime(2020, 3, 16, 12, 43, 00),
                departureTime: new DateTime(2020, 3, 16, 12, 47, 00)
            ));

            treinReis.voegStationToe(new TreinStation(
                name: "Overveen",
                platform: "1",
                arrivalTime: new DateTime(2020, 3, 16, 12, 52, 00),
                departureTime: new DateTime(2020, 3, 16, 12, 53, 00)
            ));

            treinController = new TreinController(treinReis);
        }

        private void btnNextStationClick(object sender, EventArgs e) => treinController.volgendStation();

        private void btnNewDisplayClick(object sender, EventArgs e) {
            TreinDisplay display = new TreinDisplay();

            display.FormClosing += (observer, _) => treinReis.removeObserver((ITreinDisplay) observer);
            treinReis.addObserver(display);

            display.Show();
        }
    }
}
