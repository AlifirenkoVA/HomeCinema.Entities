using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;
using HomeCinema.Entities.Models;

namespace HomeCinema.Entities.Configuration
{
	public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class,
		IEntityBase
	{
		public EntityBaseConfiguration()
		{
			HasKey(e => e.ID);
		}
	}
}
