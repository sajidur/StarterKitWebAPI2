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
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<ICategoryService, CategoryService>();

            //  container.RegisterType<ISalaryItemService, SalaryItemService>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<ApplicationDbContext, ApplicationDbContext>();
            container.RegisterInstance<IMapper>(UserProfile.Mapper);
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<ICategoryRepository, CategoryRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}