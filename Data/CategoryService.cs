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
            var categories = _dbContext.Categories.AsNoTracking().OrderBy(x => x.MinWeight).ToList();

            return categories;
        }

        public Category GetCategoryById(int id)
        {
            return _dbContext.Categories.FirstOrDefault(x => x.Id.Equals(id));
        }

        public string Create(Category category)
        {
            var categories = _dbContext.Categories.ToList();

            //Check if new category's weight range is overlap
            var isOverlap = categories.Any(x => 
                x.MinWeight < category.MinWeight && category.MinWeight < x.MaxWeight ||
                x.MinWeight < category.MaxWeight && category.MaxWeight < x.MaxWeight
            );

            if (!isOverlap)
            {
                _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();

                return "";
            }

            return "New item's range is overlap.";
        }

        public string Update(Category category)
        {
            var categories = _dbContext.Categories.ToList();

            //Check if updating category's weight range is overlap
            var isOverlap = categories.Any(x =>
                x.MinWeight < category.MinWeight && category.MinWeight < x.MaxWeight ||
                x.MinWeight < category.MaxWeight && category.MaxWeight < x.MaxWeight
            );

            if (!isOverlap)
            {
                _dbContext.Categories.Update(category);
                _dbContext.SaveChanges();

                return "";
            }

            return "Updating item's range is overlap.";
        }

        public void Delete(Category category)
        {
            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();
        }
    }
}
