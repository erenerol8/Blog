using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    { 
        private readonly IArticleServices articleServices;

        public HomeController(IArticleServices articleServices)
        {
        this.articleServices = articleServices;
        }
       
        public async Task<IActionResult> Index()
        {
           var articles = await articleServices.GetAllArticlesAsync();
            return View(articles);
        }
    }
}
