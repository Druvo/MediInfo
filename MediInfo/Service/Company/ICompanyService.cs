using MediInfo.Models;

namespace MediInfo.Service.Companys
{
    public interface ICompanyService
    {
        void Insert(Company Compare);
        void Delete(int Id);
        void Update(Company Compare);
    }
}