using Microsoft.AspNetCore.Mvc;

namespace BookShoping_App.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
