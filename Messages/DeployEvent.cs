namespace Gitlab2Telegram.Messages {
    public class DeployEvent {
        public DeployEvent(Root update) {
            Message = "";
        }

        public string Message { get; set; }
        
    }
}
