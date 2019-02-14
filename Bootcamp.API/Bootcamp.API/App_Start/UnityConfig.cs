using BusinessLogic.Service;
using BusinessLogic.Service.Master;
using Common.Interface;
using Common.Interface.Master;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Bootcamp.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // ubah yang default menjadi seperti dibawah
            //this is service area
            container.RegisterType<iSupplierService, SupplierService>();

            //this is repository area
            container.RegisterType<iSupplierRepository, SupplierRepository>();


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}