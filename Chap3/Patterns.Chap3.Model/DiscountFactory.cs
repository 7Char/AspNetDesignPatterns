namespace Patterns.Chap3.Model
{
    public static class DiscountFactory
    {
        public static IDiscountStrategy GetDiscountStrategy(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.Trade:
                    return new TradeDiscountStrategy();
                default:
                    return new NullDiscountStrategy();
            }
        }
    }
}
