using AutoMapper;
using StarterKITDAL;
using StarterKITDAL.Repository;
using StartKitBLL.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartKitBLL
{
    public class NewsContentService:INewsContentService
    {
        private INewsContentRepository  _rulesRepository;
        private IMapper _mapper;
        public NewsContentService(INewsContentRepository rulesRepository, IMapper mapper)
        {
            this._rulesRepository = rulesRepository;
            this._mapper = mapper;
        }
        public int Save(NewsContent newsContent)
        {
           return  _rulesRepository.Save(newsContent);

        }
        public List<NewsContent> GetList(string type)
        {
           return  _rulesRepository.GetAll(type).ToList();
        }
    }
}
