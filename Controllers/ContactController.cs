using Microsoft.AspNetCore.Mvc;

namespace Bai4_Web.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
