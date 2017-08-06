using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCinema.Entities.Models;

namespace HomeCinema.Entities.Configuration
{
	public class GenreConfiguration : EntityBaseConfiguration<Genre>
	{
		public GenreConfiguration()
		{
			Property(g => g.Name).IsRequired().HasMaxLength(50);
		}
	}
}
