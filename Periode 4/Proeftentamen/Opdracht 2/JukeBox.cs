using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2 {
    class JukeBox {
        public List<IVinylSingle> Singles { get; set; }
        public IVinylSingle CurrentSingle { get; set; }

        public JukeBox(List<IVinylSingle> singles) {
            Singles = singles;
            CurrentSingle = singles[0];
        }

        public void Afspelen() {
            CurrentSingle.Play();
        }

        public void SelectSingle(int index) {
            CurrentSingle = Singles[index + 1];
        }

        public void Stoppen() {
            CurrentSingle.Stop();
        }
    }
}
