using System.Collections.Generic;

namespace Patterns.Chap3.Model
{
    public interface IProductRepository
    {
        List<Product> FindAll();
    }
}
