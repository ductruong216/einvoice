using System.Collections;
using EInvoice.Common;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Repositories;
using System.Collections.Generic;

namespace EInvoice.Service
{
	public interface IProductService : IBaseService<Product>
	{
		IList<Product> GetAllDesProduct();

		bool IsUniq(string code);

		void AddProduct(Product product);

		IEnumerable<Product> GetByInvoiceID(long invoiceID);
	}

	public class ProductService : BaseService<Product>, IProductService
	{
		private IProductRepository _productRepository;
		private IUnitOfWork _unitOfWork;

		public ProductService(IProductRepository productCategory, IUnitOfWork unitOfWork) : base(productCategory, unitOfWork)
		{
			_productRepository = productCategory;
			_unitOfWork = unitOfWork;
		}

		public IList<Product> GetAllDesProduct()
		{
			var products = _productRepository.GetAllDes();
			return products;
		}

		public bool IsUniq(string code)
		{
			return _productRepository.CheckContains(x => x.Code == code);
		}

		public void AddProduct(Product product)
		{
			if (_productRepository.CheckContains(x => x.Code == product.Code)
			  )
			{
				throw new NameDuplicatedException("Product Code is exist");
			}
			_productRepository.Add(product);
		}

		public IEnumerable<Product> GetByInvoiceID(long invoiceID)
		{
			return _productRepository.GetByInvoiceID(invoiceID);
		}
	}
}