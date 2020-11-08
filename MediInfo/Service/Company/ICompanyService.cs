using MediInfo.Models;
using System.Linq;

namespace MediInfo.Service.Companys
{
    public interface ICompanyService
    {
        void Insert(Company Compare);
        void Delete(int Id);
        Company GetCompanyById(int Id);
        void Update(Company Compare);
        IQueryable<Company> GetAllCompny();
    }
}