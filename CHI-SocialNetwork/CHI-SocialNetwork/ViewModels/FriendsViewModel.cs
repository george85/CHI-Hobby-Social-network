using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.ViewModels
{
    public class FriendsViewModel
    {
        public User User { get; set; }
        public IEnumerable<User> Friends { get; set; }
    }
}