using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2)]

        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }

        public Tag()
        {
            Articles = new HashSet<Article>();
        }
    }
}