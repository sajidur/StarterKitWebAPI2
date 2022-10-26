using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public interface IProductRepository
    {
        ICollection<Product> GetAll(int categoryId);
        Product GetByProduct(int productId);
        ICollection<ProductImage> GetProductImages(int productId);
        int Save(Product sliderImage);
        int SaveProductImage(ProductImage sliderImage);

    }
}
