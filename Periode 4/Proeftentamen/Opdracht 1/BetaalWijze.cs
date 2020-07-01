using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1 {
    abstract class BetaalWijze {
        public void Uitvoeren() {
            InvoerenGegevens();
            VerwerkBetaling();
            SturenMail();
        }

        private void InvoerenGegevens() {
            Console.WriteLine("invoeren van gegevens");
        }

        protected abstract void VerwerkBetaling();

        private void SturenMail() {
            Console.WriteLine("bevestigingsmail versturen...");
        }
    }
}
