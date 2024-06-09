using HotelProject.Service.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CountriesController : Controller
    {
        private readonly ICountryService countryService;

        public CountriesController(ICountryService countryService)
        {
            this.countryService = countryService;
        }
        public async Task<IActionResult> Index()
        {
            var countries= await countryService.GetAllCountriesIsNonDeleted();
            return View(countries);
        }
    }
}
