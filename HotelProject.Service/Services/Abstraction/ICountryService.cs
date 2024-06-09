using HotelProject.Entity.DTOs.Country;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Services.Abstraction
{
    public interface ICountryService
    {
        Task<List<CountryDTO>> GetAllCountriesIsNonDeleted();
    }
}
