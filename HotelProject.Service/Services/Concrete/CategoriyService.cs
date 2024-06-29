using AutoMapper;
using HotelProject.Data.UnitOfWors;
using HotelProject.Entity.DTOs.Category;
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
    public class CategoriyService:ICategoriesService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoriyService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
     public async Task<List<CategoryDTO>> GetAllCategoriesIsNonDeleted()
     {
            
       var items= await unitOfWork.GetRepository<RoomCategory>().GetAllAsync(x=>!x.isDeleted);
       var map= mapper.Map<List<CategoryDTO>>(items);
        return (map);
     }
        public async Task CategoryAddAsync(CategoryAddDTO categoryAddDTO)
        {
            var map = mapper.Map<RoomCategory>(categoryAddDTO);
            await unitOfWork.GetRepository<RoomCategory>().AddAsync(map);
            await unitOfWork.SaveAsync();
        }

        public async Task CategoryUpdateAsync(CategoryUpdateDTO categoryUpdateDTO)
        {
            var item = await unitOfWork.GetRepository<RoomCategory>().GetByGuidAsync(categoryUpdateDTO.Id);
            item.Name = categoryUpdateDTO.Name;
            await unitOfWork.GetRepository<RoomCategory>().UpdateAsync(item);
            await unitOfWork.SaveAsync();
        }

        public async Task SafeDelete(Guid Id)
        {
            var item = await unitOfWork.GetRepository<RoomCategory>().GetByGuidAsync(Id);
            item.isDeleted = true;
            await unitOfWork.GetRepository<RoomCategory>().UpdateAsync(item);
            await unitOfWork.SaveAsync();
        }


        public async Task<List<CategoryDTO>> GetAllCategoriesIsDeleted()
        {
            var items = await unitOfWork.GetRepository<RoomCategory>().GetAllAsync(x => x.isDeleted);
            var map = mapper.Map<List<CategoryDTO>>(items);
            return map;
        }


        public async Task CategoryUndoDelete(Guid Id)
        {
            var item = await unitOfWork.GetRepository<RoomCategory>().GetByGuidAsync(Id);
            item.isDeleted = false;
            await unitOfWork.GetRepository<RoomCategory>().UpdateAsync(item);
            await unitOfWork.SaveAsync();
        }


    }
}
