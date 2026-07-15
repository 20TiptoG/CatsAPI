using Newtonsoft.Json;
using System.Net;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            // Get data from https://meowfacts.herokuapp.com/

            // code adapted from https://learn.microsoft.com/en-us/dotnet/api/system.net.webclient.downloadstring?view=net-10.0
            WebClient w = new WebClient();


            Task t = new Task(() =>
            {
                Thread.Sleep(5000);
                string json = w.DownloadString(new Uri("https://meowfacts.herokuapp.com/"));
                // end of code adapted from https://learn.microsoft.com/en-us/dotnet/api/system.net.webclient.downloadstring?view=net-10.0

                // process the JSON object to extract the quote
                dynamic quote = JsonConvert.DeserializeObject(json);

                // display on screen
                Invoke(() =>
                {
                    lblCatFact.Text = quote.data[0];
                });

            });

            t.Start();




        }

        int size = 10;

        private void btnBigger_Click(object sender, EventArgs e)
        {

            size++;
            foreach (Control c in Controls)
            {
                c.Font = new Font(FontFamily.GenericSansSerif, size);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Challenges:
            // Add a text smaller button
            // Add a dark mode button
            // Choose a different API from https://github.com/public-apis/public-apis
        }
    }
}
