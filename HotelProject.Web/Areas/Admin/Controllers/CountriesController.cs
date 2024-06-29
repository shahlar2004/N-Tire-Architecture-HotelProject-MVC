using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProject.Data.UnitOfWors;
using HotelProject.Entity.DTOs.Category;
using HotelProject.Entity.DTOs.Country;
using HotelProject.Entity.Entities;
using HotelProject.Service.Services.Abstraction;
using HotelProject.Web.ResultMessages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using NToastNotify;

namespace HotelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CountriesController : Controller
    {
        private readonly ICountryService countryService;
        private readonly IValidator<Country> validator;
        private readonly IMapper mapper;
        private readonly IToastNotification toastNotification;
        private readonly IUnitOfWork unitOfWork;

        public CountriesController(ICountryService countryService, IValidator<Country> validator, IMapper mapper, IToastNotification toastNotification, IUnitOfWork unitOfWork)
        {
            this.countryService = countryService;
            this.validator = validator;
            this.mapper = mapper;
            this.toastNotification = toastNotification;
            this.unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var countries= await countryService.GetAllCountriesIsNonDeleted();
            return View(countries);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CountryAddDTO countryAddDTO)
        {
            var map = mapper.Map<Country>(countryAddDTO);
            var validationResult = await validator.ValidateAsync(map);
             if (validationResult.IsValid)
            {
                await countryService.CountryAddAsync(countryAddDTO);
                toastNotification.AddSuccessToastMessage(Messages.Country.Add(countryAddDTO.Name), new ToastrOptions() { Title = "Uğurlu!" });

                return RedirectToAction("Index","Countries", new {Area="Admin"});
            }

            else
            {
                validationResult.AddToModelState(ModelState);
            }

            return View();
           
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid countryId)
        {
            await countryService.SoftDelete(countryId);
            return RedirectToAction("Index", "Countries", new { Area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid countryId)
        {
            var item=  await unitOfWork.GetRepository<Country>().GetByGuidAsync(countryId);
            var map= mapper.Map<CountryUpdateDTO>(item);
            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CountryUpdateDTO countryUpdateDTO)
        {

            await countryService.CountryUpdateAsync(countryUpdateDTO);
            return RedirectToAction("Index", "Countries", new { Area = "Admin" });
        }

        [HttpGet]

        public async Task<IActionResult> UndoDelete()
        {
            var items = await countryService.GetAllCountriesIsDeleted();
            return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> CountryUndoDelete(Guid countryId)
        {
            await countryService.CountryUndoDelete(countryId);
            return RedirectToAction("Index", "Countries", new { Area = "Admin" });
        }
    }
}
