using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public interface IFakeContext
    {
        IDbSet<User> Users { get; set; }
        int SaveChanges();
    }
}
