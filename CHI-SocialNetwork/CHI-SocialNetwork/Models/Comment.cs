using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

       
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
       
        public virtual User Author { get; set; }

        public string Text { get; set; }
    }
}