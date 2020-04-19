using AutoMapper;
using StarterKITDAL.Repository;
using StartKitBLL.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartKitBLL
{
   public  class SalaryItemService : ISalaryItemService
    {
        private ISalaryItemRepository _salaryItemRepository;
        private IMapper _mapper;
        public SalaryItemService(ISalaryItemRepository salaryItemRepository,IMapper mapper)
        {
            this._salaryItemRepository = salaryItemRepository;
            this._mapper = mapper;
        }
        public List<SalaryItemResponse> GetAll(int CountryId)
        {
            List<SalaryItemResponse> result = new List<SalaryItemResponse>();
            var salaryItems = _salaryItemRepository.GetAll(CountryId).ToList();
            //foreach (var item in salaryItems)
            //{
            //    result.Add(new SalaryItemResponse() { CountryId = item.CountryId, Descriptions = item.Descriptions, Id = item.Id, Name = item.Name });
            //}
            result = _mapper.Map <List<SalaryItemResponse>>(salaryItems);
            return result;
        }
    }
}
