using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Telegram.Bot;
using TelegramBot.Models.Commands;

namespace TelegramBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client { get; set; }
        private static List<Command> commandList { get; set; }

        public static IReadOnlyList<Command> Commands { get => commandList.AsReadOnly(); }

        public static async Task<TelegramBotClient> Get()
        {
            if(client != null)
            {
                return client;
            }

            commandList = new List<Command>();
            commandList.Add(new HelloCommand());
            commandList.Add(new ScheduleCommand());
            //TODO: Add mode commands

            client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/update");
            await client.SetWebhookAsync(hook);
            return client;
        }
    }
}