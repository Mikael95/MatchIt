
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using projectApi.Model;
using projectApi.Model.Attributes;
using projectApi.Model.Conversation;
using projectApi.Model.Preferences;


namespace projectApi.Database
{
    public class MatchContext : DbContext
    {

        public DbSet<UserAccount> Users {get; set;}
        public DbSet<Model.Attributes.Attribute> Attributes {get; set;}
        public DbSet<AttributeAnswears> AttributeAnswears {get; set;}
        public DbSet<Conversation> Conversations {get; set;}
        public DbSet<Message> Messages {get; set;}
        public DbSet<Participant> Participants {get; set;}
        public DbSet<Preference> Preferences {get; set;}
        public DbSet<PreferenceAnswears> PreferenceAnswears {get; set;}

         public MatchContext(DbContextOptions<MatchContext> options)
            : base(options)
        {
        }
    }
}