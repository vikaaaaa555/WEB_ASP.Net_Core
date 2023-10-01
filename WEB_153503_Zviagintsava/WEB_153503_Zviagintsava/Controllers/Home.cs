using Microsoft.AspNetCore.Mvc;

namespace WEB_153503_Zviagintsava.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
	}
}
