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
        private IProductRepository _sliderImageRepository;
        private IMapper _mapper;
        public ProductService(IProductRepository sliderImageRepository, IMapper mapper)
        {
            this._sliderImageRepository = sliderImageRepository;
            this._mapper = mapper;
        }

        public List<Product> GetAll(int categoryId)
        {
            var salaryItems = _sliderImageRepository.GetAll(categoryId).ToList();
            return salaryItems;
        }
        public List<ProductResponse> GetTopList(int categoryId)
        {
            List<ProductResponse> list = new List<ProductResponse>();
            var products = _sliderImageRepository.GetAll(categoryId).ToList();
            foreach (var product in products)
            {
                var productResponse = _mapper.Map<ProductResponse>(product);
                productResponse.Images = _sliderImageRepository.GetProductImages(product.Id).ToList();
                list.Add(productResponse);
            }
            return list;
        }

        public ProductResponse GetByProduct(int productId)
        {
            var product = _sliderImageRepository.GetByProduct(productId);
            if (product!=null)
            {
               var productResponse= _mapper.Map<ProductResponse>(product);
                productResponse.Images = _sliderImageRepository.GetProductImages(productId).ToList();
                return productResponse;
            }
            else
            {
               return new ProductResponse();
            }

        }

        public bool Save(Product sliderImage)
        {
            throw new NotImplementedException();
        }

        public bool SaveProductImage(ProductImage request)
        {
            throw new NotImplementedException();
        }
    }
}
