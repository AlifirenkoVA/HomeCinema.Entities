﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCinema.Entities.Models;

namespace HomeCinema.Entities.Configuration
{
	public class StockConfiguration : EntityBaseConfiguration<Stock>
	{
		public StockConfiguration()
		{
			Property(s => s.MovieId).IsRequired();
			Property(s => s.UniqueKey).IsRequired();
			Property(s => s.IsAvailable).IsRequired();
			HasMany(s => s.Rentals).WithRequired(r => r.Stock).HasForeignKey(r => r.StockId);
		}
	}
}
