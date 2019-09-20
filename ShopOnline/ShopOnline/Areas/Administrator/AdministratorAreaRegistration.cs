using System.Web.Mvc;

namespace ShopOnline.Areas.Administrator
{
    public class AdministratorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Administrator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Administrator_default",
                "Administrator/{controller}/{action}/{id}",
                new { Controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "ShopOnline.Areas.Administrator.Controllers" }
            );
        }
    }
}