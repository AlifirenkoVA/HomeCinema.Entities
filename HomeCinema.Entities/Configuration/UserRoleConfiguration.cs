using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCinema.Entities.Models;

namespace HomeCinema.Entities.Configuration
{
	public class UserRoleConfiguration : EntityBaseConfiguration<UserRole>
	{
		public UserRoleConfiguration()
		{
			Property(ur => ur.UserId).IsRequired();
			Property(ur => ur.RoleId).IsRequired();
		}
	}
}
