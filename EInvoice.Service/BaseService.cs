using EInvoice.Data.Infrastructure.Interface;
using EInvoice.Data.Services;
using System;
using System.Collections.Generic;

namespace EInvoice.Service
{
	public class BaseService<T> : IBaseService<T> where T : class
	{
		protected IRepository<T> _repository;
		protected IUnitOfWork _unitOfWork;

		public BaseService(IRepository<T> repository, IUnitOfWork unitOfWork)
		{
			_repository = repository;			
			_unitOfWork = unitOfWork;
		}


		public void Add(T entity)
		{
			try
			{
				_repository.Add(entity);
				_unitOfWork.Commit();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void Delete(T entity)
		{
			try
			{
				_repository.Delete(entity);
				_unitOfWork.Commit();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void DeleteByID(int id)
		{
			try
			{
				_repository.DeleteByID(id);
				_unitOfWork.Commit();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public IList<T> GetAll()
		{
			return _repository.GetAll();
		}

		public T GetSingleById(object id)
		{
			return _repository.GetSingleById(id);
		}

		public void Save()
		{
			_unitOfWork.Commit();
		}

		public void Update(T entity)
		{
			try
			{
				_repository.Update(entity);
				_unitOfWork.Commit();
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}