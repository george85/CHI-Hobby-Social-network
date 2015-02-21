using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.Services
{
    public interface IHobbyService
    {
        Hobby GetBy(int id);
        Hobby Create(int userId, string hobbyName);
        Hobby Create(User user, string hobbyName);
        IEnumerable<Hobby> GetHobbiesFor(int userId);
    }
}