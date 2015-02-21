using CHI_SocialNetwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHI_SocialNetwork.DataAccessLayer.Interfaces
{
    public interface ICommentRepository:IRepository<Comment>
    {
        Comment GetBy(int id);
        IEnumerable<Comment> GetFor(Hobby hobby);
        void AddFor(Comment comment,Hobby hobby);
    }
}
