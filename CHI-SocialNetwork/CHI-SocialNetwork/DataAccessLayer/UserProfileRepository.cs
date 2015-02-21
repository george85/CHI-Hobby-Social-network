using System.Data.Entity;
using CHI_SocialNetwork.Models;
using CHI_SocialNetwork.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.DataAccessLayer
{
    public class UserProfileRepository : EfRepository<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(DbContext context, bool sharedContext) : base(context, sharedContext) { }
    }
}