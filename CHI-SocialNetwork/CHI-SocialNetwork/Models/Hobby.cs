using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime DateCreated { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<FeedBack> Feedback { get; set; }


        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<Video> Videos { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }
       
       
    }
}