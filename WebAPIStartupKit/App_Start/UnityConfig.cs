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
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IEmailer,Emailer>();
            container.RegisterType<IContactRepository, ContactRepository>();
            container.RegisterType<INewsContentRepository, NewsContentRepository>();
            container.RegisterType<INewsContentService, NewsContentService>(); 
          //  container.RegisterType<ISalaryItemService, SalaryItemService>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<ApplicationDbContext, ApplicationDbContext>();
            container.RegisterInstance<IMapper>(UserProfile.Mapper);
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}