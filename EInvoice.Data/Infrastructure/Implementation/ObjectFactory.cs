using Autofac;
using Autofac.Core;

namespace EInvoice.Data.Infrastructure.Implementation
{
	public static class ObjectFactory
	{
		public static IContainer Container { get; set; }

		public static T GetInstance<T>()
		{
			return Container.Resolve<T>();
		}
	}
}