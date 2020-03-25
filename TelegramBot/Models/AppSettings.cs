using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; }  = "https://tbotservice.azurewebsites.net:443/{0}";

        public static string Name { get; set; } = "VoblaBot";

        public static string Key { get; set; }  = "1095999478:AAHGVngzxaJ3cHZiltmWk89tzrqvtdJDZmg";

    }
}