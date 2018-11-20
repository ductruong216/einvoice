using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace EInvoice.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private IDbFactory _dataContext;
		private bool _disposed;
		private ObjectContext _objectContext;
		private DbTransaction _transaction;
		private Dictionary<Type, object> _repositories;

		public UnitOfWork(IDbFactory dataContext)
		{
			_dataContext = dataContext;
			_repositories = new Dictionary<Type, object>();
		}


		public int SaveChanges()
		{
			return _dataContext.SaveChanges();
		}
		public  void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (disposing)
				{
					_dataContext.Dispose();
				}
			}
			this._disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public IRepository<TEntity> Repository<TEntity>() where TEntity : class
		{
			if (_repositories.Keys.Contains(typeof(TEntity)))
				return (IRepository<TEntity>)_repositories[typeof(TEntity)];

			var repository = new BaseRepository<TEntity>(_dataContext);

			_repositories.Add(typeof(TEntity), repository);

			return (IRepository<TEntity>)_repositories[typeof(TEntity)];
		}

		public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
		{
			_objectContext = ((IObjectContextAdapter)_dataContext).ObjectContext;
			if (_objectContext.Connection.State != ConnectionState.Open)
			{
				_objectContext.Connection.Open();
			}

			_transaction = _objectContext.Connection.BeginTransaction(isolationLevel);
		}

		public bool Commit()
		{
			_transaction.Commit();
			return true;
		}

		public void Rollback()
		{
			_transaction.Rollback();
		}

	
	}
}