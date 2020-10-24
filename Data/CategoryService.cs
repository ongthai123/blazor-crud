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

        public List<Category> GetCategories()
        {
            var categories = _dbContext.Categories.ToList();

            return categories;
        }

        public Category GetCategoryById(int id)
        {
            return _dbContext.Categories.FirstOrDefault(x => x.Id.Equals(id));
        }

        public string Create(Category category)
        {
            var categories = _dbContext.Categories.ToList();

            var isOverlap = categories.Any(x => x.MinWeight <= category.MinWeight && category.MaxWeight <= x.MaxWeight);

            if (!isOverlap)
            {
                _dbContext.Add(category);
                _dbContext.SaveChanges();

                return "Successful";
            }

            return "New item's range is overlap or not covered the gap of current ranges.";
        }

        public void Update(Category category)
        {
            _dbContext.Update(category);
            _dbContext.SaveChanges();
        }

        public void Delete()
        {

        }
    }
}
