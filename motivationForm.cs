using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motivation_Start
{
    public partial class motivationForm : Form
    {
        string[] quotes;
        Random random = new Random(DateTime.Now.Millisecond);
        public motivationForm()
        {
            InitializeComponent();
            DownloadQuots();
        }
        public async void DownloadQuots()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("amnesia", "application/text");
            string quotes = await client.GetAsync("https://jonastechnik.github.io/MotivationStart/app/quotes.txt").Result.Content.ReadAsStringAsync(); ;

            string dir = Directory.GetCurrentDirectory() + "/config/";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            dir += "quotes.txt";

            if (!File.Exists(dir))
            {
                File.Create(dir).Close();
            }

            await File.WriteAllTextAsync(dir, quotes);
            this.quotes = File.ReadAllLines(Directory.GetCurrentDirectory() + "/config/quotes.txt");
        }

        private void anotherBTN_Click(object sender, EventArgs e)
        {
            selectRandomQuote();
        }
        private void selectRandomQuote()
        {
            quoteBox.Text = quotes[random.Next(0, quotes.Length - 1)];
        }
    }
}
