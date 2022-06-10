using projectApi.Model;
using projectApi.Database;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace projectApi.Repository
{
    public class MatchRepository : IMatchRepository
    {
        private readonly MatchContext dbContext;

        public MatchRepository(MatchContext context)
        {
            dbContext = context;
        }

        public async Task<IEnumerable<UserAccount>> GetAllUsersAsync()
        {
            return await dbContext.Users.ToListAsync();
        }

        public async Task PostUserAsync(UserAccount user)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
        }
    }
}