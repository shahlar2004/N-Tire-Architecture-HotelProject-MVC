using AutoMapper;
using HotelProject.Entity.DTOs.Country;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.AutoMapper
{
    public class CountryProfile:Profile
    {
        public CountryProfile()
        {
            CreateMap<CountryDTO,Country>().ReverseMap();    
            CreateMap<Country,CountryAddDTO>().ReverseMap();
            CreateMap<CountryUpdateDTO, Country>().ReverseMap();
        }
    }
}
