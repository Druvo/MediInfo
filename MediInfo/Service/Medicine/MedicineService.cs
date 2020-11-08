using MediInfo.Context;
using MediInfo.Models;
using System;
using System.Linq;


namespace MediInfo.Service.Medicines
{
    public class MedicineService : IMedicineService
    {
        private readonly DBcontext _dbContext;
        public MedicineService()
        {
            _dbContext = new DBcontext();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Medicine> GetAllMedi()
        {
            var allCompany = from c in _dbContext.Medicine select c;
            return allCompany;
        }

        public void Insert(Medicine Medicine)
        {
            _dbContext.Medicine.Add(Medicine);
            _dbContext.SaveChanges();
        }

        public void Update(Medicine Medicine)
        {
            throw new NotImplementedException();
        }
    }
}