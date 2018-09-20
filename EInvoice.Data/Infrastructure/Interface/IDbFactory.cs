using EInvoice.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EInvoice.Data.Infrastructure.Interface
{
	public interface IDbFactory : IDisposable
	{
		InvoiceEntities Init();
	}
}
