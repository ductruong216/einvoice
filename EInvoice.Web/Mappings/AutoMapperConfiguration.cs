﻿using AutoMapper;
using EInvoice.Data.Data;
using EInvoice.Web.Models;
using Customer = EInvoice.Data.Data.Customer;

namespace EInvoice.Web.Mappings
{
	public class AutoMapperConfiguration
	{
		public static void Configure()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<Customer, CustomerViewModel>();
				cfg.CreateMap<Product, ProductViewModel>();
				cfg.CreateMap<User, LoginModel>();
				cfg.CreateMap<BankAccount, BankAccountViewModel>();
				cfg.CreateMap<Company, CompanyViewModel>();
				cfg.CreateMap<DigitalSignature, DigitalSignatureViewModel>();
				cfg.CreateMap<Unit, UnitViewModel>();
				cfg.CreateMap<Invoice, InvoiceViewModel>();
				cfg.CreateMap<Pattern, PatternViewModel>();
				cfg.CreateMap<PurchaserCustomer, PurchaserCustomerViewModel>();
                cfg.CreateMap<CustomerViewModel, Customer>();
                cfg.CreateMap<ProductViewModel, Product>();


            });
		}
	}
}