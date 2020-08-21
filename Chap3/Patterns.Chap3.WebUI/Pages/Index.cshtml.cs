using Patterns.Chap3.Model;
using Patterns.Chap3.Presentation;
using Patterns.Chap3.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Patterns.Chap3.WebUI.Pages
{
    public class IndexModel : PageModel, IProductListView
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProductListPresenter _presenter;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _presenter = new ProductListPresenter(this, new ProductListService());
        }

        public CustomerType CustomerType { get; set; }

        public IList<ProductViewModel> Products { get; set; }

        public string ErrorMessage { get; set; }

        public bool HasError => !string.IsNullOrEmpty(ErrorMessage);

        public void Display(IList<ProductViewModel> products)
        {
            Products = products;
        }

        public void OnGet([FromQuery] CustomerType type)
        {
            CustomerType = type;
            _presenter.Display();
        }
    }
}
