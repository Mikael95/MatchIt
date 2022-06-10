using projectApi.Model;

namespace projectApi.Repository
{
    public interface IMatchRepository
    {
         Task<IEnumerable<UserAccount>> GetAllUsersAsync();
         Task PostUserAsync(UserAccount user);
    }
}