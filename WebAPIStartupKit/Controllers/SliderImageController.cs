
using StarterKITDAL;
using StartKitBLL;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;

namespace WebAPIStartupKit.Controllers
{
    public class SliderImageController : ApiController
    {
        private readonly ISliderImageService _sliderImage;
        public SliderImageController(ISliderImageService sliderImage)
        {
            _sliderImage= sliderImage;
        }

        [HttpGet]
        public List<SliderImage> GetSliders(string SliderPosition)
        {
            return _sliderImage.GetAll(SliderPosition);
        }
        public bool Post(SliderImage request)
        {
            var i=_sliderImage.Save(request);
            return true;

        }
    }
}
