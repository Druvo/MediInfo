using MediInfo.Context;
using MediInfo.Models;
using System;
using System.Linq;

namespace MediInfo.Service.Consumers
{
    public class ConsumerService : IConsumerService
    {
        private readonly DBcontext _dbContext;
        public ConsumerService()
        {
            _dbContext = new DBcontext();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Consumer> GetAllConsumer()
        {
            var allConsumer = from c in _dbContext.Consumer select c;
            return allConsumer;
        }

        public void Insert(Consumer Consumer)
        {
            _dbContext.Consumer.Add(Consumer);
            _dbContext.SaveChanges();
        }

        public void Update(Consumer Consumer)
        {
            throw new NotImplementedException();
        }
    }
}