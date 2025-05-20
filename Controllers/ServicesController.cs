using Microsoft.AspNetCore.Mvc;

namespace Bai4_Web.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
