using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using SocialNetwork.Services;
using SocialNetwork.ViewModels;

namespace SocialNetwork.Controllers
{
    public class SecurityController : Controller
    {
        private ISecurityService _service = null;
        public SecurityController(ISecurityService service)
        {
            _service = service;
        }
        public ActionResult Logon()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            _service.SaveUserToDB(model);
            return View();

        }
    }
}
