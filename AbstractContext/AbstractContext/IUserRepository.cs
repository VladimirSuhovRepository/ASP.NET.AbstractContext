using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public interface IUserRepository : IRepository<User>//Add user repository methods!
    {
    }
}
