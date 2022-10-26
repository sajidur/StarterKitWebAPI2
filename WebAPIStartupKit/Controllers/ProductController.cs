
using StarterKITDAL;
using StartKitBLL;
using StartKitBLL.Response;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;

namespace WebAPIStartupKit.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        public ProductController(IProductService sliderImage)
        {
            _productService= sliderImage;
        }

        [HttpGet]
        public List<Product> GetAll(int categoryId)
        {
            return _productService.GetAll(categoryId);
        }

        [HttpGet]
        public List<ProductResponse> GetTopList(int categoryId)
        {
            return _productService.GetTopList(categoryId);
        }

        [HttpGet]
        public ProductResponse GetByProductId(int productId)
        {
            return _productService.GetByProduct(productId);
        }
        [HttpPost]
        public bool Save(Product request)
        {
            var i=_productService.Save(request);
            return true;
        }
        [HttpPost]
        public bool SaveProductImage(ProductImage request)
        {
            var i = _productService.SaveProductImage(request);
            return true;
        }

    }
}
