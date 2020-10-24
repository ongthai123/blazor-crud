//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace CRUD_Blazor.Data
//{
//    public class DbInitializer
//    {
//        public static void Initialize(ApplicationDbContext context)
//        {
//            context.Database.EnsureCreated();

//            //Look for any Categories
//            if (context.Categories.Any())
//            {
//                return; //DB has been seeded
//            }

//            var categories = new Category[]
//            {
//                new Category {Id = 1, Name = "Light", WeightMin = 0, WeightMax = 500, IconURL = ""},
//                new Category {Id = 2, Name = "Medium", WeightMin = 500, WeightMax = 2500, IconURL = ""},
//                new Category {Id = 3, Name = "Heavy", WeightMin = 2500, WeightMax = 999999, IconURL = ""},

//            };

//            context.Categories.AddRange(categories);
//            context.SaveChanges();
//        }
//    }
//}
