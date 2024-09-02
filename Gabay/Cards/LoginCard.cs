using Microsoft.Bot.Schema;
using Newtonsoft.Json;

namespace Gabay.Cards
{
    public class LoginCard
    {
       private string username { get; set; }
       private string password { get; set; }

        public static Attachment cardSchema() {
            string cardJson = @"
            {
                ""$schema"": ""http://adaptivecards.io/schemas/adaptive-card.json"",
                ""type"": ""AdaptiveCard"",
                ""version"": ""1.3"",
                ""body"": [
                    {
                        ""type"": ""Container"",
                        ""items"": [
                            {
                                ""type"": ""Input.Text"",
                                ""placeholder"": ""Placeholder text"",
                                ""label"": ""Username:"",
                                ""id"": ""username""
                            },
                            {
                                ""type"": ""Input.Text"",
                                ""placeholder"": ""Placeholder text"",
                                ""label"": ""Password"",
                                ""id"": ""password"",
                                ""isMultiline"": false,
                                ""style"": ""text""
                            }
                        ]
                    }
                ],
                ""actions"": [
                    {
                        ""type"": ""Action.Submit"",
                        ""title"": ""Submit"",
                        ""data"": {
                            ""action"": ""submitForm""
                        }
                    }
                ]
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
