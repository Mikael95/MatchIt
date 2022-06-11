using projectApi.Model;
using projectApi.Model.Conversation;

namespace projectApi.Repository
{
    public interface IMatchRepository
    {
         Task<IEnumerable<UserAccount>> GetAllUsersAsync();
         Task PostUserAsync(UserAccount user);
         Task<IEnumerable<Conversation>> GetConversationsByUserId(int id);
    }
}