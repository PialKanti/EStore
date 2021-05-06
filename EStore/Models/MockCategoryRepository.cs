using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStore.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> categoryList;

        public MockCategoryRepository()
        {
            categoryList = new List<Category>()
            {
                new Category{Id = 1, Name = "Electronics"},
                new Category{Id = 2, Name = "Books"},
                new Category{Id = 3, Name = "Health & Beauty"},
                new Category{Id = 4, Name = "Women's Fashion"},
                new Category{Id = 5, Name = "Men's Fashion"}
            };
        }

        public Category GetCategory(int id)
        {
            return categoryList.FirstOrDefault(category => id == category.Id);
        }
    }
}
