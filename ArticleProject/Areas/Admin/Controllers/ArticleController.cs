using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Areas.Admin.Controllers
{
    
    public class ArticleController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
