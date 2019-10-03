using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;

namespace AUT_NS {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
        }

        const string apiKey = "21385c7775224c5b8e2ac45bae846716";

        async private void Button1_Click(object sender, EventArgs e) {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);

            string endpoint = "https://gateway.apiportal.ns.nl/virtual-train-api/api/v1/trein/838";

            HttpResponseMessage response = await client.GetAsync(endpoint);

            var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(example1);

            labelVervoerder.Text = await response.Content.ReadAsStringAsync();
        }
    }
}
