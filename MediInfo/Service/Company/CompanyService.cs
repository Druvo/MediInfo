using System;
using MediInfo.Context;
using MediInfo.Models;

namespace MediInfo.Service.Companys
{
    public class CompanyService : ICompanyService
    {
        private readonly DBcontext _dbContext;
        public CompanyService()
        {
            _dbContext = new DBcontext();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Company Company)
        {
            _dbContext.Company.Add(Compare);
            _dbContext.SaveChanges();
        }

        public void Update(Company Company)
        {
            throw new NotImplementedException();
        }
    }
}