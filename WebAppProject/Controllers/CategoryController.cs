using Microsoft.AspNetCore.Mvc;

namespace WebAppProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
