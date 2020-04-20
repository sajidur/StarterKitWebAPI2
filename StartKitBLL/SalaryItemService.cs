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
            foreach (var item in salaryItems)
            {
                result.Add(new SalaryItemResponse() { CountryId = item.Country.Id, Descriptions = item.Descriptions, Id = item.Id, Name = item.Name });
            }
            return result;
        }
        public dynamic SalarySheet(int CountryId)
        {
            var salaryItems = _salaryItemRepository.GetAll(CountryId).ToList();
            dynamic expando = new ExpandoObject();

            foreach (var item in salaryItems)
            {
                AddProperty(expando, item.Name, "0");

            }
            return expando;
        }
        public static void AddProperty(ExpandoObject expando, string propertyName, object propertyValue)
        {
            // ExpandoObject supports IDictionary so we can extend it like this
            var expandoDict = expando as IDictionary<string, object>;
            if (expandoDict.ContainsKey(propertyName))
                expandoDict[propertyName] = propertyValue;
            else
                expandoDict.Add(propertyName, propertyValue);
        }

        public int Save(SalaryItemRequest salaryItemReq)
        {
            var salaryItem = new SalaryItem() {Name= salaryItemReq.Name,Descriptions=salaryItemReq.Descriptions,CountryId=salaryItemReq.CountryId};
            return _salaryItemRepository.Save(salaryItem);
        }
    }
}
