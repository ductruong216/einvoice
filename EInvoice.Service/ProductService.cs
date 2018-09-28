using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Repositories;

namespace EInvoice.Service
{
	public interface IProductService : IBaseService<Product>
	{
		IList<Product> GetAllDesProduct();
	}

	public class ProductService : BaseService<Product>, IProductService
	{
		IProductRepository _productRepository;
		IUnitOfWork _unitOfWork;
		public ProductService(IProductRepository productCategory, IUnitOfWork unitOfWork) : base(productCategory, unitOfWork)
		{
			_productRepository = productCategory;
			_unitOfWork = unitOfWork;
		}


		public IList<Product> GetAllDesProduct()
		{
			return _productRepository.GetAllDes();
		}
	}
}