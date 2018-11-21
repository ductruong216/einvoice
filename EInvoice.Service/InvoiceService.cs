using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using EInvoice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace EInvoice.Service
{
	public class InvoiceService : BaseService<Invoice>, IInvoiceService
	{
		private readonly IRepository<Customer> _customerRepository;
		private readonly IRepository<Product> _productRepository;
		private readonly IRepository<Unit> _unitRepository;
		private readonly IRepository<PaymentMethod> _paymentMethodRepository;
		private readonly IRepository<PurchaserCustomer> _purchaserRepository;
		private readonly IRepository<Item> _itemRepository;

		public InvoiceService(IRepository<Customer> customerRepository,
			IRepository<Invoice> repository,
			IRepository<Product> productRepository,
			IRepository<Unit> unitRepository,
			IRepository<PaymentMethod> paymentMethodRepository,
			IRepository<PurchaserCustomer> purchaserRepository,
			IRepository<Item> itemRepository,

		IUnitOfWork unitOfWork) : base(repository, unitOfWork)
		{
			_customerRepository = customerRepository;
			_productRepository = productRepository;
			_unitRepository = unitRepository;
			_paymentMethodRepository = paymentMethodRepository;
			_purchaserRepository = purchaserRepository;
			_itemRepository = itemRepository;
		}

		public void AddDraft(Invoice invoice)
		{
			invoice.Status = "Draft";
			invoice.CompanyId = 3;

			Add(invoice);
		}

		private void UpdateInvoiceCustomer(PurchaserCustomer customer, long? oldCustomerId, long? newCustomerId, long? purchaserInvoiceId)
		{
			// Update Customer
			if (oldCustomerId == newCustomerId)
			{
				customer.ID = (long)purchaserInvoiceId;
				_purchaserRepository.Update(customer);
			}
			else
			{
				_purchaserRepository.Add(customer);
				// Commit

				purchaserInvoiceId = _purchaserRepository.GetAll().Last().ID;
			}
		}

		public void UpdateInvoice(Invoice invoice)
		{ 
			try
			{
				_unitOfWork.BeginTransaction();
				if (invoice.Customer.ID == invoice.CustomerId)
				{
					invoice.PurchaserCustomer.ID = (long)invoice.PurchaserCustomerID;
					_purchaserRepository.Update(invoice.PurchaserCustomer);
				}
				else
				{
					try
					{
						_purchaserRepository.Add(invoice.PurchaserCustomer);
						_unitOfWork.SaveChanges();
					}
					catch(Exception e)
					{
						throw e;
					}
					// Commit

					invoice.PurchaserCustomerID = _purchaserRepository.GetAll().Last().ID;
				}

			

				invoice.Customer = null;

				_itemRepository.RemoveAllItem(invoice.ID);
				var items = new List<Item>(invoice.Items);
				for (int i = 0; i < invoice.Items.Count(); i++)
				{
					items[i].InvoiceId = invoice.ID;
					_itemRepository.Add(items[i]);
				}
				_unitOfWork.SaveChanges();
				invoice.Items = items;
				

				Update(invoice);

				_unitOfWork.Commit();
			}
			catch (Exception e)
			{
				_unitOfWork.Rollback();
			}
		}

		public void DeleteInvoice(int id)
		{
			var invoice = GetSingleById(id);
			invoice.isDel = true;
			Update(invoice);
		}

		public void ChangeStatus(int invoiceId)
		{
			var invoice = GetSingleById(invoiceId);
			invoice.Status = "Released";
			Update(invoice);
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