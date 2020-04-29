using Model;
using System.Windows.Forms;

namespace UI {
    public partial class TreinDisplay: Form, ITreinDisplay {
        public TreinDisplay() {
            InitializeComponent();
        }

        public void update(TreinStation treinStation) {
            lblStationName.Text = treinStation.name;
            lblPlatform.Text = treinStation.platform;
        }
    }
}
