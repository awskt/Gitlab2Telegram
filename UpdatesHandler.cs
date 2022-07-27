using System.Text.Json;
using Gitlab2Telegram.Messages;
using Telegram.Bot;
namespace Gitlab2Telegram {
    public static class UpdatesHandler {
        private static ITelegramBotClient bot = new TelegramBotClient(Config.BotToken);
        public static async Task Handle(HttpRequest req) {
            Root? updateJson;
            try {
                updateJson = await JsonSerializer.DeserializeAsync<Root>(req.Body).ConfigureAwait(false);
            } catch (Exception) {
                return;
            }
            if (updateJson is null) {
                return;
            }
            
            string message = req.Headers["X-Gitlab-Event"].ToString() switch {
                "Push Hook" => new Push(updateJson).Message,
                "Job Hook" => new Job(updateJson).Message,
                "Deployment Hook" => new DeployEvent(updateJson).Message,
                "Issue Hook" => new Issue(updateJson).Message,
                _ => "",
            };

            if (message == string.Empty) {
                return;
            }
            await bot.SendTextMessageAsync(Config.ChatId, message, Telegram.Bot.Types.Enums.ParseMode.Markdown).ConfigureAwait(false);
        }
    }
}
