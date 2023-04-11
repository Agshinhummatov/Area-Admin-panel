using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
