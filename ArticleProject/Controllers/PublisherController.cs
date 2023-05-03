using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Controllers
{
    public class PublisherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
