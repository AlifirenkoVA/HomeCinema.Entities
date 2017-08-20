using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HomeCinema.Entities.Infrastructure;
using HomeCinema.Entities.Models;

namespace HomeCinema.Entities.Repositories
{
	public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
	// must be like in book: public interface IEntityBaseRepository<T> : IEntityBaseRepository where T : class, IEntityBase, new()

	{
		IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
		IQueryable<T> All { get; }
		IQueryable<T> GetAll();
		T GetSingle(int id);
		IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
		void Add(T entity);
		void Delete(T entity);
		void Edit(T entity);
	}
}
