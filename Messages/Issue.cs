namespace Gitlab2Telegram.Messages {
    public class Issue {
        public Issue(Root update) {
            Message = $"New issue on {update.Project.Name}: {update.ObjectAttributes.Title}\n\n```{update.ObjectAttributes.Description}```";
        }

        public string Message { get; set; }
        
    }
}
