using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProject.Data.UnitOfWors;
using HotelProject.Entity.DTOs.Category;
using HotelProject.Entity.DTOs.Country;
using HotelProject.Entity.Entities;
using HotelProject.Service.Services.Abstraction;
using HotelProject.Service.Services.Concrete;
using HotelProject.Web.ResultMessages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NToastNotify;
using System.ComponentModel.DataAnnotations;
using static HotelProject.Web.ResultMessages.Messages;

namespace HotelProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly IMapper mapper;
        private readonly IValidator<RoomCategory> validator;
        private readonly IToastNotification toastNotification;
        private readonly IUnitOfWork unitOfWork;

        public CategoriesController(ICategoriesService categoriesService, IMapper mapper, IValidator<RoomCategory> validator, IToastNotification toastNotification, IUnitOfWork unitOfWork)
        {
            this.categoriesService = categoriesService;
            this.mapper = mapper;
            this.validator = validator;
            this.toastNotification = toastNotification;
            this.unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            var items = await categoriesService.GetAllCategoriesIsNonDeleted();
            return View(items);
        }


        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDTO categoryAddDTO)
        {

            var map = mapper.Map<RoomCategory>(categoryAddDTO);
            var validationResult = await validator.ValidateAsync(map);
            if (validationResult.IsValid)
            {
                await categoriesService.CategoryAddAsync(categoryAddDTO);
                toastNotification.AddSuccessToastMessage(Messages.Country.Add(categoryAddDTO.Name), new ToastrOptions() { Title = "Uğurlu!" });

                return RedirectToAction("Index", "Categories", new { Area = "Admin" });
            }

            else
            {
                validationResult.AddToModelState(ModelState);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid categoryId)
        {
            var item = await unitOfWork.GetRepository<RoomCategory>().GetByGuidAsync(categoryId);
            var map = mapper.Map<CategoryUpdateDTO>(item);
            return View(map);
        }


        [HttpPost]
        public async Task<IActionResult> Update(CategoryUpdateDTO categoryUpdateDTO)
        {
            await categoriesService.CategoryUpdateAsync(categoryUpdateDTO);
            return RedirectToAction("Index", "Categories", new { Area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid categoryId)
        {
            await categoriesService.SafeDelete(categoryId);
            return RedirectToAction("Index", "Categories", new { Area = "Admin" });
        }

        [HttpGet]

        public async Task<IActionResult> UndoDelete()
        {
            var items = await categoriesService.GetAllCategoriesIsDeleted();
            return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> CategoryUndoDelete(Guid categoryId)
        {
            await categoriesService.CategoryUndoDelete(categoryId);
            return RedirectToAction("Index", "Categories", new { Area = "Admin" });
        }
    }

  
}
