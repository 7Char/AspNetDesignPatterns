namespace Patterns.Chap3.Model
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal originalSalePrice);
    }
}
