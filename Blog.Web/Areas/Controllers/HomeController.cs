using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
