using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public class SliderImageRepository : ISliderImageRepository
    {
        ApplicationDbContext _context;
        public SliderImageRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public ICollection<SliderImage> GetAll(string position)
        {
            return _context.SliderImages.Where(a => a.SliderPosition == position).ToList();
        }
        public int Save(SliderImage  sliderImage)
        {
            _context.SliderImages.Add(sliderImage);
            return _context.SaveChanges();
        }
    }
}
