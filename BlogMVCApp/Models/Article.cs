using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 2)]
        public string Title { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime WrittenDate { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public string ShortDestcription { get; set; }

        public uint ViewCount { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Category> Categories { get; set; }
        public Menu Menu { get; set; }
        public int MenuId { get; set; }

        public Article()
        {
            Comments = new HashSet<Comment>();
            Tags = new HashSet<Tag>();
            Categories = new HashSet<Category>();
        }


    }
}