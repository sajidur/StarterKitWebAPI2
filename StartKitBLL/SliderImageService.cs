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
   public  class SliderImageService : ISliderImageService
    {
        private ISliderImageRepository _sliderImageRepository;
        private IMapper _mapper;
        public SliderImageService(ISliderImageRepository sliderImageRepository, IMapper mapper)
        {
            this._sliderImageRepository = sliderImageRepository;
            this._mapper = mapper;
        }
        public List<SliderImage> GetAll(string position)
        {
            var salaryItems = _sliderImageRepository.GetAll(position).ToList();
            return salaryItems;
        }

        public int Save(SliderImage sliderImage)
        {
            return _sliderImageRepository.Save(sliderImage);
        }
    }
}
