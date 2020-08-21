using System.Collections.Generic;

namespace Patterns.Chap3.Model
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts(CustomerType customerType)
        {
            var strategy = DiscountFactory.GetDiscountStrategy(customerType);

            var products = _productRepository.FindAll();

            products.Apply(strategy);

            return products;
        }
    }
}
