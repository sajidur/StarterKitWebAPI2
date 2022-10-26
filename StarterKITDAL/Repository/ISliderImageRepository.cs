using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public interface ISliderImageRepository
    {
        ICollection<SliderImage> GetAll(string position);
        int Save(SliderImage sliderImage);
    }
}
