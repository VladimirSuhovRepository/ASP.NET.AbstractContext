using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public interface IUserService
    {
        User GetUser(int id);
        void AddUser(User user);
        
    }
}
