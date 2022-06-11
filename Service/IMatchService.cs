using projectApi.DTO;
using projectApi.Model;
using projectApi.Model.Conversation;

namespace projectApi.Service
{
    public interface IMatchService
    {
         Task<IEnumerable<UserDto>> GetUsersAsync();
         Task PostUserAsync(UserDto user);
         Task<IEnumerable<Conversation>> GetConversationsByUserId(int id);
    }
}