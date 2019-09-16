using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        const double priceTshirt = 30.00;
        const double pricePants = 100.00;

        const double vatFactor = 1.21;

        private void Button1_Click(object sender, EventArgs e) {
            int ammountTshirts = int.Parse(inputTshirts.Text);
            int ammountPants = int.Parse(inputPants.Text);

            double tshirtsTotal = ammountTshirts * priceTshirt;
            double pantsTotal = ammountPants * pricePants;

            double totalCostWithoutVat = tshirtsTotal + pantsTotal;
            double totalCostWithVat = totalCostWithoutVat * vatFactor;
            double vatCostPart = totalCostWithVat - totalCostWithoutVat;

            string toPriceFormat(double price) {
                return "€ " + price.ToString("0.00");
            }

            outputDate.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            outputPrice.Text = toPriceFormat(totalCostWithoutVat);
            outputVat.Text = toPriceFormat(vatCostPart);
            outputTotal.Text = toPriceFormat(totalCostWithVat);
        }
    }
}
