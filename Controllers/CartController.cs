using Microsoft.AspNetCore.Mvc;

namespace Bai4_Web.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
