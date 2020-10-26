using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Blazor.Data
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Owner { get; set; }
        [Required]
        public Manufacturer Manufacturer { get; set; }
        [Required]
        public string ManufacturingYear { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Weight { get; set; }
    }

    public enum Manufacturer
    {
        Ferrari,
        Honda,
        Mazda,
        Mercedes,
        Toyota
    }

    public enum OrderBy
    {
        Owner = 0,
        Manufacturer = 1,
        ManufacturingYear = 2,
        Weight = 3
    }
}
