using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCinema.Data.Infrastructure
{
	public class DbFactory : Disposable, IDbFactory
	{
		HomeCinemaContext dbContext;

		public HomeCinemaContext Init()
		{
			return dbContext ?? (dbContext = new HomeCinemaContext());
		}

		protected override void DisposeCore()
		{
			dbContext?.Dispose();
		}
		
	}
}
