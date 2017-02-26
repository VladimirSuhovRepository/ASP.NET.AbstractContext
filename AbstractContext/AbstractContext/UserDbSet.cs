using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public class UserDbSet : FakeDbSet<User>
    {
        public override User Find(params object[] keyValues)
        {
            var keyValue = (int)keyValues.FirstOrDefault();
            return this.SingleOrDefault(r => r.Id == keyValue);
        }
    }
}
