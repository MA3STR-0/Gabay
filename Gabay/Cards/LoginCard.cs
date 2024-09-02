using Microsoft.Bot.Schema;
using Newtonsoft.Json;

namespace Gabay.Cards
{
    public class LoginCard
    {
       private string username { get; set; }
       private string password { get; set; }

        public static Attachment cardSchema() {
            var cardJson = @"
        {
            ""type"": ""AdaptiveCard"",
            ""body"": [
                {
                    ""type"": ""TextBlock"",
                    ""text"": ""Login"",
                    ""weight"": ""Bolder"",
                    ""size"": ""Medium""
                },
                {
                    ""type"": ""Input.Text"",
                    ""id"": ""username"",
                    ""placeholder"": ""Enter your username"",
                    ""style"": ""text""
                },
                {
                    ""type"": ""Input.Text"",
                    ""id"": ""password"",
                    ""placeholder"": ""Enter your password"",
                    ""style"": ""password"",
                    ""isRequired"": true,
                    ""errorMessage"": ""Password is required.""
                }
            ],
            ""actions"": [
                {
                    ""type"": ""Action.Submit"",
                    ""title"": ""Submit""
                }
            ],
            ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
            ""version"": ""1.3""
        }";

            // Convert the card JSON string to an Attachment
            var adaptiveCard = new Attachment()
            {
                ContentType = "application/vnd.microsoft.card.adaptive",
                Content = JsonConvert.DeserializeObject(cardJson),
            };

            return adaptiveCard;
        }
    }
}
