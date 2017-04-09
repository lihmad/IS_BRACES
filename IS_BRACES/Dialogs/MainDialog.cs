using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;

namespace IS_BRACES.Dialogs
{
    [Serializable]
    public class MainDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }
        public async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> argument)
        {
            var message = await argument;

            var first = !context.ConversationData.ContainsKey("firstTime");

            if (first) {
                await context.PostAsync("Dobrý den, pomohu Vám s výběrem dovolené.");
                context.ConversationData.SetValue<bool>("firstTime", false);
            }

            
            //await context.PostAsync("You said: " + message.Text);
            //context.Wait(MessageReceivedAsync);
        }
    }
}