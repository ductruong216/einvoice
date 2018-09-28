using AutoMapper;
using EInvoice.Data.Data;
using EInvoice.Web.Models;

namespace EInvoice.Web.Mappings
{
	public class AutoMapperConfiguration
	{
		public static void Configure()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<Data.Data.Customer, CustomerViewModel>();
				cfg.CreateMap<User, LoginModel>();
				cfg.CreateMap<Product, ProductViewModel>();
			});
		}
	}
}