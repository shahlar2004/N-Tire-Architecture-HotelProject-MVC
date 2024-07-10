﻿using HotelProject.Entity.DTOs.RoomImgs;
using HotelProject.Entity.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service.Helpers.Images
{
    public interface IImageHelper
    {
        Task<ImageUploadedDTO> Upload(string name, IFormFile formFile, ImageType imageType, string folderName = null);

        void Delete(string imageName);
    }
}
