using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Areas.Admin.ViewComponents
{
    public class AdminSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AdminSidebar");
        }
    }

}
