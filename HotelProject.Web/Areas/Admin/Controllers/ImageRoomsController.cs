using HotelProject.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace HotelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ImageRoomsController : Controller
    {
        private readonly IRoomImgsService roomImgsService;

        public ImageRoomsController(IRoomImgsService roomImgsService)
        {
            this.roomImgsService = roomImgsService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items= await roomImgsService.GetAllRoomsPropertiesForImagesIsNonDeleted();
            return View(items);
        }



        [HttpGet]
        public async Task<IActionResult> ImgsAdd()
        {
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> ImgPost()
        {
            return View();
        }
    }
}
