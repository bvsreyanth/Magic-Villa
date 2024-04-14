using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Api.Model.DTO
{
    public class VillaUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int Occupancy { get; set; }
        [Required]
        public int Sqft { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public String ImageUrl { get; set; }
        public String Amenity { get; set; }

    }
}
