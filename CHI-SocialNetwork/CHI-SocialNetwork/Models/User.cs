using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }

        public int UserProfileId { get; set; }

        [ForeignKey("UserProfileId")]
        public virtual UserProfile Profile { get; set; }

        private ICollection<Hobby> _hobbies;
        public virtual ICollection<Hobby> Hobbies
        {
            get { return _hobbies ?? (_hobbies = new Collection<Hobby>()); }
            set { _hobbies = value; }
        }
        private ICollection<User> _friends;
        public virtual ICollection<User> Friends
        {
            get { return _friends ?? (_friends = new Collection<User>()); }
            set { _friends = value; }
        }
    }
}