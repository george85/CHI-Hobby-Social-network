using CHI_SocialNetwork.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.DataAccessLayer.Interfaces
{
    public interface IHobbyRepository : IRepository<Hobby>
    {
        Hobby GetBy(int id);
        IEnumerable<Hobby> GetFor(User user);
        void AddFor(Hobby hobby, User user);
    }
}