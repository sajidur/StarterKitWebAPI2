
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

        [HttpGet]
        public List<SliderImage> GetSliders(string SliderPosition)
        {
            return _sliderImage.GetAll(SliderPosition);
        }
        public bool Post(SliderImage request)
        {
            var httpRequest = HttpContext.Current.Request;
            if (httpRequest.Files.Count > 0)
            {
                foreach (string file in httpRequest.Files)
                {
                    var postedFile = httpRequest.Files[file];
                    var filePath = HttpContext.Current.Server.MapPath("~/" + postedFile.FileName);
                    postedFile.SaveAs(filePath);
                    request.ImageUrl = filePath;
                    _sliderImage.Save(request);
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }


        }
    }
}
