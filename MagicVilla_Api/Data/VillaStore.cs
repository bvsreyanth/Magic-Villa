﻿using MagicVilla_Api.Model.DTO;

namespace MagicVilla_Api.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto { Id = 1, Name = "Pool",Sqft=100,Occupancy=4 },
            new VillaDto { Id = 2, Name = "View",Sqft=300,Occupancy=2 }
        };
    }
}

