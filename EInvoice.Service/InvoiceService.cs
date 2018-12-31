using EInvoice.Common;
using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using EInvoice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Report = EInvoice.Data.DTO.Report;

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
        private readonly IRepository<Pattern> _patternRepository;

        public InvoiceService(IRepository<Customer> customerRepository,
            IRepository<Invoice> repository,
            IRepository<Product> productRepository,
            IRepository<Unit> unitRepository,
            IRepository<PaymentMethod> paymentMethodRepository,
            IRepository<PurchaserCustomer> purchaserRepository,
            IRepository<Item> itemRepository,
            IRepository<Serial> serialRepository,
            IRepository<Pattern> patternRepository,

        IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _unitRepository = unitRepository;
            _paymentMethodRepository = paymentMethodRepository;
            _purchaserRepository = purchaserRepository;
            _itemRepository = itemRepository;
            _serialRepository = serialRepository;
            _patternRepository = patternRepository;
        }

        public void AddDraft(Invoice invoice)
        {
            invoice.Status = "Draft";
            invoice.CompanyId = 3;
            invoice.InWord = Enumration.Num2Word((double)invoice.GrandTotalAmount);
            invoice.CreatedDate = DateTime.Now;
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
                invoice.CreatedDate = DateTime.Now;
                invoice.InWord = Enumration.Num2Word((double)invoice.GrandTotalAmount);
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

        public void SaveAndIssue(Invoice invoice)
        {
            invoice.Status = InvoiceStatus.Issued.ToString();
            invoice.CompanyId = 3;
            invoice.No = GetInvoiceNumber(invoice);
            invoice.ReleaseDate = DateTime.Now;
            invoice.CreatedDate = DateTime.Now;
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
            invoice.CancelDate = DateTime.Now;
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
            invoice.CreatedDate = DateTime.Now;
            invoice.InWord = Enumration.Num2Word((double)invoice.GrandTotalAmount);
            invoice.Customer.Code = _customerRepository.GetSingleById(invoice.CustomerId).Code;
            var invoiceCancel = GetSingleById(invoice.ID);
            invoice.ReplaceFor = invoiceCancel.No;
            Add(invoice);
        }

        // BAO CAO TINH HINH SU DUNG HOA DON

        public IList<Report> ReportOnUseInvoices(int priod, int year)
        {
            // Tao list chua 8 object Report voi pattern va serial tuong ung
            var listReport = new List<Report>();

            var listPattern = _patternRepository.GetAll();

            var totalPattern = listPattern.Count();

            // Attributes
            IList<Invoice> listIssued = new List<Invoice>();
            IList<Invoice> listCanceled = new List<Invoice>();
            var ListAllInvoice = new List<Invoice>();
            string patternName;
            string serialName;
            int totalAllInvoice;
            int totalBegining;
            var listCanceledNo = new List<int>();
            // Get pattern va serial de tao doi tuong Report
            if (priod == 1 && year == 2018)
            {
                for (int i = 0; i < totalPattern; i++)
                {
                    for (int j = 0; j < listPattern.ElementAt(i).Serials.Count(); j++)
                    {
                        patternName = listPattern.ElementAt(i).Name;
                        serialName = listPattern.ElementAt(i).Serials.ElementAt(j).Name;
                        listIssued = ListIssueInvoice(priod, year, patternName, serialName);
                        listCanceled = ListCancelInvoice(priod, year, patternName, serialName);
                        ListAllInvoice = listCanceled.Concat(listIssued).OrderBy(x => x.No).ToList();
                        totalBegining = 1000;
                        for (int k = 0; k < listCanceled.Count(); k++)
                        {
                            var cancelNo = listCanceled.ElementAt(k).No;
                            listCanceledNo.Add(cancelNo);
                        }

                        var report = new Report();
                        report.InvoiceType = "VAT Invoice";
                        report.Pattern = patternName;
                        report.Serial = serialName;

                        report.TotalBegining = totalBegining;
                        report.FromBuyNo = 1;
                        report.ToBuyNo = Math.Max(1, totalBegining);

                        report.FromBeginingNo = null;
                        report.ToBeginingNo = null;

                        //TotalAllInvoice = listIssued.Count() + listCanceled.Count(),
                        report.TotalAllInvoice = ListAllInvoice.Count();
                        if (ListAllInvoice.FirstOrDefault() != null)
                        {
                            report.FromAllInvoice = ListAllInvoice.FirstOrDefault().No;
                            report.ToAllInvoice = ListAllInvoice.LastOrDefault().No;
                            report.FromClosingStock = ListAllInvoice.LastOrDefault().No + 1;
                        }
                        else
                        {
                            report.FromAllInvoice = null;
                            report.ToAllInvoice = null;
                            report.FromClosingStock = null;
                        }


                        report.TotalIssued = listIssued.Count();
                        report.TotalCanceled = listCanceled.Count();

                        report.ListCanceled = new List<int>(listCanceledNo);

                        report.TotalClosingStock = totalBegining - ListAllInvoice.Count();

                        report.ToClosingStock = totalBegining;

                        listReport.Add(report);
                       
                    }
                    listCanceledNo.Clear();}
               
                return listReport;
            }

            else
            {
                for (int i = 0; i < totalPattern; i++)
                {
                    for (int j = 0; j < listPattern.ElementAt(i).Serials.Count(); j++)
                    {
                        listCanceledNo.Clear();
                        patternName = listPattern.ElementAt(i).Name;
                        serialName = listPattern.ElementAt(i).Serials.ElementAt(j).Name;
                        listIssued = ListIssueInvoice(priod, year, patternName, serialName);
                        listCanceled = ListCancelInvoice(priod, year, patternName, serialName);
                        ListAllInvoice = listCanceled.Concat(listIssued).OrderBy(x => x.No).ToList();
                        totalBegining = CalTotalClosingStock(priod - 1, year, patternName, serialName);
                        for (int k = 0; k < listCanceled.Count(); k++)
                        {
                            var cancelNo = listCanceled.ElementAt(k).No;
                            listCanceledNo.Add(cancelNo);
                        }

                        var report = new Report();
                        report.InvoiceType = "VAT Invoice";
                        report.Pattern = patternName;
                        report.Serial = serialName;

                        report.TotalBegining = totalBegining;
                       
                        report.FromBuyNo = null;
                        report.ToBuyNo = null;

                        report.FromBeginingNo =
                            Math.Min(1, CalTotalClosingStock(priod - 1, year, patternName, serialName));
                        report.ToBeginingNo =
                            Math.Max(1, CalTotalClosingStock(priod - 1, year, patternName, serialName));

                        //TotalAllInvoice = listIssued.Count() + listCanceled.Count(),
                        report.TotalAllInvoice = ListAllInvoice.Count();
                        if (ListAllInvoice.FirstOrDefault() != null)
                        {
                            report.FromAllInvoice = ListAllInvoice.FirstOrDefault().No;
                            report.ToAllInvoice = ListAllInvoice.LastOrDefault().No;
                            report.FromClosingStock = ListAllInvoice.LastOrDefault().No + 1;
                        }
                        else
                        {
                            report.FromAllInvoice = null;
                            report.ToAllInvoice = null;
                            report.FromClosingStock = null;
                        }

                        report.TotalIssued = listIssued.Count();
                        report.TotalCanceled = listCanceled.Count();

                        report.ListCanceled = new List<int>(listCanceledNo);

                        report.TotalClosingStock = totalBegining - ListAllInvoice.Count();

                        report.ToClosingStock = totalBegining;

                        listReport.Add(report);
                    }
                }

                return listReport;
            }
        }

        private int CalTotalClosingStock(int priod, int year, string patternName, string serialName)
        {
            // Tong so ton cuoi ky = so begining - tat ca hoa don da su dung
            int totalBegining;
            var listIssued = ListIssueInvoice(priod, year, patternName, serialName);
            var listCanceled = ListCancelInvoice(priod, year, patternName, serialName);
            var ListAllInvoice = listCanceled.Concat(listIssued).OrderBy(x => x.No).ToList();
            if (priod == 1 && year == 2018)
            {
                totalBegining = 1000;
                return totalBegining - ListAllInvoice.Count();
            }

            else if (priod == 2)
            {
                totalBegining = CalTotalClosingStock(1, 2018, patternName, serialName);
                return totalBegining - ListAllInvoice.Count();
            }
            else if (priod == 3)
            {
                totalBegining = CalTotalClosingStock(2, year, patternName, serialName);
                return totalBegining - ListAllInvoice.Count();
            }
            else
            {
                totalBegining = CalTotalClosingStock(3, year, patternName, serialName);
                return totalBegining - ListAllInvoice.Count();
            }

        }

        private IList<Invoice> ListCancelInvoice(int priod, int year, string pattern, string serial)
        {
            var months = GetMonth(priod);
            var month1 = months.ElementAt(0);
            var month2 = months.ElementAt(1);
            var month3 = months.ElementAt(2);
            return _repository.GetMulti(x => x.Status == InvoiceStatus.Cancel.ToString()
                                             && x.Pattern.Name == pattern
                                             && x.Serial.Name == serial
                                             && x.ReleaseDate.Value.Year == year
                                             && (x.ReleaseDate.Value.Month == month1
                                                 || x.ReleaseDate.Value.Month == month2
                                                 || x.ReleaseDate.Value.Month == month3)).ToList();
        }

        private IList<Invoice> ListIssueInvoice(int priod, int year, string pattern, string serial)
        {
            var months = GetMonth(priod);
            var month1 = months.ElementAt(0);
            var month2 = months.ElementAt(1);
            var month3 = months.ElementAt(2);
            return _repository.GetMulti(x => (x.Status == InvoiceStatus.Issued.ToString()
                                             || x.Status == InvoiceStatus.Replace.ToString())&& x.Pattern.Name == pattern
                                             && x.Serial.Name == serial
                                             && x.ReleaseDate.Value.Year == year
                                             && (x.ReleaseDate.Value.Month == month1
                                               || x.ReleaseDate.Value.Month == month2
                                               || x.ReleaseDate.Value.Month == month3)).ToList();
        }

        public IList<int> GetMonth(int quarter)
        {
            var months = new List<int>();
            if (quarter == 1)
            {
                months.Add(1);
                months.Add(2);
                months.Add(3);
                return months;
            }
            else if (quarter == 2)
            {
                months.Add(4);
                months.Add(5);
                months.Add(6);
                return months;
            }
            else if (quarter == 3)
            {
                months.Add(7);
                months.Add(8);
                months.Add(9);
                return months;
            }
            else
            {
                months.Add(10);
                months.Add(11);
                months.Add(12);
                return months;
            }
        }
    }
}