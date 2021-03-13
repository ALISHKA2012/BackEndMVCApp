using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Author
    {
        public int Id { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}