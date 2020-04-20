using AutoMapper;
using StarterKITDAL;
using StarterKITDAL.Repository;
using StartKitBLL;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace WebAPIStartupKit
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ISalaryItemService, SalaryItemService>();
            container.RegisterType<ISalaryItemRepository, SalaryItemRepository>();
            container.RegisterType<IRulesRepository, RulesRepository>();
            container.RegisterType<IRulesService, RulesService>(); 
          //  container.RegisterType<ISalaryItemService, SalaryItemService>();
            container.RegisterType<IConditionRepository, ConditionRepository>();
            container.RegisterType<ApplicationDbContext, ApplicationDbContext>();
            container.RegisterInstance<IMapper>(UserProfile.Mapper);
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}