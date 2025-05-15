using Microsoft.AspNetCore.Mvc;

namespace Bai4_Web.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
