using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Web.ViewComponents
{
    public class SiteFooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
