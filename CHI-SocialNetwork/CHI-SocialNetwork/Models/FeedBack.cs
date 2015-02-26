using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.Models
{
    public enum FeedBackType
    {
        None = 0,
        Like = 1,
        Dislike = 2
    }
    public class FeedBack
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        //public int HobbyId { get; set; }
        //[ForeignKey("HobbyId")]
        //public virtual Hobby Hobby { get; set; }

       
        public int AuthorId { get; set; }
         [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }
        public FeedBackType Type { get; set; }
    }
}