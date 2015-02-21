using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.DataAccessLayer.Interfaces
{
    public interface IContext : IDisposable
    {
        IUserRepository Users { get; }
        IHobbyRepository Hobbies { get; }
        IUserProfileRepository Profiles { get; }

        int SaveChanges();
    }
}