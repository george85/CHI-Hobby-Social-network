using CHI_SocialNetwork.DataAccessLayer.Interfaces;
using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.DataAccessLayer
{
    public class HobbyRepository : EfRepository<Hobby>, IHobbyRepository
    {
        public HobbyRepository(DbContext context, bool sharedContext)
            : base(context, sharedContext) { }

        public Hobby GetBy(int id)
        {
            return Find(r => r.Id == id);
        }

        public IEnumerable<Hobby> GetFor(User user)
        {
            return user.Hobbies.OrderByDescending(r => r.DateCreated);
        }

        public void AddFor(Hobby hobby, User user)
        {
            user.Hobbies.Add(hobby);

            if (!ShareContext)
            {
                Context.SaveChanges();
            }
        }
    }
}