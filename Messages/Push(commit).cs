namespace Gitlab2Telegram.Messages {
    public class Push {
        
        public Push(Root update) {
            Message = $@"{update.Commits.Count} new commits in {update.Project.Name}";
        }

        public string Message { get; set; }
    }
}
