using Microsoft.AspNetCore.Mvc;

namespace Bai4_Web.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
