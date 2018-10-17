using System.Collections.Generic;

namespace EInvoice.Data.Services
{
	public interface IBaseService<T> where T : class
	{
		void Add(T entity);

		void Delete(T entity);

		void Update(T entity);

		void DeleteByID(int id);

		IList<T> GetAll();

		T GetSingleById(object id);

		void Save();
	}
}