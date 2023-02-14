using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleServices articleServices;
        public ArticleController(IArticleServices articleServices)
        {
            this.articleServices = articleServices;
        }
        public  async Task<IActionResult> Index()
        {
            var articles = await articleServices.GetAllArticlesWithCategoryNonDeletedAsync(); 
            return View(articles);
        }
    }
}