using MediInfo.Models;
using System.Linq;

namespace MediInfo.Service.Consumers
{
    public partial interface ICustemerServices
    {
        void Insert(Customers Customers);
        void Delete(int Id);
        void Update(Customers Consumer);
        IQueryable<Customers> GetAllCustomers();
    }
}