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
            return map;
        }


        public async Task CountryAddAsync(CountryAddDTO countryAddDTO)
        {
            var map = mapper.Map<Country>(countryAddDTO);
            await unitOfWork.GetRepository<Country>().AddAsync(map);
            await unitOfWork.SaveAsync();
        }

        public async Task SoftDelete(Guid Id)
        {
            var item= await unitOfWork.GetRepository<Country>().GetByGuidAsync(Id);
            item.isDeleted = true;
            await unitOfWork.GetRepository<Country>().UpdateAsync(item);
            await unitOfWork.SaveAsync();
        }

        public async Task CountryUpdateAsync(CountryUpdateDTO countryUpdateDTO)
        {
            var item = await unitOfWork.GetRepository<Country>().GetByGuidAsync(countryUpdateDTO.Id);
            item.Name = countryUpdateDTO.Name;
            await unitOfWork.GetRepository<Country>().UpdateAsync(item);
            await unitOfWork.SaveAsync();
        }


        public async Task<List<CountryDTO>> GetAllCountriesIsDeleted()
        {
            var items= await unitOfWork.GetRepository<Country>().GetAllAsync(x=>x.isDeleted);
            var map=mapper.Map<List<CountryDTO>>(items);
            return map;
        }


        public async Task CountryUndoDelete(Guid Id)
        {
            var item = await unitOfWork.GetRepository<Country>().GetByGuidAsync(Id);
            item.isDeleted = false;
            await unitOfWork.GetRepository<Country>().UpdateAsync(item);
            await unitOfWork.SaveAsync();
        }
    }
}
