using EInvoice.Data.Data;
using EInvoice.Data.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EInvoice.Repository
{
	public class BaseRepository<T> : IRepository<T> where T : class
	{
		#region Properties

		private readonly InvoiceEntities _dbContext;
		protected readonly DbSet<T> _dbSet;
		public DbSet<T> DbSet => _dbSet;

		public IDbFactory DbFactory => _dbContext;

		public BaseRepository(IDbFactory dbFactory)
		{
			_dbContext = dbFactory as InvoiceEntities;
			_dbSet = _dbContext.Set<T>();
		}
	

		#endregion Properties

		public void Add(T entity)
		{
			_dbSet.Add(entity);
		}

		public void Delete(T entity)
		{
			_dbSet.Remove(entity);
		}

		public void Update(T entity)
		{
			_dbSet.Attach(entity);
			_dbContext.Entry(entity).State = EntityState.Modified;
		}

		public void DeleteByID(int id)
		{
			_dbSet.Remove(_dbSet.Find(id));
		}

		public T GetSingleById(object id)
		{
			return _dbSet.Find(id);
		}

		public void DeleteMulti(Expression<Func<T, bool>> where)
		{
			IEnumerable<T> objects = DbSet.Where<T>(where).AsEnumerable();
			foreach (var item in objects)
			{
				_dbSet.Remove(item);
			}
		}

		public bool CheckContains(Expression<Func<T, bool>> predicate)
		{
			return _dbContext.Set<T>().Count<T>(predicate) > 0;
		}

		public int Count(Expression<Func<T, bool>> where)
		{
			return _dbSet.Count(where);
		}

		public IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null)
		{
			//HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
			if (includes != null && includes.Count() > 0)
			{
				var query = _dbContext.Set<T>().Include(includes.First());
				foreach (var include in includes.Skip(1))
					query = query.Include(include);
				// Muili items
				return query.Where<T>(predicate).AsQueryable<T>();
			}

			return _dbContext.Set<T>().Where<T>(predicate).AsQueryable<T>();
		}

		public IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 20, string[] includes = null)
		{
			throw new NotImplementedException();
		}

		public T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null)
		{
			throw new NotImplementedException();
		}

		public IList<T> GetAll()
		{
			return _dbSet.ToList();
		}
	}
	
}