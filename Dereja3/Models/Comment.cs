using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dereja3.Models
{
    public class Comment
    {

        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public string CommentatorId { get; set; }
        public int ProductId { get; set; }


        public ApplicationUser Commentator { get; set; }

        public Product Product { get; set; }
    }
}
