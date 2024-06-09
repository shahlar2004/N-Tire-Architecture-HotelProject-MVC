using AutoMapper;
using HotelProject.Data.UnitOfWors;
using HotelProject.Entity.DTOs.Country;
using HotelProject.Entity.Entities;
using HotelProject.Service.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Services.Concrete
{
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

     
        public CountryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<CountryDTO>> GetAllCountriesIsNonDeleted()
        {
            var countries = await unitOfWork.GetRepository<Country>().GetAllAsync(x=>!x.isDeleted);
            var map= mapper.Map<List<CountryDTO>>(countries);
            int a = 5;
            return map;
        }
    }
}
