using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.Services
{
    public interface IUserService
    {
        IEnumerable<User> All(bool includeProfile);
        
        User GetAllFor(int id);
        User GetAllFor(string username);
        User GetBy(int id);
        User GetBy(string username);
        User Create(string username, string password, UserProfile profile);
    }
}