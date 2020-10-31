using System;
using System.Linq;
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

        public IQueryable<Company> GetAllCompny()
        {
            var allCompany = from c in _dbContext.Company select c;
            return allCompany;
        }

        public void Insert(Company Company)
        {
            _dbContext.Company.Add(Company);
            _dbContext.SaveChanges();
        }

        public void Update(Company Company)
        {
            throw new NotImplementedException();
        }
    }
}