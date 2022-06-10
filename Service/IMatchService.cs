using projectApi.DTO;
using projectApi.Model;

namespace projectApi.Service
{
    public interface IMatchService
    {
         Task<IEnumerable<UserDto>> GetUsersAsync();
         Task PostUserAsync(UserDto user);
    }
}