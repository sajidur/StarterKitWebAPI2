using StarterKITDAL;
using StartKitBLL.Request;
using StartKitBLL.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartKitBLL
{
    public interface IProductService
    {
        List<Product> GetAll(int categoryId);
        ProductResponse GetByProduct(int productId);
        List<ProductResponse> GetTopList(int categoryId);
        bool Save(Product sliderImage);
        bool SaveProductImage(ProductImage request);
    }
}
