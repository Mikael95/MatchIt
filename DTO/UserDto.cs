using projectApi.Model.Enums;

namespace projectApi.DTO
{
    public class UserDto
    {
        public int Id  {get; set;}
        public string NickName {get; set;}
        public string? Description {get; set;}
        public string Email {get; set;}
        public decimal Popularity {get; set;}
        public Enums.Genders Gender {get; set;}
        public Enums.Genders InterestedIn {get; set;}
    }
}