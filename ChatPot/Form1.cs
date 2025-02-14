using Newtonsoft.Json.Linq;
using System.Drawing.Printing;
using System.Management.Automation;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ChatPot.Extensions;
using System.Diagnostics;

namespace ChatPot
{
    public partial class Form1 : Form
    {
        string rasaUrl = "http://localhost:5005/webhooks/rest/webhook";
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private async void Start()
        {
            var response = await SendMessageToRasa(rasaUrl, "Moin");

            richTextBox1.AppendText("Bot: ", Color.Blue);
            richTextBox1.AppendText(response);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            //if(input.ToLower().Equals("ah"))
            //{
            //    var process = new Process();
            //    process.StartInfo.Arguments = "/r";
            //    process.StartInfo.FileName = "shutdown.exe";
            //    process.Start();
            //}
            richTextBox1.AppendText(Environment.NewLine + "User: " , Color.Brown);
            richTextBox1.AppendText(input);
            var response = await SendMessageToRasa(rasaUrl, input);

            if(!response.Equals("Kannst du das nochmal umformulieren? Vielleicht fehlt ja auch ein Bindestrich."))
            {
                textBox1.Text = string.Empty;
            }
            richTextBox1.AppendText(Environment.NewLine + "Bot: ", Color.Blue);
            richTextBox1.AppendText(response);
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
        static async Task<string> SendMessageToRasa(string url, string message)
        {
            using HttpClient client = new HttpClient();
            var jsonContent = new
            {
                sender = "user123",  // Beliebige Benutzer-ID
                message = message
            };

            string json = JsonSerializer.Serialize(jsonContent);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            //ExtractText(response.Content.ReadAsStringAsync());
            var newJson = await response.Content.ReadAsStringAsync();
            string temp = ExtractText(newJson);
            if(temp.Length==0)
            {
                temp = "Kannst du das nochmal umformulieren? Vielleicht fehlt ja auch ein Bindestrich.";
            }

             return temp;
        }

        static string ExtractText(string jsonString)
        {
            try
            {
                JArray jsonArray = JArray.Parse(jsonString);

                string temp = jsonArray[0]["text"].ToString();
                return jsonArray[0]["text"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
                return string.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
