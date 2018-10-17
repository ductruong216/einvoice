

// Files related to ASP.NET Identity duplicate the Microsoft ASP.NET Identity file structure and contain initial Microsoft comments.

using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Implementation;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using EInvoice.Repository;
using EInvoice.Service;
using Owin;

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

			// Register interface
			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
			builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

			builder.RegisterType<InvoiceEntities>().AsSelf().InstancePerRequest();

			// Repository
			builder.RegisterType<BaseRepository<Invoice>>().As<IRepository<Invoice>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Customer>>().As<IRepository<Customer>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Product>>().As<IRepository<Product>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<User>>().As<IRepository<User>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Unit>>().As<IRepository<Unit>>().InstancePerRequest();

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