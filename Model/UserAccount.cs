using Microsoft.AspNetCore.Identity;

namespace projectApi.Model
{
    public class UserAccount
    {
        public int Id  {get; set;}
        public string NickName {get; set;}
        public int GenderId {get; set;}
        public string? Description {get; set;}
        public string Email {get; set;}
        public decimal Popularity {get; set;}
        public Enums.Enums.Genders Gender {get; set;}
        public Enums.Enums.Genders InterestedIn {get; set;}
    }
}