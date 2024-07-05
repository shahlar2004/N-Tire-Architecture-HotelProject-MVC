using AutoMapper;
using HotelProject.Data.UnitOfWors;
using HotelProject.Entity.Entities;
using HotelProject.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using HotelProject.Entity.DTOs.Room;

namespace HotelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomPropertiesController : Controller
    {
        private readonly IRoomPropertiesService roomsService;
        private readonly ICountryService countryService;
        private readonly ICategoriesService categoriesService;

        public RoomPropertiesController(IRoomPropertiesService roomsService, ICountryService countryService, ICategoriesService categoriesService)
        {
            this.roomsService = roomsService;
            this.countryService = countryService;
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index()
        {
            //var items = await roomsService.GetAllRoomsIsNotDeleted();
            //return View(items);

            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> AddAsync()
        //{
        //    var countries = await countryService.GetAllCountriesIsNonDeleted();
        //    var categories = await categoriesService.GetAllCategoriesIsNonDeleted();
        //    return View(new RoomAddDTO { Categories = categories, Countries = countries });
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add(RoomAddDTO roomAddDTO)
        //{
        //    var countries = await countryService.GetAllCountriesIsNonDeleted();
        //    var categories = await categoriesService.GetAllCategoriesIsNonDeleted();
        //    return View(new RoomAddDTO { Categories = categories, Countries = countries });
        //}
    }
}
