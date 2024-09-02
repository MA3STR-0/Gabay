// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.22.0

using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Gabay.Cards;
using Newtonsoft.Json;

namespace Gabay.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var replyText = $"Echo: {turnContext.Activity.Text}";
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            /*
            LoginCard Card = new LoginCard();
            Attachment loginAttachment = LoginCard.cardSchema();
            var welcomeText = "Hi, I am Gabay an online chatbot interface todo list tool. To continue please input your username and password";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Attachment(loginAttachment), cancellationToken);
                }
            }
            */

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

            // Send the card to the user
            await turnContext.SendActivityAsync(MessageFactory.Attachment(adaptiveCard), cancellationToken);
        }
    }
}
