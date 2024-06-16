using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.ApplicationLayer.Products
{
    public interface IProductService
    {
        ProductDto Get(Guid productId);
        ProductDto Add(ProductDto product);
    }
}
