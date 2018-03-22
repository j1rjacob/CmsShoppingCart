using System.Web.Mvc;
using CmsShoppingCart.Models.ViewModels.Account;

namespace CmsShoppingCart.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return Redirect("~/account/login");
        }
        // GET: account/login
        public ActionResult Login()
        {
            //Confirm user is not logged in
            string username = User.Identity.Name;

            if (!string.IsNullOrEmpty(username))
                return RedirectToAction("user-profile");

            //Return view
            return View();
        }
        //GET: /account/create-account
        [ActionName("create-account")]
        [HttpGet]
        public ActionResult CreateAccount()
        {
            return View("CreateAccount");
        }
        //GET: /account/create-account
        [ActionName("create-account")]
        [HttpPost]
        [HttpGet]
        public ActionResult CreateAccount(UserVM model)
        {
            return View("CreateAccount");
        }
    }
}