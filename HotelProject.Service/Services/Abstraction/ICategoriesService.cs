using HotelProject.Entity.DTOs.Category;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Services.Abstraction
{
    public interface ICategoriesService
    {   
        Task<List<CategoryDTO>> GetAllCategoriesIsNonDeleted();
        Task CategoryAddAsync(CategoryAddDTO categoryAddDTO);
        Task CategoryUpdateAsync(CategoryUpdateDTO categoryUpdateDTO);
        Task SafeDelete(Guid Id);
        Task<List<CategoryDTO>> GetAllCategoriesIsDeleted();
       Task CategoryUndoDelete(Guid Id);


    }
}
