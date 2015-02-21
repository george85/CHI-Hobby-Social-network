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

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<FeedBack> Feedback { get; set; }


        public ICollection<Image> Images { get; set; }

        public ICollection<Video> Videos { get; set; }

        public string Description { get; set; }
        public int UserId { get; set; }
       
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}