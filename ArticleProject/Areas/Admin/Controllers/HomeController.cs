using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
