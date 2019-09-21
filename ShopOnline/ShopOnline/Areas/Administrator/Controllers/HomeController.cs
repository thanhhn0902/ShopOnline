using System.Web.Mvc;
using DATA.DAO;
using ShopOnline.Areas.Administrator.Common;
using ShopOnline.Areas.Administrator.Models;

namespace ShopOnline.Areas.Administrator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Administrator/Home
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Leftsidebar()
        {
            return PartialView();
        }
        public PartialViewResult Topsidebar()
        {
            return PartialView();
        }
        public PartialViewResult Bottomsidebar()
        {
            return PartialView();
        }
        public ActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.Login(username, password);
                if (result)
                {
                    var user = dao.GetById(username);
                    var UserSession = new UserVm();
                    UserSession.UserName = user.UserName;
                    UserSession.UserName = user.Password;
                    Session.Add(CommonConstants.USER_SESSION,UserSession);
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("","Tài khoản hoặc mật khẩu không đúng!!!");
                }
            }
            return View("Index");
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}