using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStore.Models
{
    public class MockProductRepository : IProductRepository
    {
        private List<Product> productList;

        public MockProductRepository()
        {
            productList = new List<Product>()
            {
                new Product { Id = 1, Name = "Apple AirPods Pro", CategoryId = 1, Price = 25000},
                new Product { Id = 2, Name = "Angels and demons", CategoryId = 2, Price = 2000},
                new Product { Id = 3, Name = "Olaplex Hair Perfector No 3 Repairing Treatment", CategoryId = 3, Price = 3500},
                new Product { Id = 4, Name = "Anne Klein Women's Genuine Diamond Dial Bangle Watch", CategoryId = 4, Price = 5000},
                new Product { Id = 5, Name = "Nike Air Max", CategoryId = 5, Price = 12000}
            };
        }

        public List<Product> GetAllProduct()
        {
            return productList;
        }

        public Product GetProduct(int id)
        {
            return productList.FirstOrDefault(product => id == product.Id);
        }

        public Product Create(Product product)
        {
            product.Id = productList.Max(p => p.Id) + 1;
            productList.Add(product);
            return product;
        }
    }
}
