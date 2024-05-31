using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
