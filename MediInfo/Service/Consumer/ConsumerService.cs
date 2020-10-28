using MediInfo.Context;
using MediInfo.Models;
using System;


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