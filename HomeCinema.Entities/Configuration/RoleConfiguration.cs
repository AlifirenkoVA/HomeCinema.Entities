using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCinema.Entities.Models;

namespace HomeCinema.Entities.Configuration
{
	public class RoleConfiguration : EntityBaseConfiguration<Role>
	{
		public RoleConfiguration()
		{
			Property(ur => ur.Name).IsRequired().HasMaxLength(50);
		}
	}

}
