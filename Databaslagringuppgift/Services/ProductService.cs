using Databaslagringuppgift.Repositories;
using Databaslagringuppgift.Tables;
using System;
using System.Collections.Generic;

namespace Databaslagringuppgift.Services
{
    internal class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int productId)
        {
            return _productRepository.GetProductById(productId);
        }

        public void AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            _productRepository.DeleteProduct(productId);
        }
    }
}
