using projectApi.Model;
using projectApi.Database;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using projectApi.Model.Conversation;

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

        public async Task<IEnumerable<Conversation>> GetConversationsByUserId(int id)
        {
            return await dbContext.Conversations.Where(x => x.UserAccountId == id).ToListAsync();
        }

        public async Task PostUserAsync(UserAccount user)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
        }
    }
}