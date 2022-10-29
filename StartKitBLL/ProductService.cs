using AutoMapper;
using StarterKITDAL;
using StarterKITDAL.Repository;
using StartKitBLL.Request;
using StartKitBLL.Response;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartKitBLL
{
   public  class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;
        public ProductService(IProductRepository sliderImageRepository, IMapper mapper)
        {
            this._productRepository = sliderImageRepository;
            this._mapper = mapper;
        }

        public List<Product> GetAll(int categoryId)
        {
            var salaryItems = _productRepository.GetAll(categoryId).ToList();
            return salaryItems;
        }
        public List<ProductResponse> GetTopList(int categoryId)
        {
            List<ProductResponse> list = new List<ProductResponse>();
            var products = _productRepository.GetAll(categoryId).ToList();
            foreach (var product in products)
            {
                var productResponse = _mapper.Map<ProductResponse>(product);
                productResponse.Images = _productRepository.GetProductImages(product.Id).ToList();
                list.Add(productResponse);
            }
            return list;
        }

        public ProductResponse GetByProduct(int productId)
        {
            var product = _productRepository.GetByProduct(productId);
            if (product!=null)
            {
               var productResponse= _mapper.Map<ProductResponse>(product);
                productResponse.Images = _productRepository.GetProductImages(productId).ToList();
                return productResponse;
            }
            else
            {
               return new ProductResponse();
            }

        }

        public int Save(Product product)
        {
            return _productRepository.Save(product);
        }

        public int SaveProductImage(ProductImage request)
        {
            return _productRepository.SaveProductImage(request);
        }
    }
}
