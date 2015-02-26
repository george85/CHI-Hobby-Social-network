using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CHI_SocialNetwork.Models;

namespace CHI_SocialNetwork.DataAccessLayer
{
    public class HobbyDb : DbContext
    {
        public HobbyDb() : base("HobbyConnection") { }


        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Friends).WithMany().Map(m =>
                {
                    m.MapLeftKey("UserId");
                    m.MapRightKey("FriendId");
                    m.ToTable("UsersFriends");
                }
    ); ;
            modelBuilder.Entity<User>()
                .HasMany(user => user.Hobbies);
               

            modelBuilder.Entity<Hobby>().HasMany(u => u.Comments);

            base.OnModelCreating(modelBuilder);
        }
    }
}