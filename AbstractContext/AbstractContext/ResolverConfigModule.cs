using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public class ResolverConfigModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            this.Bind<IDbContext>().To<FakeContext>().InRequestScope();
            this.Bind<IUserService>().To<UserService>();
            this.Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
