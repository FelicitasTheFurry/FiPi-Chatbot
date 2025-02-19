using ChatPot.Extensions;
using Newtonsoft.Json.Linq;
using NLog.LayoutRenderers;
using System.Text;
using System.Text.Json;

namespace ChatPot
{
    public partial class Chatbotbeispiel : Form
    {
        static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        string rasaUrl = "http://localhost:5005/webhooks/rest/webhook";
        public Chatbotbeispiel()
        {
            InitializeComponent();
            Start();
        }

        private async void Start()
        {
            var response = await SendMessageToRasa(rasaUrl, "Moin");

            AusgabeBox.AppendText("Bot: ", Color.Blue);
            AusgabeBox.AppendText(response);
        }

        private async void EingabeBestaetigung_Click(object sender, EventArgs e)
        {
            string input = EingabeBenutzer.Text;
            
            AusgabeBox.AppendText(Environment.NewLine + "User: ", Color.Brown);
            AusgabeBox.AppendText(input);
            var response = await SendMessageToRasa(rasaUrl, input);

            if (!response.Equals("Kannst du das nochmal umformulieren? Vielleicht fehlt ja auch ein Bindestrich."))
            {
                EingabeBenutzer.Text = string.Empty;
            }
            AusgabeBox.AppendText(Environment.NewLine + "Bot: ", Color.Blue);
            AusgabeBox.AppendText(response);

        }

        private void EingabeBenutzer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EingabeBestaetigung_Click(this, new EventArgs());
            }
        }
        static async Task<string> SendMessageToRasa(string url, string message)
        {
            logger.Debug("User writes: " + message);
            string temp = String.Empty;
            using HttpClient client = new HttpClient();
            var jsonContent = new
            {
                sender = "user123",  // Beliebige Benutzer-ID
                message = message
            };

            string json = JsonSerializer.Serialize(jsonContent);
            var userInput = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = await client.PostAsync(url, userInput);
                response.EnsureSuccessStatusCode();

                //ExtractText(response.Content.ReadAsStringAsync());
                var newJson = await response.Content.ReadAsStringAsync();
                temp = ExtractText(newJson);
                logger.Debug("Bots response was: " + temp);
            }
            catch (Exception ex)
            {
                logger.Error("Es ist ein Fehler aufgetreten.");
                logger.Error(ex);
            }

            if (temp.Length == 0)
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

                return jsonArray[0]["text"].ToString();
            }
            catch (Exception ex)
            {
                logger.Error("Es ist ein Fehler aufgetreten.");
                logger.Error(ex);

                return string.Empty;
            }
        }

      
    }
}
