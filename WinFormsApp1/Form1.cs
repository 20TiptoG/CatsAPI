using Newtonsoft.Json;
using System.ComponentModel.Design;
using System.Net;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool darkMode = false;
        
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
        Color LIGHT = Color.Wheat;
        Color DARK = Color.DarkBlue;
        Color TextDark = Color.Black;
        Color TexLight = Color.White;
        private void btnBigger_Click(object sender, EventArgs e)
        {

            size++;
            changeFontSize();


        }
        private void changeFontSize()
        {
            foreach (Control c in Controls)
            {
                c.Font = new Font(FontFamily.GenericSansSerif, size);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            changeFontSize();
            ChangeMode(LIGHT,Controls);
            // Challenges:
            // Add a text smaller button
            // Add a dark mode button
            // Choose a different API from https://github.com/public-apis/public-apis
        }

        private void lblCatFact_Click(object sender, EventArgs e)
        {

        }

        private void btnSmaller_Click(object sender, EventArgs e)
        {
            size--;
            changeFontSize();
        }
        private void ChangeMode(Color c,Control.ControlCollection items)
        {
            foreach(Control item in items)
            {
                item.BackColor = c;
                ChangeMode(c, item.Controls);
            }
        }
        private void ChangeTextColour(Color c, Control.ControlCollection items)
        {
            foreach (Control item in items)
            {
                item.ForeColor = c;
            
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (darkMode)
            {
                DarkModebtn.Text = "powered by darkness";
                ChangeMode(LIGHT, Controls);
                ChangeTextColour(TextDark,Controls);
            }
            else
            {
                DarkModebtn.Text = "Light mode";
                ChangeMode(DARK, Controls);
                ChangeTextColour(TexLight, Controls);
            }
            darkMode = !darkMode;
        }
    }
}
