using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Gabay.Commands
{
    public class Edit
    {
        public static List<string> commands = new List<string>()
        {
            "Edit Item",
            "Make Changes",
            "Update Item"
        };

        public static async Task ConfirmReachedAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            await turnContext.SendActivityAsync(MessageFactory.Text("Edit have been reached"), cancellationToken);
        }
    }
}
