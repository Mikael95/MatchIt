namespace projectApi.Model.Conversation
{
    public class Participant
    {
        public int Id {get; set;}
        public int ConversationId {get; set;}
        public int UserAccountId {get; set;} 
    }
}