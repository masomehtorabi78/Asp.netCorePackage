using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Areas.Admin.Controllers
{
    
    public class PublisherController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
