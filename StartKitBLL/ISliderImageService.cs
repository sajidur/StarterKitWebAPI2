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
    public interface ISliderImageService
    {
        List<SliderImage> GetAll(string type);
        int Save(SliderImage sliderImage);
    }
}
