using MediInfo.Context;
using MediInfo.Models;
using MediInfo.Service.Types;
using System;
using System.Linq;

namespace MediInfo.Service.Types
{
    public class TypeService : ITypeService
    {
        private readonly DBcontext _dbContext;
        public TypeService()
        {
            _dbContext = new DBcontext();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Models.Type> GetAllTypes()
        {
            var allType = from c in _dbContext.Type select c;
            return allType;
        }

        public void Insert(Models.Type Type)
        {
            _dbContext.Type.Add(Type);
            _dbContext.SaveChanges();
        }

        public void Update(Models.Type Type)
        {
            throw new NotImplementedException();
        }
    }
}