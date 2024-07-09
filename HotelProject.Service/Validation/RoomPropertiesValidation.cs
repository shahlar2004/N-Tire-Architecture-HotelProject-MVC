using FluentValidation;
using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Validation
{
    public class RoomPropertiesValidation:AbstractValidator<RoomProperties>
    {
        public RoomPropertiesValidation()
        {
            RuleFor(x=>x.AdultCount).NotEmpty();
            RuleFor(x => x.PricePerNight).NotEmpty();
            RuleFor(x=>x.RoomCommanName).NotEmpty().MinimumLength(1).MaximumLength(50);
            RuleFor(x=>x.Description).NotEmpty().MinimumLength(5).MaximumLength(50);
            RuleFor(x => x.ChildCount).NotEmpty();
            RuleFor(x=>x.RoomCount).NotEmpty();
            RuleFor(x=>x.BathCount).NotEmpty();
            RuleFor(x=>x.BedCount).NotEmpty();
        }
    }
}
