

using Microsoft.AspNetCore.Mvc;

namespace Gap.SuperZapatos.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}