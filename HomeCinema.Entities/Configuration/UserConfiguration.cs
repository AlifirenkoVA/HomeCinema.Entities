﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCinema.Entities.Models;

namespace HomeCinema.Entities.Configuration
{
	public class UserConfiguration : EntityBaseConfiguration<User>
	{
		public UserConfiguration()
		{
			Property(u => u.Username).IsRequired().HasMaxLength(100);
			Property(u => u.Email).IsRequired().HasMaxLength(200);
			Property(u => u.HashedPassword).IsRequired().HasMaxLength(200);
			Property(u => u.Salt).IsRequired().HasMaxLength(200);
			Property(u => u.IsLocked).IsRequired();
			Property(u => u.DateCreated);
		}
		
	}
}
