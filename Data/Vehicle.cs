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
        [Required]
        public int Id { get; set; }
        [Required]
        public string Owner { get; set; }
        [Required]
        public Manufacturer Manufacturer { get; set; }
        [Required]
        public DateTime ManufacturingYear { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Weight { get; set; }
    }

    public enum Manufacturer
    {
        Mazda,
        Mercedes,
        Honda,
        Ferrari,
        Toyota
    }
}
