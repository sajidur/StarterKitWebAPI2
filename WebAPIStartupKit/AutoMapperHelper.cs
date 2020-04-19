using AutoMapper;
using StarterKITDAL;
using StartKitBLL.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIStartupKit
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<SalaryItem, SalaryItemResponse>().ReverseMap();
            var config = new MapperConfiguration(cfg =>
            {
                //Create all maps here
                cfg.CreateMap<SalaryItem, SalaryItemResponse>().ReverseMap();
                //...
            });

            IMapper mapper = config.CreateMapper();
        }

    }
}