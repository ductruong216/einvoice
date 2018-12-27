using EInvoice.Common;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using EInvoice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

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
        private readonly IRepository<Serial> _serialRepository;

        public InvoiceService(IRepository<Customer> customerRepository,
            IRepository<Invoice> repository,
            IRepository<Product> productRepository,
            IRepository<Unit> unitRepository,
            IRepository<PaymentMethod> paymentMethodRepository,
            IRepository<PurchaserCustomer> purchaserRepository,
            IRepository<Item> itemRepository,
            IRepository<Serial> serialRepository,

        IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _unitRepository = unitRepository;
            _paymentMethodRepository = paymentMethodRepository;
            _purchaserRepository = purchaserRepository;
            _itemRepository = itemRepository;
            _serialRepository = serialRepository;
        }

        public void AddDraft(Invoice invoice)
        {
            invoice.Status = "Draft";
            invoice.CompanyId = 3;
            invoice.InWord = Enumration.Num2Word((double)invoice.GrandTotalAmount);
            Add(invoice);
        }

        private void UpdateInvoiceCustomer(PurchaserCustomer customer,
                                        long? oldCustomerId,
                                        long? newCustomerId,
                                        long? purchaserInvoiceId)
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
                    catch (Exception e)
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

        public void Issue(int invoiceId)
        {
            var invoice = GetSingleById(invoiceId);
            invoice.No = GetInvoiceNumber(invoice);
            invoice.Status = InvoiceStatus.Issued.ToString();
            invoice.ReleaseDate = DateTime.Now;

            //invoice.ReleaseDate = Utility.GetNistTime();
            Update(invoice);
        }

        public int GetInvoiceNumber(Invoice invoice)
        {
            return _repository.GetMulti(x => x.PatternId == invoice.PatternId
                                      && x.SeriesId == invoice.SeriesId)
                       .OrderByDescending(x => x.No)
                       .First().No + 1;
        }

        public IList<Serial> GetSeries()
        {
            return _serialRepository.GetAll();
        }

        public IEnumerable<Serial> GetSeriesByPattern(int id)
        {
            return _serialRepository.GetSeriesByPattern(id);
        }

        public void SaveAndRelease(Invoice invoice)
        {
            invoice.Status = InvoiceStatus.Issued.ToString();
            invoice.CompanyId = 3;
            invoice.No = GetInvoiceNumber(invoice);
            invoice.ReleaseDate = DateTime.Now;
            invoice.InWord = Enumration.Num2Word((double)invoice.GrandTotalAmount);
            Add(invoice);
        }

        public IList<Invoice> GetAllDraft()
        {
            return _repository.GetMulti(x => x.isDel == false
                                             && x.Status == InvoiceStatus.Draft.ToString())
                .OrderByDescending(x => x.ID)
                .ToList();
        }

        public IList<Invoice> GetAllRelease()
        {
            return _repository.GetMulti(x => x.isDel == false
                                             && x.Status == InvoiceStatus.Issued.ToString())
                .OrderByDescending(x => x.ReleaseDate)
                .ToList();
        }

        public void CancelIssuedInvoice(int invoiceId)
        {
            var invoice = GetSingleById(invoiceId);
            invoice.Status = InvoiceStatus.Cancel.ToString();
            Update(invoice);
            // duoc thay the bang hoa don nao
            // tien hanh navigate toi create new invoice
        }

        public IList<Invoice> GetAllCancel()
        {
            return _repository.GetMulti(x => x.isDel == false
                                             && x.Status == InvoiceStatus.Cancel.ToString())
                .OrderByDescending(x => x.ReleaseDate)
                .ToList();
        }

        public IList<Invoice> GetAllReplace()
        {
            return _repository.GetMulti(x => x.isDel == false
                                             && x.Status == InvoiceStatus.Replace.ToString())
                .OrderByDescending(x => x.ReleaseDate)
                .ToList();
        }

      
        public Invoice CancelInvoice(int invoiceId)
        {
            var invoice = GetSingleById(invoiceId);
            invoice.Status = InvoiceStatus.Cancel.ToString();
            Update(invoice);
            return invoice;
        }

        public void ReplaceIssuedInvoice(int invoiceId)
        {
            var invoice = CancelInvoice(invoiceId);
        }


        public void NewReplace(Invoice invoice)
        {
            invoice.Status = InvoiceStatus.Replace.ToString();
            invoice.CompanyId = 3;
            invoice.ReleaseDate = DateTime.Now;
            invoice.InWord = Enumration.Num2Word((double)invoice.GrandTotalAmount);
            invoice.Customer.Code = _customerRepository.GetSingleById(invoice.CustomerId).Code;
            var invoiceCancel = GetSingleById(invoice.ID);
            invoice.ReplaceFor = invoiceCancel.No;
            Add(invoice);
        }

        // Bao cao tinh hinh su dung hoa don

    }
}