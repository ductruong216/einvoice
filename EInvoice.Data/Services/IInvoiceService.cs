using System.Collections.Generic;
using EInvoice.Data.Data;

namespace EInvoice.Data.Services
{
	public interface IInvoiceService : IBaseService<Invoice>
	{
		void AddDraft(Invoice invoice);
		void UpdateInvoice(Invoice invoice);
		void DeleteInvoice(int id);
		void Issue(int invoiceId);
		IList<Serial> GetSeries();
		IEnumerable<Serial> GetSeriesByPattern(int id);
	    int GetInvoiceNumber(Invoice invoice);
        void SaveAndIssue(Invoice invoice);
		IList<Invoice> GetAllDraft();
		IList<Invoice> GetAllRelease();
	    IList<Invoice> GetAllCancel();
	    IList<Invoice> GetAllReplace();
        void CancelIssuedInvoice(int invoiceId);
        void ReplaceIssuedInvoice(int invoiceId);
        void NewReplace(Invoice invoice);
        IList<DTO.Report> ReportOnUseInvoices(int period, int year);
    }
}