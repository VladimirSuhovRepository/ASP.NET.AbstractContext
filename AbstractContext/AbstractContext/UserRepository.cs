using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public class UserRepository:IUserRepository
    {
        IDbContext _context;
        public UserRepository(IDbContext context)
        {
            _context = context;
        }

        public User GetUser(int id)
        {
            return _context.Users.Find(id);
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int key)
        {
            return _context.Users.Find(key);
        }

        public User GetByPredicate(Expression<Func<User, bool>> f)
        {
            throw new NotImplementedException();
        }

        public void Create(User e)
        {
            _context.Users.Add(e);
            _context.SaveChanges();
        }

        public void Delete(User e)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
