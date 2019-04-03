using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MNSX.DAL;
using MNSX.Model;

namespace MNSX.Web.Controllers
{
    public class ListController : Controller
    {
        BlogDAL bodal = new BlogDAL();
        public IActionResult Index()
        {
            List<Blog> list = bodal.GetList(" sort = 0 ORDER BY createdate DESC");


            return View(list);
        }
    }
}