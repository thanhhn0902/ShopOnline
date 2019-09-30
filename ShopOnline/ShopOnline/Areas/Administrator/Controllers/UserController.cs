using ShopOnline.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Areas.Administrator.Controllers
{
    public class UserController : Controller
    {
        // GET: Administrator/User
        public ActionResult Index()
        {
            if (ModelState.IsValid)
            {
                var list = new UserDAO().GetAll();
                return View(list);
            }
            return View();
        }
        
    }
}