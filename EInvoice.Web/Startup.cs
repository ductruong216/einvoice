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
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

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

			// Register interface
			builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
			builder.RegisterType<InvoiceEntities>().As<IDbFactory>().InstancePerRequest();

			builder.RegisterType<InvoiceEntities>().AsSelf().InstancePerRequest();

			// Repository
			builder.RegisterType<BaseRepository<Invoice>>().As<IRepository<Invoice>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Customer>>().As<IRepository<Customer>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Product>>().As<IRepository<Product>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<User>>().As<IRepository<User>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Unit>>().As<IRepository<Unit>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Company>>().As<IRepository<Company>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<PaymentMethod>>().As<IRepository<PaymentMethod>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Pattern>>().As<IRepository<Pattern>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Item>>().As<IRepository<Item>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<PurchaserCustomer>>().As<IRepository<PurchaserCustomer>>().InstancePerRequest();
			builder.RegisterType<BaseRepository<Serial>>().As<IRepository<Serial>>().InstancePerRequest();

			builder.RegisterType<CustomerService>().As<ICustomerService>().InstancePerRequest();
			builder.RegisterType<ProductService>().As<IProductService>().InstancePerRequest();
			builder.RegisterType<UnitService>().As<IUnitService>().AsSelf();
			builder.RegisterType<InvoiceService>().As<IInvoiceService>().AsSelf();
			builder.RegisterType<CompanyService>().As<ICompanyService>().AsSelf();
			builder.RegisterType<PaymentMethodService>().As<IPaymentMethodService>().AsSelf();
			builder.RegisterType<PatternService>().As<IPatternService>().InstancePerRequest();
			builder.RegisterType<ItemService>().As<IItemService>().InstancePerRequest();
			builder.RegisterType<PurchaserCustomer>().As<PurchaserCustomer>().InstancePerRequest();

			var container = builder.Build();
			ObjectFactory.Container = container;
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);

			
		}
	}
}