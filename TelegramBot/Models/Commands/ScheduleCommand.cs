using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Models.Commands
{
    public class ScheduleCommand : Command
    {
        public override string Name => "schedule";

        public override void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //Bot logic there
            DateTime now = DateTime.Now;
            string answer;
            switch (now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    answer = "2 матана, физика лаб/физика пр";
                    break;
                case DayOfWeek.Tuesday:
                    answer = "физра, 2 матана, ничего/философия";
                    break;
                case DayOfWeek.Wednesday:
                    answer = "ОАИПР лекц, политорогия/психология пр, англ, (ДМ пр/ОАИПР пр) 1-я гр, (ОАИПР пр/ничего) 2-я гр";
                    break;
                case DayOfWeek.Thursday:
                    answer = "физра, физика лекц, ДМ лекц, философия лекц";
                    break;
                case DayOfWeek.Friday:
                    answer = "ничего, ОЗИ лекц, ОЗИ пр/ВОВ, политология пр/ОПиП";
                    break;
                default:
                    answer = "Сегодня выходной, иди спать, дорогой)";
                    break;
            }

            client.SendTextMessageAsync(chatId, answer, replyToMessageId: messageId);
        }
    }
}