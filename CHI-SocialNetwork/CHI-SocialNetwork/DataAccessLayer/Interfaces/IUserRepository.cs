using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.DataAccessLayer.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IQueryable<User> All(bool includeProfile);
        //void CreateFollower(string username, User follower);
        //void DeleteFollower(string username, User follower);

        User GetBy(int id, bool includeProfile = false, bool includeHobbies = false,
            bool includeFriends = false);
        User GetBy(string username, bool includeProfile = false, bool includeHobbies = false,
            bool includeFriends = false);
    }
}