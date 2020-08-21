using System.Collections.Generic;

namespace Patterns.Chap3.Model
{
    public static class ProductExtensions
    {
        public static void Apply(this IList<Product> products, IDiscountStrategy strategy)
        {
            foreach (var product in products)
            {
                product.Apply(strategy);
            }
        }

        public static void Apply(this Product product, IDiscountStrategy strategy)
        {
            product.Price.SetDiscountStrategy(strategy);
        }
    }
}
