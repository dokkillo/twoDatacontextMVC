using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Datacontext_One_wEB.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int ParentCommentId { get; set; }
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public bool IsValid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Censured { get; set; }
       
    }
}
