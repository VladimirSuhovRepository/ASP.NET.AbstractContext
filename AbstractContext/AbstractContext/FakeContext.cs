using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public class FakeContext : IFakeContext
    {
        public FakeContext()
        {
            Users = new UserDbSet();
        }
        public virtual IDbSet<User> Users { get; set; }
        public int SaveChanges()
        {
            return 0;
        }
    }
}
