using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVCApp.Models
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 2)]

        public string Name{ get; set; }
        [Required]
        public bool IsActive { get; set; }
        public string ControllerName { get; set; }
        public byte Order { get; set; }
        public string ActionName { get; set; }

        public ICollection<Article> Articles { get; set; }
        public Menu()
        {
            Articles = new HashSet<Article>();
        }
    }
}