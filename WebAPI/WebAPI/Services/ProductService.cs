using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;
        public ProductService()
        {
            _products = new List<Product>();
        }
        public bool AddProduct(Product product)
        {
            if(product == null)
            {
                return false;
            }
            else
            {
                _products.Add(product);

                return true;
            }
        }

        public bool DeleteProduct(int id)
        {
            var product = GetProductById(id);

            if(product == null)
            {
                return false;
            }
            else
            {
                _products.Remove(product);

                return true;
            }
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public bool UpdateProduct(Product updatedProduct)
        {
            if(updatedProduct == null)
            {
                return false;
            }
            var product = GetProductById(updatedProduct.Id);

            if(product == null)
            {
                return false;
            }
            else
            {
                product = updatedProduct;
            }

            return true;
        }
    }
}
