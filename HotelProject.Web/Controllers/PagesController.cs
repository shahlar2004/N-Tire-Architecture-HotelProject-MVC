using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Booking()
        {
            return View();
        }
    }
}
