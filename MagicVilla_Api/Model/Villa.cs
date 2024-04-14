using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_Api.Model
{
    public class Villa
    {
        // scalar properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Auto-increment Id
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Details { get; set; }
        public double Rate { get; set; }
        public int Sqft { get; set; }
        public string ImageUrl { get; set; }
        public String Amenity { get; set; }

        public int Occupancy { get; set; }
    }
}
