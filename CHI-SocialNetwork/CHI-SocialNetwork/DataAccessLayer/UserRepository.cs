using CHI_SocialNetwork.DataAccessLayer.Interfaces;
using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.DataAccessLayer
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context, bool sharedContext) : base(context, sharedContext) { }

        public IQueryable<User> All(bool includeProfile)
        {
            return includeProfile ? DbSet.Include(u => u.Profile).AsQueryable() : All();
        }

        public User GetBy(int id, bool includeProfile = false, bool includeHobbies = false,
            bool includeFriends = false)
        {
            var query = BuildUserQuery(includeProfile, includeHobbies, includeFriends);

            return query.SingleOrDefault(u => u.Id == id);
        }

        private IQueryable<User> BuildUserQuery(bool includeProfile, bool includeHobbies, bool includeFriends)
        {
            var query = DbSet.AsQueryable();

            if (includeProfile)
                query = DbSet.Include(u => u.Profile);

            if (includeHobbies)
                query = DbSet.Include(u => u.Hobbies);

            if (includeFriends)
                query = DbSet.Include(u => u.Friends);

            
            return query;
        }

        public User GetBy(string username, bool includeProfile = false, bool includeHobbies = false,
            bool includeFriends = false)
        {
            var query = BuildUserQuery(includeProfile, includeHobbies, includeFriends);

            return query.SingleOrDefault(u => u.Username == username);

        }
    }
}