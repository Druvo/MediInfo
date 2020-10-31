using System;
using System.Linq;
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

        public bool Insert(User User)
        {
            _dbContext.User.Add(User);
            _dbContext.SaveChanges();
            return true;
        }

        public bool is_valid(string email, string password)
        {
            var user = _dbContext.User.Where(x => x.Email.Equals(email) && x.Password.Equals(password)).FirstOrDefault();
            if (user != null)
            {
                user.IsActive = true;
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool check_existing_user(string email)
        {
            var user = _dbContext.User.Where(x => x.Email.Equals(email)).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Update(User User)
        {
            throw new NotImplementedException();
        }
    }
}