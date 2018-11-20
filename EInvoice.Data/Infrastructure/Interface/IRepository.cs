using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using EInvoice.Data.Data;

namespace EInvoice.Data.Infrastructure.Interface
{
	public interface IRepository<T> where T : class
	{
		DbSet<T> DbSet { get; }

		void Add(T entity);

		void Delete(T entity);

		void Update(T entity);

		void DeleteByID(int id);

		IList<T> GetAll();

		// Delete with multi conditions
		void DeleteMulti(Expression<Func<T, bool>> where);

		// Get an entity by int ID
		T GetSingleById(object id);

		// Get an entity by conditions
		T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

		// IQueryable
	

		// GetMulti Queryable
		IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

		// Paging pages
		IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> predicate, out int total, int index = 0, int size = 20, string[] includes = null);

		int Count(Expression<Func<T, bool>> where);

		// CheckContains
		bool CheckContains(Expression<Func<T, bool>> predicate);
	}
}