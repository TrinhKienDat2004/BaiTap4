using Microsoft.AspNetCore.Mvc;

namespace Bai4_Web.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
