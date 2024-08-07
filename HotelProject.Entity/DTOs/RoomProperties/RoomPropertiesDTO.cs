﻿using HotelProject.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entity.DTOs.RoomProperties
{
    public class RoomPropertiesDTO
    {
        public Guid Id { get; set; }
        public string RoomCommanName { get; set; }
        public int PricePerNight { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomCount { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool isInternet  { get; set; }
        public byte BathCount { get; set; }
        public byte BedCount { get; set; }
        public RoomCategory RoomCategory { get; set; }
        public Hotel Hotel { get; set; }
    }
}
