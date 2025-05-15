using Microsoft.AspNetCore.Mvc;

namespace Bai4_Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
