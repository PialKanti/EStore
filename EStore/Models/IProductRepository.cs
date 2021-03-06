using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStore.Models
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        List<Product> GetAllProduct();
        Product Create(Product product);
    }
}
