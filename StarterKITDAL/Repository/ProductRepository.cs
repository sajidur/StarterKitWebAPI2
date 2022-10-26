using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public ICollection<Product> GetAll(int categoryId)
        {
            return _context.Products.Where(a => a.CategoryId == categoryId).ToList();
        }

        public Product GetByProduct(int productId)
        {
            return _context.Products.Where(a => a.Id == productId).FirstOrDefault();
        }

        public ICollection<ProductImage> GetProductImages(int productId)
        {
            return _context.ProductImages.Where(a => a.ProductId==productId).ToList();
        }

        public int Save(Product sliderImage)
        {
            _context.Products.Add(sliderImage);
            return _context.SaveChanges();
        }

        public int SaveProductImage(ProductImage sliderImage)
        {
            _context.ProductImages.Add(sliderImage);
            return _context.SaveChanges();
        }
    }
}
