using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;

namespace EInvoice.Service
{
	public class InvoiceService : BaseService<Invoice>, IInvoiceService
	{
		private readonly IRepository<Customer> _customerRepository;
		private readonly IRepository<Product> _productRepository;
		private readonly IRepository<Unit> _unitRepository;
		private readonly IRepository<PaymentMethod> _paymentMethodRepository;

		public InvoiceService(IRepository<Customer> customerRepository,
			IRepository<Invoice> repository,
			IRepository<Product> productRepository,
			IRepository<Unit> unitRepository,
			IRepository<PaymentMethod> paymentMethodRepository,
			IUnitOfWork unitOfWork) : base(repository, unitOfWork)
		{
			_customerRepository = customerRepository;
			_productRepository = productRepository;
			_unitRepository = unitRepository;
			_paymentMethodRepository = paymentMethodRepository;
		}

		public void AddDraft(Invoice invoice)
		{
			invoice.CompanyId = 3;

			Add(invoice);
		}
	}
}

//	public void AddDraft(Invoice invoice)
//{
//	invoice.CompanyId = 3;

//	// Set customer code ID

//	var customer = _customerRepository.GetAll()
//		.FirstOrDefault(x => x.Code == invoice.Customer.Code);
//	// If customer exist
//	if (customer != null)
//	{
//		invoice.CustomerId = customer.ID;
//	}
//	else
//	{
//		customer = invoice.Customer;
//		_customerRepository.Add(customer);
//		invoice.CustomerId = customer.ID;
//	}
//	invoice.Customer = null;
//	invoice.Items = SetInvoiceItem(invoice);
//	Add(invoice);
//}

//private void AddNewItemProduct(Product product)
//{
//	var maxProductId = _productRepository.GetAll().Last().ID;
//	var index = maxProductId + 1;
//	var randomCode = "SP" + index;
//	var newProduct = product;
//	newProduct.Code = randomCode;
//	// Need to check again when add new product -> maybe split number behind product Code
//	_productRepository.Add(newProduct);
//}

//private IList<Item> SetInvoiceItem(Invoice invoice)
//{
//	var items = new List<Item>(invoice.Items);
//	for (int i = 0; i < items.Count(); i++)
//	{
//		var product = _productRepository.GetAll().FirstOrDefault(x => x.Code == items[i].Product.Code);
//		// Case 1: If Product is exist => Items.ProductID -> current ID
//		if (product != null)
//		{
//			items[i].ProductId = product.ID;
//		}
//		// Case 2: Customer unavailable
//		else
//		{
//			var unit = _unitRepository.GetAll().FirstOrDefault(x => x.Name == items[i].Product.Unit.Name);
//			// 2.1: Unit is exist => Take id of unit
//			if (unit != null)
//			{
//				items[i].Product.UnitID = unit.ID;
//			}
//			// 2.2: Unit is unavailable
//			// 1. Create Unit
//			// 2. Get new Unit ID
//			// 3. Add Product
//			else
//			{
//				var newUnit = new Unit();
//				newUnit.Name = items[i].Product.Unit.Name;
//				_unitRepository.Add(newUnit);
//				var unitId = _unitRepository.GetAll().FirstOrDefault(x => x.Name == newUnit.Name).ID;
//				items[i].Product.UnitID = unitId;
//			}
//			items[i].Product.Unit = null;
//			AddNewItemProduct(items[i].Product);
//			items[i].ProductId = items[i].Product.ID;
//		}

//		items[i].Product = null;
//	}

//			//	return items;
//		}
//	}
//}