using Microsoft.AspNetCore.Mvc;

namespace MbkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
    }
}