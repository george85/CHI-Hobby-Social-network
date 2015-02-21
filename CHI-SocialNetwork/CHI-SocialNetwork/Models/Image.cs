using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CHI_SocialNetwork.Models
{
    public class Image
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public int HobbyId { get; set; }
        [ForeignKey("HobbyId")]
        public virtual Hobby Hobby { get; set; }
    }
}