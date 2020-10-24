using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Blazor.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int MinWeight { get; set; }
        [Required]
        public int MaxWeight { get; set; }
        [Required]
        public string IconURL { get; set; }
    }
}
