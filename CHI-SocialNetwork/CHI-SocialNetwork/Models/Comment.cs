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

        public int HobbyId { get; set; }
        [ForeignKey("HobbyId")]
        public virtual Hobby Hobby { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public string Text { get; set; }
    }
}