using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Two_Datacontext_One_wEB.Models
{
    public class Post
    {
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
         [Required]
        public string UrlName { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string UpdatedBy {get;set;}
        public DateTime? SoftDeleted { get; set; }
        public string DeletedBy { get; set; }
        public List<Comment> CommentList { get; set; }
        [AllowHtml]
        [Required]
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public Guid FolderName { get; set; }

    }
}
