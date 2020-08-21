using Patterns.Chap3.Model;
using Patterns.Chap3.Respository;
using System;

namespace Patterns.Chap3.Service
{
    public class ProductListService
    {
        private ProductService _productService;

        public ProductListService()
        {
            var productRepository = new ProductRepository();
            _productService = new ProductService(productRepository);
        }

        public ProductListResponse GetAllProducts(ProductListRequest request)
        {
            var response = new ProductListResponse();

            try
            {
                var products = _productService.GetAllProducts(request.CustomerType);

                response.Products = products.ToViewModel();
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
