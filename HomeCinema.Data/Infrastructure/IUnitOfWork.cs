using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCinema.Data.Infrastructure
{
    public interface IUnitOfWork
    {
	    void Commit();
    }
}
