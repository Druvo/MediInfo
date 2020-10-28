using MediInfo.Context;
using MediInfo.Models;
using System;
using System.Linq;


namespace MediInfo.Service.Compares
{
    public class CompareService : ICompareService
    {
        private readonly DBcontext _dbContext;
        public CompareService()
        {
            _dbContext = new DBcontext();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Compare Compare)
        {
            _dbContext.Compare.Add(Compare);
            _dbContext.SaveChanges();
        }

        public void Update(Compare Compare)
        {
            throw new NotImplementedException();
        }
    }
}