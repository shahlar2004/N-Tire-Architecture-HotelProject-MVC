using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Services()
        {
            return View();
        }
    }
}
