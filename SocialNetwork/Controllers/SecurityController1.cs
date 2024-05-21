using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;

namespace SocialNetwork.Controllers
{
    public class SecurityController1 : Controller
    {
        public ActionResult Logon()
        {
            return View();
        }
        public ActionResult Register()
        {

            return View();

        }
    }
}
