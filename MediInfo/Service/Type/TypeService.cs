using MediInfo.Context;
using MediInfo.Models;
using MediInfo.Service.Types;
using System;



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