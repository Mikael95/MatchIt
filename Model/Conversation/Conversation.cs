namespace projectApi.Model.Conversation
{
    public class Conversation
    {
        public int Id {get; set;}
        public int UserAccountId {get; set;}
        public DateTime TimeStarted {get; set;}
        public DateTime TimeClosed {get; set;}
    }
}