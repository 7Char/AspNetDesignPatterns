namespace Patterns.Chap3.Model
{
    class NullDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal originalSalePrice)
        {
            return originalSalePrice;
        }
    }
}
