using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 1)]

        public string Text { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Article Article { get; set; }
        public int ArticleId { get; set; }
    }
}