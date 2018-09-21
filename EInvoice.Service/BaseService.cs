using EInvoice.Data.Infrastructure.Interface;
using System.Collections.Generic;
using System.Linq;

namespace EInvoice.Service
{
	public interface IBaseService<T> where T : class
	{
		void Add(T entity);

		void Delete(T entity);

		void Update(T entity);

		void DeleteByID(int id);

		IList<T> GetAll();
		T GetSingleById(int id);

		void Save();

	}

	public class BaseService<T> : IBaseService<T> where T : class
	{
		IRepository<T> _repository;
		IUnitOfWork _unitOfWork;
		public BaseService(IRepository<T> repository, IUnitOfWork unitOfWork)
		{
			_repository = repository;
			_unitOfWork = unitOfWork;
		}
		public void Add(T entity)
		{
			_repository.Add(entity);
		}

		public void Delete(T entity)
		{
			_repository.Delete(entity);
		}

		public void DeleteByID(int id)
		{
			_repository.DeleteByID(id);
		}

		public IList<T> GetAll()
		{
			 return _repository.GetAll();
		}

		public T GetSingleById(int id)
		{
			return _repository.GetSingleById(id);
		}

		public void Save()
		{
			_unitOfWork.Commit();
		}

		public void Update(T entity)
		{
			_repository.Update(entity);
		}
	}
}