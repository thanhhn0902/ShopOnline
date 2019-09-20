using System.Web.Mvc;

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
    }
}