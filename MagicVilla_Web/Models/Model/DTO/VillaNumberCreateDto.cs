﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Model.DTO
{
    public class VillaNumberCreateDto
    {

        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
    }
}
