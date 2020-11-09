using MediInfo.Context;
using MediInfo.Models;
using System;
using System.Linq;

namespace MediInfo.Service.Consumers
{
    public class CustemerServices : ICustemerServices
    {
        private readonly DBcontext _dbContext;
        public CustemerServices()
        {
            _dbContext = new DBcontext();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customers> GetAllCustomers()
        {
            var allConsumer = from c in _dbContext.Customers select c;
            return allConsumer;
        }

        public void Insert(Customers Customer)
        {
            _dbContext.Customers.Add(Customer);
            _dbContext.SaveChanges();
        }

        public void Update(Customers Customers)
        {
            throw new NotImplementedException();
        }
    }
}