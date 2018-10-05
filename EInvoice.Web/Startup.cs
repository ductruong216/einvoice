using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Implementation;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Repositories;
using EInvoice.Service;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(EInvoice.Web.Startup))]

// Files related to ASP.NET Identity duplicate the Microsoft ASP.NET Identity file structure and contain initial Microsoft comments.

namespace EInvoice.Web
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigAutoFac(app);
			ConfigureAuth(app);
		}

		private void ConfigAutoFac(IAppBuilder app)
		{
			var builder = new ContainerBuilder();

			// AutoFac.MVC5
			builder.RegisterControllers(Assembly.GetExecutingAssembly());

			// AutoFac.WebApi2
			// Register WebAPI controllers
			//builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

			// Register interface
			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
			builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

			builder.RegisterType<InvoiceEntities>().AsSelf().InstancePerRequest();

			// Repository
			//builder.RegisterAssemblyTypes(typeof(CustomerRepostitory).Assembly)
			//	.Where(_ => _.Name.EndsWith("Repository"))
			//	.AsImplementedInterfaces().InstancePerRequest();

			builder.RegisterType<CustomerRepostitory>().As<ICustomerRepository>().InstancePerRequest();
			builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerRequest();
			builder.RegisterType<UnitRepository>().As<IUnitRepository>().InstancePerRequest();
			builder.RegisterType<InvoiceRepository>().As<IInvoiceRepository>().InstancePerRequest();

			// Service
			//builder.RegisterAssemblyTypes(typeof(CustomerService).Assembly)
			//  .Where(_ => _.Name.EndsWith("Service"))
			//  .AsImplementedInterfaces().InstancePerRequest();

			builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerRequest();
			builder.RegisterType<ProductService>().As<IProductService>().InstancePerRequest();
			builder.RegisterType<UnitService>().As<IUnitService>().AsSelf();
			builder.RegisterType<InvoiceService>().As<IInvoiceService>().AsSelf();


			Autofac.IContainer container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
			GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);

			 //ObjectFactory.Container = container;
		}
	}
}