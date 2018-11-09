using EInvoice.Data.Data;
using System.Collections.Generic;
using System.Data.Entity;

namespace EInvoice.Data.Services
{
	public interface IProductService : IBaseService<Product>
	{
		IList<Product> GetAllDesProduct();

		bool IsUniq(string code);

		void DeleteProduct(int id);

		void AddProduct(Product product);

		IEnumerable<Product> GetByInvoiceID(long invoiceID);

		IDbSet<Product> GetProductsSource();
		long GetId(Product modelProduct);
	}
}