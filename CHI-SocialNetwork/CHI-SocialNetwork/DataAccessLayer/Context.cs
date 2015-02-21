using CHI_SocialNetwork.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.DataAccessLayer
{
    public class Context : IContext
    {
        private readonly DbContext _db;

        public Context(DbContext context = null, IUserRepository users = null, 
            IHobbyRepository hobbies = null, IUserProfileRepository profiles = null)
        {
            _db = context ?? new HobbyDb();
            Users = users ?? new UserRepository(_db, true);
            Hobbies = hobbies ?? new HobbyRepository(_db, true);
            Profiles = profiles ?? new UserProfileRepository(_db, true);
        }

        public IUserRepository Users
        {
            get;
            private set;
        }

        public IHobbyRepository Hobbies
        {
            get;
            private set;
        }

        public IUserProfileRepository Profiles { get; private set; }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                try
                {
                    _db.Dispose();
                }
                catch { }
            }
        }
    }
}