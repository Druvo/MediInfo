using MediInfo.Context;
using MediInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MediInfo.Service.Categorie
{
    public class CategorieService : ICategorieService
    {
        private readonly DBcontext _dbContext;
        public CategorieService()
        {
            _dbContext = new DBcontext();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Categories> GetAllCategories()
        {
            var allCategories = from c in _dbContext.Categories select c;
            return allCategories;
        }

        public void Insert(Categories Categories)
        {
            _dbContext.Categories.Add(Categories);
            _dbContext.SaveChanges();
        }

        public void Update(Categories Categories)
        {
            throw new NotImplementedException();
        }
    }
}