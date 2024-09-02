// Generated with Bot Builder V4 SDK Template for Visual Studio EchoBot v4.22.0

using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Gabay.Cards;
using Newtonsoft.Json;
using Microsoft.Bot.Builder.TraceExtensions;
using Gabay.Commands;
using System.Collections;
using System.Linq;
using System;

namespace Gabay.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
        
            if (ADD.commands.Any(command => turnContext.Activity.Text.IndexOf(command, StringComparison.OrdinalIgnoreCase) >= 0))
            {
                await ADD.AddTriggered(turnContext, cancellationToken);
            }
            else
            {
                await turnContext.SendActivityAsync(MessageFactory.Text("Didn't know something was up"), cancellationToken);
            }
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(
                        MessageFactory.Attachment(LoginCard.cardSchema())
                        , cancellationToken);
                }
            }        
        }
    }
}
