using AutoMapper;
using projectApi.DTO;
using projectApi.Model;

namespace projectApi.AutoMapper
{
    public class MatchProfile : Profile
    {
        public MatchProfile()
        {
            CreateMap<UserAccount, UserDto>().ReverseMap();
        }
    }
}