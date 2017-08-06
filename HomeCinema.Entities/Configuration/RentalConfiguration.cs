using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCinema.Entities.Models;

namespace HomeCinema.Entities.Configuration
{
	public class RentalConfiguration : EntityBaseConfiguration<Rental>
	{
		public RentalConfiguration()
		{
			Property(r => r.CustomerId).IsRequired();
			Property(r => r.StockId).IsRequired();
			Property(r => r.Status).IsRequired().HasMaxLength(10);
			Property(r => r.ReturnedDate).IsOptional();
		}

	}
}
