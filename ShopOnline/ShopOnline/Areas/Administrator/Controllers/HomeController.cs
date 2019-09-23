using System.Web.Mvc;
using ShopOnline.Areas.Administrator.Common;
using ShopOnline.DAO;
using ShopOnline.Models;

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
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.Login(username, password);
                if (result)
                {
                    var user = dao.GetById(username);
                    var UserSession = new UserSession();
                    UserSession.UserName = user.UserName;
                    UserSession.UserId = user.Id;
                    Session.Add(CommonConstants.USER_SESSION, UserSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //ModelState.AddModelError("","Tài khoản hoặc mật khẩu không đúng!!!");
                    ViewBag.ErrorMessage = "Tài khoản hoặc mật khẩu không đúng";
                    return View("Login");
                }
            }
            return View("Index");
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Users entity)
        {
            var result = new UserDAO().Insert(entity);
            if (ModelState.IsValid)
            {
                if (result > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Thêm mới thất bại!";
                    return View();
                }
            }
            return View("Index");
        }
    }
}