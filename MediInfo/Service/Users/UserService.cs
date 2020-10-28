using System;
using MediInfo.Context;
using MediInfo.Models;

namespace MediInfo.Service.Users
{
    public class UserService : IUserService
    {
        private readonly DBcontext _dbContext;
        public UserService()
        {
            _dbContext = new DBcontext();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User User)
        {
            _dbContext.User.Add(User);
            _dbContext.SaveChanges();
        }

        public void Update(User User)
        {
            throw new NotImplementedException();
        }
    }
}