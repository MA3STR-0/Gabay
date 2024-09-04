using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Gabay.Commands
{
    public class Delete
    {
        public static List<string> commands = new List<string>()
        {
            "Delete Item",
            "Delete Task",
            "Remove Item",
            "Remove Task"
        };

        public static async Task ConfirmTriggeredAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken) {
            await turnContext.SendActivityAsync(MessageFactory.Text("Delete have been triggered"), cancellationToken);
        }
    }
}
