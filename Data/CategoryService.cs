using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Blazor.Data
{
    public class CategoryService
    {
        public ApplicationDbContext _dbContext;

        public CategoryService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<Category> GetCategory()
        {
            var categories = _dbContext.Categories.ToList();

            return categories;
        }
    }
}
