using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork uow;
        private readonly IUserRepository userRepository;
        public UserService(IUnitOfWork uow, IUserRepository repository)
        {
            this.uow = uow;
            this.userRepository = repository;
        }
 
        public User GetUser(int id)
        {
            return userRepository.GetById(id);
        }

        public void AddUser(User user)
        {
            userRepository.Create(user);
            uow.Commit();
        }
       
    }
}
