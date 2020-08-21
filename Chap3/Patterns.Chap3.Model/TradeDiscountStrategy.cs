namespace Patterns.Chap3.Model
{
    class TradeDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal originalSalePrice)
        {
            return originalSalePrice * 0.95M;
        }
    }
}
