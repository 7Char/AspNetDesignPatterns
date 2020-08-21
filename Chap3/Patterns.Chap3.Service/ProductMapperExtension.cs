using Patterns.Chap3.Model;
using System.Collections.Generic;

namespace Patterns.Chap3.Service
{
    public static class ProductMapperExtension
    {
        private const string FORMAT_CURRENCY = "{0:C2}";
        private const string FORMAT_PERCENTAGE = "#%";

        public static ProductViewModel ToViewModel(this Product product)
        {
            var vm = new ProductViewModel
            {
                ProductId = product.Id,
                Name = product.Name,
                RRP = string.Format(FORMAT_CURRENCY, product.Price.RRP),
                SellingPrice = string.Format(FORMAT_CURRENCY, product.Price.SellingPrice)
            };

            if (product.Price.Discount > 0)
            {
                vm.Discount = string.Format(FORMAT_CURRENCY, product.Price.Discount);
            }

            if (product.Price.Savings > 0 && product.Price.Savings < 1)
            {
                vm.Savings = product.Price.Savings.ToString(FORMAT_PERCENTAGE);
            }

            return vm;
        }

        public static List<ProductViewModel> ToViewModel(this List<Product> products)
        {
            var pvm = new List<ProductViewModel>();

            foreach (var product in products)
            {
                var vm = product.ToViewModel();
                pvm.Add(vm);
            }
            return pvm;
        }
    }
}
