using projectApi.DTO;
using projectApi.Model;
using projectApi.Repository;
using AutoMapper;
using projectApi.Model.Conversation;

namespace projectApi.Service
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository repository;
        private readonly IMapper mapper;

        public MatchService(IMatchRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Conversation>> GetConversationsByUserId(int id)
        {
            return await repository.GetConversationsByUserId(id);
        }

        public async Task<IEnumerable<UserDto>> GetUsersAsync()
        {
            var dbResult = await repository.GetAllUsersAsync();
            var result = mapper.Map<List<UserDto>>(dbResult);
            return result;
        }

        public async Task PostUserAsync(UserDto user)
        {
            var result = mapper.Map<UserAccount>(user);
            await repository.PostUserAsync(result);
        }
    }
}