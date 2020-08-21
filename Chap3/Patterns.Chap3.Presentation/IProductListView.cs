using Patterns.Chap3.Model;
using Patterns.Chap3.Service;
using System.Collections.Generic;

namespace Patterns.Chap3.Presentation
{
    public interface IProductListView
    {
        void Display(IList<ProductViewModel> products);

        CustomerType CustomerType { get; }

        string ErrorMessage { set; }
    }
}
