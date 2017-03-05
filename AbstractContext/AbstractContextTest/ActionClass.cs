using AbstractContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContextTest
{
    public class ActionClass
    {
        private readonly IUserService _userService;
        public ActionClass(IUserService userService)
        {
            _userService = userService;
        }

        public string DoWork()
        {
            var user = new User { Name = "Test without database" };
            _userService.AddUser(user);
            return _userService.GetUser(0).Name;
        }
    }
}
