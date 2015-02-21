﻿using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }
        public IEnumerable<Hobby> Hobbies { get; set; }
    }
}