using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Blazor.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public string IconURL { get; set; }
    }
}
