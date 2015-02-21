using CHI_SocialNetwork.DataAccessLayer.Interfaces;
using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.Services
{
    public class HobbyService : IHobbyService
    {
        private readonly IContext _context;
        private readonly IHobbyRepository _hobbies;

        public HobbyService(IContext context)
        {
            _context = context;
            _hobbies = context.Hobbies;
        }

        public Hobby GetBy(int id)
        {
            return _hobbies.GetBy(id);
        }

        public Hobby Create(User user, string hobbyName)
        {
            return Create(user.Id, hobbyName);
        }

        public Hobby Create(int userId, string hobbyName)
        {
            var hobby = new Hobby()
            {
                UserId = userId,
                Name = hobbyName,
                DateCreated = DateTime.Now

            };

            _hobbies.Create(hobby);

            _context.SaveChanges();

            return hobby;
        }

        public IEnumerable<Hobby> GetHobbiesFor(int userId)
        {
            return _hobbies.FindAll(r => r.UserId == userId)
                .OrderByDescending(r => r.DateCreated);
        }
    }
}