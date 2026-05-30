using System.ComponentModel.DataAnnotations;

namespace CarManager
{
    public class Car
    {
        [Key]
        public string? Vin { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public string? Cost { get; set; } 
    }
}
