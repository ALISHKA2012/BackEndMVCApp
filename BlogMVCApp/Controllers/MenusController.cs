using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogMVCApp.Data;

namespace BlogMVCApp.Controllers
{
    public class MenusController : Controller
    {
        private readonly BlogContext _blogContext;
        public MenusController()
        {
            _blogContext = new BlogContext();
        }
        public PartialViewResult AllMenus()
        {
            var menus = _blogContext.Menus.Where( m => m.IsActive == true).ToList();
            return PartialView(menus);
        }
    }
}