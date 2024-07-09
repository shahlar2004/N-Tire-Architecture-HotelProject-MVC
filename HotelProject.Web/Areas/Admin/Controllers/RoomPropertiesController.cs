using AutoMapper;
using HotelProject.Data.UnitOfWors;
using HotelProject.Entity.Entities;
using HotelProject.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using HotelProject.Entity.DTOs.Room;
using HotelProject.Entity.DTOs.RoomProperties;
using FluentValidation;
using HotelProject.Entity.DTOs.Category;
using HotelProject.Web.ResultMessages;
using NToastNotify;
using FluentValidation.AspNetCore;

namespace HotelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoomPropertiesController : Controller
    {
        private readonly IRoomPropertiesService roomPropertiesService;
        private readonly ICountryService countryService;
        private readonly ICategoriesService categoriesService;
        private readonly IUnitOfWork unitOfWork;
        private readonly IValidator<RoomProperties> validator;
        private readonly IMapper mapper;
        private readonly IToastNotification toastNotification;

        public RoomPropertiesController(IRoomPropertiesService roomPropertiesService, ICountryService countryService, ICategoriesService categoriesService, IUnitOfWork unitOfWork, IValidator<RoomProperties> validator,IMapper mapper,IToastNotification toastNotification)
        {
            this.countryService = countryService;
            this.categoriesService = categoriesService;
            this.unitOfWork = unitOfWork;
            this.validator = validator;
            this.mapper = mapper;
            this.toastNotification = toastNotification;
            this.roomPropertiesService=roomPropertiesService;   

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var items = await roomPropertiesService.GetAllRoomPropertiesIsNotDeleted();
            int a = 5;
            return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
            {
            var categories = await categoriesService.GetAllCategoriesIsNonDeleted();
            var hotels = await unitOfWork.GetRepository<Hotel>().GetAllAsync(x=>!x.isDeleted, x=>x.Country);
            return View(new RoomPropertiesAddDTO { Categories = categories, Hotels=hotels });
        }

        [HttpPost]
        public async Task<IActionResult> Add(RoomPropertiesAddDTO roomPropertiesAddDTO)
        {
            var categories = await categoriesService.GetAllCategoriesIsNonDeleted();
            var hotels = await unitOfWork.GetRepository<Hotel>().GetAllAsync(x => !x.isDeleted, x => x.Country);
            var map= mapper.Map<RoomProperties> (roomPropertiesAddDTO);
            var validationResult = validator.Validate(map);
            if (validationResult.IsValid)
            {
                await roomPropertiesService.createRoomProperties(roomPropertiesAddDTO);
                toastNotification.AddSuccessToastMessage(Messages.Country.Add(roomPropertiesAddDTO.RoomCommanName), new ToastrOptions() { Title = "Uğurlu!" });

                return RedirectToAction("Index", "RoomProperties", new { Area = "Admin" });

            }

            else
            {
                validationResult.AddToModelState(ModelState);
            }
            return View(new RoomPropertiesAddDTO { Categories = categories, Hotels = hotels });
        }
        //[HttpPost]
        //public async Task<IActionResult> Add(RoomAddDTO roomAddDTO)
        //{
        //    var countries = await countryService.GetAllCountriesIsNonDeleted();
        //    var categories = await categoriesService.GetAllCategoriesIsNonDeleted();
        //    return View(new RoomAddDTO { Categories = categories, Countries = countries });
        //}
    }
}
