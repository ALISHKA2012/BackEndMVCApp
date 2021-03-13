using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 2)]

        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 8)]

        public string Password { get; set; }
        public bool IsActive { get; set; }
        [Required]
        [EmailAddress]

        public string Email { get; set; }
        public bool IsAuthor { get; set; }
        public Author Author { get; set; }
        public int? AuthorId { get; set; }
    }
}