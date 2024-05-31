using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Rooms()
        {
            return View();
        }
    }
}
