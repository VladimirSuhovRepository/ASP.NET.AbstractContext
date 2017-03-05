using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbContext Context { get; private set; }

        public UnitOfWork(IDbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            if (Context != null)
            {
                Context.SaveChanges();
            }
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
        }
    }
}
