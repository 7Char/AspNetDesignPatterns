using System.Collections.Generic;

namespace Patterns.Chap3.Service
{
    public class ProductListResponse
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public List<ProductViewModel> Products { get; set; }
    }
}
