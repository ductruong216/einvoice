using EInvoice.Common;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using EInvoice.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;

namespace EInvoice.Service
{
	public class ProductService : BaseService<Product>, IProductService
	{
		private readonly IRepository<Product> _productRepository;

		public ProductService(IRepository<Product> productCategory, IUnitOfWork unitOfWork) : base(productCategory, unitOfWork)
		{
			_productRepository = productCategory;
		}

		public IList<Product> GetAllDesProduct()
		{
			var products = _productRepository.GetMulti(x=>x.isDel ==false).OrderByDescending(x=>x.ID).ToList();
			return products;
		}

		public bool IsUniq(string code)
		{
			return _productRepository.CheckContains(x => x.Code == code);
		}

		public void DeleteProduct(int id)
		{
			var product = GetSingleById(id);
			product.isDel = true;
			Update(product);
		}

		public void AddProduct(Product product)
		{
			if (_productRepository.CheckContains(x => x.Code == product.Code)
			)
			{
				throw new NameDuplicatedException("Product Code is exist");
			}
			Add(product);
		}

		public IEnumerable<Product> GetByInvoiceID(long invoiceID)
		{
			return _productRepository.GetByInvoiceID(invoiceID);
		}

		public IDbSet<Product> GetProductsSource()
		{
			return _productRepository.ProductSource();
		}

		public long GetId(Product modelProduct)
		{
			throw new System.NotImplementedException();
		}
	}
}