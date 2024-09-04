using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Gabay.Commands
{
    public class Add
    {
       public static List<string> commands = new List<string> {
            "create item",
            "add todo",
            "new todo item",
            "new task",
        };

        public static async Task AddTriggered(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationtoken) {
            await turnContext.SendActivityAsync(MessageFactory.Text($"Add have been triggered message {turnContext.Activity.Text}"), cancellationtoken);
        }

    }
}
