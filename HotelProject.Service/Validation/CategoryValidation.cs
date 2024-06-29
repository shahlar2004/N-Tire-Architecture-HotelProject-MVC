using AutoMapper;
using FluentValidation;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Validation
{
    public class CategoryValidation:AbstractValidator<RoomCategory>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.Name).
                NotEmpty().
                MinimumLength(3)
                .MaximumLength(50);
        }
    }
}
