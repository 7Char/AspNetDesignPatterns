using Patterns.Chap3.Service;

namespace Patterns.Chap3.Presentation
{
    public class ProductListPresenter
    {
        private IProductListView _productListView;

        private ProductListService _productListService;

        public ProductListPresenter(IProductListView productListView, ProductListService productListService)
        {
            _productListView = productListView;
            _productListService = productListService;
        }

        public void Display()
        {
            ProductListRequest request = new ProductListRequest();
            request.CustomerType = _productListView.CustomerType;
            ProductListResponse response = _productListService.GetAllProducts(request);

            if (response.Success)
            {
                _productListView.Display(response.Products);
            }
            else
            {
                _productListView.ErrorMessage = response.Message;
            }
        }
    }
}
