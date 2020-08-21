namespace Patterns.Chap3.Model
{
    public class Price
    {
        private IDiscountStrategy _discountStrategy;

        private decimal _rrp;

        private decimal _selingPrice;

        public decimal RRP => _rrp;

        public decimal SellingPrice => _discountStrategy.ApplyDiscount(_selingPrice);

        public decimal Discount
        {
            get
            {
                if (RRP > SellingPrice)
                {
                    return RRP - SellingPrice;
                }

                return 0;
            }
        }

        public decimal Savings
        {
            get
            {
                if (RRP > SellingPrice)
                {
                    return 1 - (SellingPrice / RRP);
                }

                return 0;
            }
        }

        public Price(decimal rrp, decimal sellingPrice)
        {
            _rrp = rrp;
            _selingPrice = sellingPrice;
            _discountStrategy = new NullDiscountStrategy();
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }
    }
}
