using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IProductService
    {
        bool AddProduct(Product product);
        List<Product> GetProducts();
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
        Product GetProductById(int id);

    }
}
